namespace d4Cli
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LogSplitter = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLogIsShown = new System.Windows.Forms.ToolStripMenuItem();
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LogSplitter)).BeginInit();
            this.LogSplitter.Panel1.SuspendLayout();
            this.LogSplitter.Panel2.SuspendLayout();
            this.LogSplitter.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogBox
            // 
            this.LogBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LogBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogBox.Location = new System.Drawing.Point(0, 0);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.Size = new System.Drawing.Size(618, 260);
            this.LogBox.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LogSplitter
            // 
            this.LogSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogSplitter.IsSplitterFixed = true;
            this.LogSplitter.Location = new System.Drawing.Point(0, 0);
            this.LogSplitter.Name = "LogSplitter";
            this.LogSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // LogSplitter.Panel1
            // 
            this.LogSplitter.Panel1.Controls.Add(this.Browser);
            this.LogSplitter.Panel1.Controls.Add(this.menuStrip1);
            // 
            // LogSplitter.Panel2
            // 
            this.LogSplitter.Panel2.Controls.Add(this.LogBox);
            this.LogSplitter.Panel2.Enabled = false;
            this.LogSplitter.Size = new System.Drawing.Size(618, 527);
            this.LogSplitter.SplitterDistance = 263;
            this.LogSplitter.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuLogIsShown});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // MenuLogIsShown
            // 
            this.MenuLogIsShown.Checked = true;
            this.MenuLogIsShown.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuLogIsShown.Name = "MenuLogIsShown";
            this.MenuLogIsShown.Size = new System.Drawing.Size(94, 22);
            this.MenuLogIsShown.Text = "Log";
            this.MenuLogIsShown.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // Browser
            // 
            this.Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Browser.IsWebBrowserContextMenuEnabled = false;
            this.Browser.Location = new System.Drawing.Point(0, 24);
            this.Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Browser.Name = "Browser";
            this.Browser.ScriptErrorsSuppressed = true;
            this.Browser.ScrollBarsEnabled = false;
            this.Browser.Size = new System.Drawing.Size(618, 239);
            this.Browser.TabIndex = 1;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 527);
            this.Controls.Add(this.LogSplitter);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LogSplitter.Panel1.ResumeLayout(false);
            this.LogSplitter.Panel1.PerformLayout();
            this.LogSplitter.Panel2.ResumeLayout(false);
            this.LogSplitter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogSplitter)).EndInit();
            this.LogSplitter.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer LogSplitter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuLogIsShown;
        private System.Windows.Forms.WebBrowser Browser;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

