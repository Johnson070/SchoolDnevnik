namespace SchoolMetric
{
    partial class selectBalls
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(selectBalls));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.выбратьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ballRange = new System.Windows.Forms.ToolStripDropDownButton();
            this.отToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.доToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.filterMarks = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.filterBallChecked = new System.Windows.Forms.ToolStripMenuItem();
            this.sorts = new System.Windows.Forms.ToolStripDropDownButton();
            this.поВозростаниюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поУбываниюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поРазницеБалловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positive = new System.Windows.Forms.ToolStripMenuItem();
            this.neutral = new System.Windows.Forms.ToolStripMenuItem();
            this.negative = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mainProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(713, 418);
            this.dataGridView1.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 26);
            // 
            // выбратьToolStripMenuItem
            // 
            this.выбратьToolStripMenuItem.Name = "выбратьToolStripMenuItem";
            this.выбратьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.выбратьToolStripMenuItem.Text = "Выбрать";
            this.выбратьToolStripMenuItem.Click += new System.EventHandler(this.выбратьToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ballRange,
            this.filterMarks,
            this.sorts,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(737, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ballRange
            // 
            this.ballRange.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ballRange.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отToolStripMenuItem,
            this.доToolStripMenuItem});
            this.ballRange.Image = ((System.Drawing.Image)(resources.GetObject("ballRange.Image")));
            this.ballRange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ballRange.Name = "ballRange";
            this.ballRange.Size = new System.Drawing.Size(162, 22);
            this.ballRange.Text = "Диапазон среднего балла";
            // 
            // отToolStripMenuItem
            // 
            this.отToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
            this.отToolStripMenuItem.MergeIndex = 8;
            this.отToolStripMenuItem.Name = "отToolStripMenuItem";
            this.отToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.отToolStripMenuItem.Text = "От";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "2,0",
            "2,1",
            "2,2",
            "2,3",
            "2,4",
            "2,5",
            "2,6",
            "2,7",
            "2,8",
            "2,9",
            "3,0",
            "3,1",
            "3,2",
            "3,3",
            "3,4",
            "3,5",
            "3,6",
            "3,7",
            "3,8",
            "3,9",
            "4,0",
            "4,1",
            "4,2",
            "4,3",
            "4,4",
            "4,5",
            "4,6",
            "4,7",
            "4,8",
            "4,9",
            "5,0"});
            this.toolStripComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.toolStripComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.toolStripComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox2.Items.AddRange(new object[] {
            "2,0",
            "2,1",
            "2,2",
            "2,3",
            "2,4",
            "2,5",
            "2,6",
            "2,7",
            "2,8",
            "2,9",
            "3,0",
            "3,1",
            "3,2",
            "3,3",
            "3,4",
            "3,5",
            "3,6",
            "3,7",
            "3,8",
            "3,9",
            "4,0",
            "4,1",
            "4,2",
            "4,3",
            "4,4",
            "4,5",
            "4,6",
            "4,7",
            "4,8",
            "4,9",
            "5,0"});
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(75, 23);
            this.toolStripComboBox2.Text = "2,0";
            this.toolStripComboBox2.SelectedIndexChanged += new System.EventHandler(this.updateFilterTable);
            // 
            // доToolStripMenuItem
            // 
            this.доToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.доToolStripMenuItem.Name = "доToolStripMenuItem";
            this.доToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.доToolStripMenuItem.Text = "До";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.toolStripComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "5,0",
            "4,9",
            "4,8",
            "4,7",
            "4,6",
            "4,5",
            "4,4",
            "4,3",
            "4,2",
            "4,1",
            "4,0",
            "3,9",
            "3,8",
            "3,7",
            "3,6",
            "3,5",
            "3,4",
            "3,3",
            "3,2",
            "3,1",
            "3,0",
            "2,9",
            "2,8",
            "2,7",
            "2,6",
            "2,5",
            "2,4",
            "2,3",
            "2,2",
            "2,1",
            "2,0"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(75, 23);
            this.toolStripComboBox1.Text = "5,0";
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.updateFilterTable);
            // 
            // filterMarks
            // 
            this.filterMarks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.filterMarks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.filterBallChecked});
            this.filterMarks.Image = ((System.Drawing.Image)(resources.GetObject("filterMarks.Image")));
            this.filterMarks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filterMarks.Name = "filterMarks";
            this.filterMarks.Size = new System.Drawing.Size(104, 22);
            this.filterMarks.Text = "Фильтр оценок";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Checked = true;
            this.toolStripMenuItem2.CheckOnClick = true;
            this.toolStripMenuItem2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem2.Text = "2";
            this.toolStripMenuItem2.CheckStateChanged += new System.EventHandler(this.updateFilterTable);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Checked = true;
            this.toolStripMenuItem3.CheckOnClick = true;
            this.toolStripMenuItem3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem3.Text = "3";
            this.toolStripMenuItem3.CheckStateChanged += new System.EventHandler(this.updateFilterTable);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Checked = true;
            this.toolStripMenuItem4.CheckOnClick = true;
            this.toolStripMenuItem4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem4.Text = "4";
            this.toolStripMenuItem4.CheckStateChanged += new System.EventHandler(this.updateFilterTable);
            // 
            // filterBallChecked
            // 
            this.filterBallChecked.Checked = true;
            this.filterBallChecked.CheckOnClick = true;
            this.filterBallChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.filterBallChecked.Name = "filterBallChecked";
            this.filterBallChecked.Size = new System.Drawing.Size(80, 22);
            this.filterBallChecked.Text = "5";
            this.filterBallChecked.CheckStateChanged += new System.EventHandler(this.updateFilterTable);
            // 
            // sorts
            // 
            this.sorts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sorts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поВозростаниюToolStripMenuItem1,
            this.поУбываниюToolStripMenuItem1,
            this.поРазницеБалловToolStripMenuItem});
            this.sorts.Image = ((System.Drawing.Image)(resources.GetObject("sorts.Image")));
            this.sorts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sorts.Name = "sorts";
            this.sorts.Size = new System.Drawing.Size(86, 22);
            this.sorts.Text = "Сортировка";
            // 
            // поВозростаниюToolStripMenuItem1
            // 
            this.поВозростаниюToolStripMenuItem1.CheckOnClick = true;
            this.поВозростаниюToolStripMenuItem1.Name = "поВозростаниюToolStripMenuItem1";
            this.поВозростаниюToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.поВозростаниюToolStripMenuItem1.Text = "По возрастанию";
            this.поВозростаниюToolStripMenuItem1.Click += new System.EventHandler(this.поВозростаниюToolStripMenuItem1_Click);
            // 
            // поУбываниюToolStripMenuItem1
            // 
            this.поУбываниюToolStripMenuItem1.CheckOnClick = true;
            this.поУбываниюToolStripMenuItem1.Name = "поУбываниюToolStripMenuItem1";
            this.поУбываниюToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.поУбываниюToolStripMenuItem1.Text = "По убыванию";
            this.поУбываниюToolStripMenuItem1.Click += new System.EventHandler(this.поУбываниюToolStripMenuItem1_Click);
            // 
            // поРазницеБалловToolStripMenuItem
            // 
            this.поРазницеБалловToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.positive,
            this.neutral,
            this.negative});
            this.поРазницеБалловToolStripMenuItem.Name = "поРазницеБалловToolStripMenuItem";
            this.поРазницеБалловToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.поРазницеБалловToolStripMenuItem.Text = "По разнице баллов";
            // 
            // positive
            // 
            this.positive.Checked = true;
            this.positive.CheckOnClick = true;
            this.positive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.positive.Name = "positive";
            this.positive.Size = new System.Drawing.Size(163, 22);
            this.positive.Text = "Положительная";
            this.positive.Click += new System.EventHandler(this.updateFilterTable);
            // 
            // neutral
            // 
            this.neutral.Checked = true;
            this.neutral.CheckOnClick = true;
            this.neutral.CheckState = System.Windows.Forms.CheckState.Checked;
            this.neutral.Name = "neutral";
            this.neutral.Size = new System.Drawing.Size(163, 22);
            this.neutral.Text = "Нейтральная";
            this.neutral.Click += new System.EventHandler(this.updateFilterTable);
            // 
            // negative
            // 
            this.negative.Checked = true;
            this.negative.CheckOnClick = true;
            this.negative.CheckState = System.Windows.Forms.CheckState.Checked;
            this.negative.Name = "negative";
            this.negative.Size = new System.Drawing.Size(163, 22);
            this.negative.Text = "Отрицательная";
            this.negative.Click += new System.EventHandler(this.updateFilterTable);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton1.Text = "Сброс";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 449);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(737, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mainProgressBar
            // 
            this.mainProgressBar.Name = "mainProgressBar";
            this.mainProgressBar.Size = new System.Drawing.Size(200, 16);
            // 
            // selectBalls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 471);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(753, 428);
            this.Name = "selectBalls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор оценок";
            this.Shown += new System.EventHandler(this.selectBalls_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выбратьToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton ballRange;
        private System.Windows.Forms.ToolStripMenuItem отToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem доToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripDropDownButton filterMarks;
        private System.Windows.Forms.ToolStripDropDownButton sorts;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem filterBallChecked;
        private System.Windows.Forms.ToolStripMenuItem поВозростаниюToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поУбываниюToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поРазницеБалловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem positive;
        private System.Windows.Forms.ToolStripMenuItem neutral;
        private System.Windows.Forms.ToolStripMenuItem negative;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar mainProgressBar;
    }
}