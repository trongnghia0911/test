namespace Algorithmus
{
    partial class FrmMain
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
            if (disposing && (components != null))
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
					this.menuStrip1 = new System.Windows.Forms.MenuStrip();
					this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
					this.ItmExit = new System.Windows.Forms.ToolStripMenuItem();
					this.algorithmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
					this.physicalTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
					this.ItmCristian = new System.Windows.Forms.ToolStripMenuItem();
					this.communicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
					this.ItmWebService = new System.Windows.Forms.ToolStripMenuItem();
					this.TxtLogs = new System.Windows.Forms.TextBox();
					this.menuStrip1.SuspendLayout();
					this.SuspendLayout();
					// 
					// menuStrip1
					// 
					this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.algorithmsToolStripMenuItem,
            this.communicationToolStripMenuItem});
					this.menuStrip1.Location = new System.Drawing.Point(0, 0);
					this.menuStrip1.Name = "menuStrip1";
					this.menuStrip1.Size = new System.Drawing.Size(749, 24);
					this.menuStrip1.TabIndex = 0;
					this.menuStrip1.Text = "menuStrip1";
					// 
					// fileToolStripMenuItem
					// 
					this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItmExit});
					this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
					this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
					this.fileToolStripMenuItem.Text = "File";
					// 
					// ItmExit
					// 
					this.ItmExit.Name = "ItmExit";
					this.ItmExit.Size = new System.Drawing.Size(103, 22);
					this.ItmExit.Text = "Exit";
					this.ItmExit.Click += new System.EventHandler(this.ItmExit_Click);
					// 
					// algorithmsToolStripMenuItem
					// 
					this.algorithmsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.physicalTimeToolStripMenuItem});
					this.algorithmsToolStripMenuItem.Name = "algorithmsToolStripMenuItem";
					this.algorithmsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
					this.algorithmsToolStripMenuItem.Text = "Algorithms";
					// 
					// physicalTimeToolStripMenuItem
					// 
					this.physicalTimeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItmCristian});
					this.physicalTimeToolStripMenuItem.Name = "physicalTimeToolStripMenuItem";
					this.physicalTimeToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
					this.physicalTimeToolStripMenuItem.Text = "Physical Time";
					// 
					// ItmCristian
					// 
					this.ItmCristian.Name = "ItmCristian";
					this.ItmCristian.Size = new System.Drawing.Size(121, 22);
					this.ItmCristian.Text = "Cristian";
					this.ItmCristian.Click += new System.EventHandler(this.ItmCristian_Click);
					// 
					// communicationToolStripMenuItem
					// 
					this.communicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItmWebService});
					this.communicationToolStripMenuItem.Name = "communicationToolStripMenuItem";
					this.communicationToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
					this.communicationToolStripMenuItem.Text = "Communication";
					// 
					// ItmWebService
					// 
					this.ItmWebService.Name = "ItmWebService";
					this.ItmWebService.Size = new System.Drawing.Size(152, 22);
					this.ItmWebService.Text = "Web service";
					this.ItmWebService.Click += new System.EventHandler(this.ItmWebService_Click);
					// 
					// TxtLogs
					// 
					this.TxtLogs.Location = new System.Drawing.Point(12, 47);
					this.TxtLogs.Multiline = true;
					this.TxtLogs.Name = "TxtLogs";
					this.TxtLogs.Size = new System.Drawing.Size(725, 322);
					this.TxtLogs.TabIndex = 1;
					// 
					// FrmMain
					// 
					this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
					this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
					this.ClientSize = new System.Drawing.Size(749, 381);
					this.Controls.Add(this.TxtLogs);
					this.Controls.Add(this.menuStrip1);
					this.MainMenuStrip = this.menuStrip1;
					this.Name = "FrmMain";
					this.Text = "Distributed System Examples";
					this.menuStrip1.ResumeLayout(false);
					this.menuStrip1.PerformLayout();
					this.ResumeLayout(false);
					this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ItmExit;
        private System.Windows.Forms.TextBox TxtLogs;
        private System.Windows.Forms.ToolStripMenuItem algorithmsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem physicalTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ItmCristian;
			private System.Windows.Forms.ToolStripMenuItem communicationToolStripMenuItem;
			private System.Windows.Forms.ToolStripMenuItem ItmWebService;
    }
}

