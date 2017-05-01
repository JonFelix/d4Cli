using System;
using System.Collections.Generic;
using System.Windows.Forms;
using d4Cli.Data;
using System.IO;

namespace d4Cli
{
    public partial class Form1 : Form
    {
        List<ClipboardItem> _list = new List<ClipboardItem>();
        List<string> _logMessages = new List<string>();
        private bool _logTimestamp = true;
        private bool _logIsShown = true;
        private float _logSize = 0.2f;
        private string _browserText = "";
        private string _style= "";

        public Form1()
        {
            InitializeComponent();
            MenuLogIsShown.Checked = _logIsShown;
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
            }
            timer1.Enabled = true;
        }

        private void AddItem()
        {               
            ClipboardItem cbi = new ClipboardItem();
            cbi.Text = Clipboard.GetText();
            cbi.Timestamp = DateTime.Now;
            Log("Add '" + cbi.Text + "' to clipboard memory.");
            _list.Add(cbi);
            AddToBrowser(cbi);                
        }

        public void Log(string text)
        {
            if(_logTimestamp)
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
            if(_logIsShown)
            {
                LogSplitter.Panel2.Hide();

                LogSplitter.SplitterDistance = Size.Height;
            }
            else
            {
                LogSplitter.Panel2.Show();
            }
            _logIsShown = !_logIsShown;
            MenuLogIsShown.Checked = _logIsShown;
            ResizeLogBox();
        } 

        private void ResizeLogBox()
        {
            if(_logIsShown)
            {
                LogSplitter.SplitterDistance = (int)(Size.Height * (1 - _logSize));    
            }                                                     
        }

        private void AddToBrowser(ClipboardItem cbi)
        {
            ReadStyle();
            string preText = "<div class=\"item\"><div class=\"timestamp\">" + cbi.Timestamp.ToLocalTime().ToString() + "</div><div class=\"text\">";
            string postText = "</div></div>";
            _browserText = preText + cbi.Text + postText + _browserText;
            Browser.DocumentText = "<!DOCTYPE html><html><head><meta http-equiv=\"X - UA - Compatible\" content =\"IE = 9\" /><style>" + _style + "</style></head><body>" + _browserText + "</body></html>";
        }

        private void ReadStyle()
        {
            _style = File.ReadAllText(@"style.css");
        }
    }
}
