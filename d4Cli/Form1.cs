using System;
using System.Collections.Generic;
using System.Windows.Forms;
using d4Cli.Data;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace d4Cli
{
    public partial class Form1 : Form
    {
        List<ClipboardItem> _list = new List<ClipboardItem>();
        List<string> _logMessages = new List<string>();  
        private float _logSize = 0.2f;
        private string _browserText = "";
        private string _style= "";              
        private bool _approvedClose = false;
        private ClientSettings _settings;

        public Form1()
        {
            InitializeComponent();
            LoadConfig();
            MenuLogIsShown.Checked = _settings.LogIsShown;
            MenuMinimizeOnClose.Checked = _settings.MinimizeOnClose;
            MenuLogTimestamp.Checked = _settings.LogTimestamp;
            MenuStartWithWindows.Checked = _settings.StartWithWindows;
            ResizeLogBox();
            Browser.DocumentText = _browserText;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Clipboard.ContainsText())
            {
                if(_list.Count == 0)
                {
                    AddItem();   
                }
                if(Clipboard.GetText() != _list[_list.Count - 1].Text)
                {
                    AddItem();
                }
                while(_list.Count > 20)
                {
                    _list.RemoveAt(_list.Count - 1);    
                }
            }
            timer1.Enabled = true;
        }

        private void AddItem()
        {               
            ClipboardItem cbi = new ClipboardItem(Clipboard.GetText());
            Log("Add '" + cbi.Text + "' to clipboard memory.");
            _list.Add(cbi);
            AddToBrowser(cbi);                
        }

        public void Log(string text)
        {
            if(_settings.LogTimestamp)
            {
                string timestamp = "[";
                timestamp += DateTime.Now.Hour.ToString() + ":";
                timestamp += DateTime.Now.Minute.ToString() + ":";
                timestamp += DateTime.Now.Second.ToString() + ":";
                timestamp += DateTime.Now.Millisecond.ToString() + "] ";
                text = timestamp + text;
            }
            _logMessages.Add(text);
            if(_logMessages.Count > 1)
            {
                text = Environment.NewLine + text;
            }
            LogBox.AppendText(text);
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_settings.LogIsShown)
            {
                LogSplitter.Panel2.Hide();

                LogSplitter.SplitterDistance = Size.Height;
            }
            else
            {
                LogSplitter.Panel2.Show();
            }
            _settings.LogIsShown = !_settings.LogIsShown;
            MenuLogIsShown.Checked = _settings.LogIsShown;
            WriteConfig();
            ResizeLogBox();
        } 

        private void ResizeLogBox()
        {
            if(_settings.LogIsShown)
            {
                LogSplitter.SplitterDistance = (int)(Size.Height * (1 - _logSize));    
            }                                                     
        }

        private void AddToBrowser(ClipboardItem cbi)
        {
            ReadStyle();
            string preText = "<div class=\"item\"><div class=\"timestamp\">" + cbi.Timestamp.ToLocalTime().ToString() + " | " + cbi.WindowTitle + "</div><div class=\"text\">";
            string postText = "</div></div>";
            _browserText = preText + cbi.Text + postText + _browserText;
            Browser.DocumentText = "<!DOCTYPE html><html><head><meta http-equiv=\"X - UA - Compatible\" content =\"IE = 9\" /><style>" + _style + "</style></head><body>" + _browserText + "</body></html>";
        }

        private void ReadStyle()
        {
            _style = File.ReadAllText(@"style.css");
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {                                                
            Hide();
        }

        
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {                                                
            Show();
            Activate();
        }

        private void MenuMinimizeOnClose_Click(object sender, EventArgs e)
        {
            _settings.MinimizeOnClose = !_settings.MinimizeOnClose;
            MenuMinimizeOnClose.Checked = _settings.MinimizeOnClose;
            WriteConfig();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(_settings.MinimizeOnClose && !_approvedClose)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _approvedClose = true;
            Close();
        }   

        private void logTimestampToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _settings.LogTimestamp = !_settings.LogTimestamp;
            MenuLogTimestamp.Checked = _settings.LogTimestamp;
            WriteConfig();
        }

        private void LoadConfig()
        {
            string cfg = Environment.CurrentDirectory + @"/config.json";
            _settings = JsonConvert.DeserializeObject<ClientSettings>(File.ReadAllText(cfg));
        }

        private void WriteConfig()
        {
            string cfg = Environment.CurrentDirectory + @"/config.json";
            File.WriteAllText(cfg, JsonConvert.SerializeObject(_settings, Formatting.Indented));
        }

        private void startWithWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!_settings.StartWithWindows)
            {
                string fileName = "sd4 Clipboard Manager.lnk";
                string startupFolder = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"/";
                if(!File.Exists(startupFolder + fileName))
                {
                    Type t = Type.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")); //Windows Script Host Shell Object
                    dynamic shell = Activator.CreateInstance(t);
                    try
                    {
                        var lnk = shell.CreateShortcut(fileName);
                        try
                        {
                            lnk.TargetPath = Environment.CurrentDirectory + @"/d4Cli.exe";
                            lnk.IconLocation = Environment.CurrentDirectory + @"/icon.ico";
                            lnk.Save();
                        }
                        finally
                        {
                            Marshal.FinalReleaseComObject(lnk);
                        }
                    }
                    finally
                    {
                        Marshal.FinalReleaseComObject(shell);
                    }
                    File.Copy(Environment.CurrentDirectory + @"/" + fileName, startupFolder + fileName);
                    File.Delete(Environment.CurrentDirectory + @"/" + fileName);
                }
            }
            else
            {
                string fileName = "sd4 Clipboard Manager.lnk";
                string startupFolder = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"/";
                if(File.Exists(startupFolder + fileName))
                {
                    File.Delete(startupFolder + fileName);
                }
            }
            _settings.StartWithWindows = !_settings.StartWithWindows;
            MenuStartWithWindows.Checked = _settings.StartWithWindows;
            WriteConfig();
        }
    }
}
