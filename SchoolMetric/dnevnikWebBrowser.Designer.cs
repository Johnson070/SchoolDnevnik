namespace SchoolMetric
{
    partial class dnevnikWebBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dnevnikWebBrowser));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.backPage = new System.Windows.Forms.ToolStripButton();
            this.upPage = new System.Windows.Forms.ToolStripButton();
            this.updatePage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openSite = new System.Windows.Forms.ToolStripButton();
            this.copyMarks = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backPage,
            this.upPage,
            this.updatePage,
            this.toolStripSeparator1,
            this.openSite,
            this.copyMarks});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1077, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // backPage
            // 
            this.backPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backPage.Image = global::SchoolMetric.Properties.Resources.iconfinder_icon_ios7_arrow_back_211686;
            this.backPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backPage.Name = "backPage";
            this.backPage.Size = new System.Drawing.Size(23, 22);
            this.backPage.Text = "Назад";
            this.backPage.Click += new System.EventHandler(this.backPage_Click);
            // 
            // upPage
            // 
            this.upPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.upPage.Image = global::SchoolMetric.Properties.Resources.iconfinder_icon_ios7_arrow_forward_211688;
            this.upPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.upPage.Name = "upPage";
            this.upPage.Size = new System.Drawing.Size(23, 22);
            this.upPage.Text = "Вперед";
            this.upPage.Click += new System.EventHandler(this.upPage_Click);
            // 
            // updatePage
            // 
            this.updatePage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.updatePage.Image = global::SchoolMetric.Properties.Resources.iconfinder_sync_126579;
            this.updatePage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.updatePage.Name = "updatePage";
            this.updatePage.Size = new System.Drawing.Size(23, 22);
            this.updatePage.Text = "Перезагрузить";
            this.updatePage.Click += new System.EventHandler(this.updatePage_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // openSite
            // 
            this.openSite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openSite.Image = ((System.Drawing.Image)(resources.GetObject("openSite.Image")));
            this.openSite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openSite.Name = "openSite";
            this.openSite.Size = new System.Drawing.Size(117, 22);
            this.openSite.Text = "Открыть dnevnik.ru";
            this.openSite.Click += new System.EventHandler(this.openSite_Click);
            // 
            // copyMarks
            // 
            this.copyMarks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.copyMarks.Image = ((System.Drawing.Image)(resources.GetObject("copyMarks.Image")));
            this.copyMarks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyMarks.Name = "copyMarks";
            this.copyMarks.Size = new System.Drawing.Size(127, 22);
            this.copyMarks.Text = "Скопировать данные";
            this.copyMarks.Click += new System.EventHandler(this.copyMarks_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(12, 28);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1053, 713);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // dnevnikWebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 753);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "dnevnikWebBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dnevnikWebBrowser";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton backPage;
        private System.Windows.Forms.ToolStripButton upPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton openSite;
        private System.Windows.Forms.ToolStripButton copyMarks;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripButton updatePage;
    }
}