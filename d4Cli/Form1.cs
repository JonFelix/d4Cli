using System;
using System.Collections.Generic;     
using System.Windows.Forms;
using d4Cli.Data

namespace d4Cli
{
    public partial class Form1 : Form
    {
        List<ClipboardItem> _list = new List<ClipboardItem>();

        public Form1()
        {
            InitializeComponent();
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
            _list.Add(cbi);
        }
    }
}
