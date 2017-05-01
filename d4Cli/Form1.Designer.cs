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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LogBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LogSplitter = new System.Windows.Forms.SplitContainer();
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMinimizeOnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLogTimestamp = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLogIsShown = new System.Windows.Forms.ToolStripMenuItem();
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
            this.LogBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LogBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LogBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogBox.ForeColor = System.Drawing.SystemColors.InfoText;
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
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMinimizeOnClose,
            this.MenuLogTimestamp});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // MenuMinimizeOnClose
            // 
            this.MenuMinimizeOnClose.Name = "MenuMinimizeOnClose";
            this.MenuMinimizeOnClose.Size = new System.Drawing.Size(170, 22);
            this.MenuMinimizeOnClose.Text = "Minimize on close";
            this.MenuMinimizeOnClose.Click += new System.EventHandler(this.MenuMinimizeOnClose_Click);
            // 
            // MenuLogTimestamp
            // 
            this.MenuLogTimestamp.Name = "MenuLogTimestamp";
            this.MenuLogTimestamp.Size = new System.Drawing.Size(170, 22);
            this.MenuLogTimestamp.Text = "Log timestamp";
            this.MenuLogTimestamp.Click += new System.EventHandler(this.logTimestampToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuLogIsShown});
            this.viewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(618, 527);
            this.Controls.Add(this.LogSplitter);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Clipboard Manager";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
        private System.Windows.Forms.ToolStripMenuItem MenuMinimizeOnClose;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuLogTimestamp;
    }
}

