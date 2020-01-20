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
            this.minValue = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.maxValue = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.filterMarks = new System.Windows.Forms.ToolStripDropDownButton();
            this.twoMark = new System.Windows.Forms.ToolStripMenuItem();
            this.threeMark = new System.Windows.Forms.ToolStripMenuItem();
            this.fourMark = new System.Windows.Forms.ToolStripMenuItem();
            this.fiveMark = new System.Windows.Forms.ToolStripMenuItem();
            this.sorts = new System.Windows.Forms.ToolStripDropDownButton();
            this.upValues = new System.Windows.Forms.ToolStripMenuItem();
            this.downValues = new System.Windows.Forms.ToolStripMenuItem();
            this.absValues = new System.Windows.Forms.ToolStripMenuItem();
            this.positive = new System.Windows.Forms.ToolStripMenuItem();
            this.neutral = new System.Windows.Forms.ToolStripMenuItem();
            this.negative = new System.Windows.Forms.ToolStripMenuItem();
            this.resetFilter = new System.Windows.Forms.ToolStripButton();
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
            this.resetFilter});
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
            this.minValue,
            this.maxValue});
            this.ballRange.Image = ((System.Drawing.Image)(resources.GetObject("ballRange.Image")));
            this.ballRange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ballRange.Name = "ballRange";
            this.ballRange.Size = new System.Drawing.Size(162, 22);
            this.ballRange.Text = "Диапазон среднего балла";
            // 
            // minValue
            // 
            this.minValue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
            this.minValue.MergeIndex = 8;
            this.minValue.Name = "minValue";
            this.minValue.Size = new System.Drawing.Size(180, 22);
            this.minValue.Text = "От";
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
            // maxValue
            // 
            this.maxValue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.maxValue.Name = "maxValue";
            this.maxValue.Size = new System.Drawing.Size(180, 22);
            this.maxValue.Text = "До";
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
            this.twoMark,
            this.threeMark,
            this.fourMark,
            this.fiveMark});
            this.filterMarks.Image = ((System.Drawing.Image)(resources.GetObject("filterMarks.Image")));
            this.filterMarks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filterMarks.Name = "filterMarks";
            this.filterMarks.Size = new System.Drawing.Size(104, 22);
            this.filterMarks.Text = "Фильтр оценок";
            // 
            // twoMark
            // 
            this.twoMark.Checked = true;
            this.twoMark.CheckOnClick = true;
            this.twoMark.CheckState = System.Windows.Forms.CheckState.Checked;
            this.twoMark.Name = "twoMark";
            this.twoMark.Size = new System.Drawing.Size(180, 22);
            this.twoMark.Text = "2";
            this.twoMark.CheckStateChanged += new System.EventHandler(this.updateFilterTable);
            // 
            // threeMark
            // 
            this.threeMark.Checked = true;
            this.threeMark.CheckOnClick = true;
            this.threeMark.CheckState = System.Windows.Forms.CheckState.Checked;
            this.threeMark.Name = "threeMark";
            this.threeMark.Size = new System.Drawing.Size(180, 22);
            this.threeMark.Text = "3";
            this.threeMark.CheckStateChanged += new System.EventHandler(this.updateFilterTable);
            // 
            // fourMark
            // 
            this.fourMark.Checked = true;
            this.fourMark.CheckOnClick = true;
            this.fourMark.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fourMark.Name = "fourMark";
            this.fourMark.Size = new System.Drawing.Size(180, 22);
            this.fourMark.Text = "4";
            this.fourMark.CheckStateChanged += new System.EventHandler(this.updateFilterTable);
            // 
            // fiveMark
            // 
            this.fiveMark.Checked = true;
            this.fiveMark.CheckOnClick = true;
            this.fiveMark.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fiveMark.Name = "fiveMark";
            this.fiveMark.Size = new System.Drawing.Size(180, 22);
            this.fiveMark.Text = "5";
            this.fiveMark.CheckStateChanged += new System.EventHandler(this.updateFilterTable);
            // 
            // sorts
            // 
            this.sorts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sorts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upValues,
            this.downValues,
            this.absValues});
            this.sorts.Image = ((System.Drawing.Image)(resources.GetObject("sorts.Image")));
            this.sorts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sorts.Name = "sorts";
            this.sorts.Size = new System.Drawing.Size(86, 22);
            this.sorts.Text = "Сортировка";
            // 
            // upValues
            // 
            this.upValues.CheckOnClick = true;
            this.upValues.Name = "upValues";
            this.upValues.Size = new System.Drawing.Size(181, 22);
            this.upValues.Text = "По возрастанию";
            this.upValues.Click += new System.EventHandler(this.поВозростаниюToolStripMenuItem1_Click);
            // 
            // downValues
            // 
            this.downValues.CheckOnClick = true;
            this.downValues.Name = "downValues";
            this.downValues.Size = new System.Drawing.Size(181, 22);
            this.downValues.Text = "По убыванию";
            this.downValues.Click += new System.EventHandler(this.поУбываниюToolStripMenuItem1_Click);
            // 
            // absValues
            // 
            this.absValues.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.positive,
            this.neutral,
            this.negative});
            this.absValues.Name = "absValues";
            this.absValues.Size = new System.Drawing.Size(181, 22);
            this.absValues.Text = "По разнице баллов";
            // 
            // positive
            // 
            this.positive.Checked = true;
            this.positive.CheckOnClick = true;
            this.positive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.positive.Name = "positive";
            this.positive.Size = new System.Drawing.Size(180, 22);
            this.positive.Text = "Положительная";
            this.positive.Click += new System.EventHandler(this.updateFilterTable);
            // 
            // neutral
            // 
            this.neutral.Checked = true;
            this.neutral.CheckOnClick = true;
            this.neutral.CheckState = System.Windows.Forms.CheckState.Checked;
            this.neutral.Name = "neutral";
            this.neutral.Size = new System.Drawing.Size(180, 22);
            this.neutral.Text = "Нейтральная";
            this.neutral.Click += new System.EventHandler(this.updateFilterTable);
            // 
            // negative
            // 
            this.negative.Checked = true;
            this.negative.CheckOnClick = true;
            this.negative.CheckState = System.Windows.Forms.CheckState.Checked;
            this.negative.Name = "negative";
            this.negative.Size = new System.Drawing.Size(180, 22);
            this.negative.Text = "Отрицательная";
            this.negative.Click += new System.EventHandler(this.updateFilterTable);
            // 
            // resetFilter
            // 
            this.resetFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.resetFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.resetFilter.Image = ((System.Drawing.Image)(resources.GetObject("resetFilter.Image")));
            this.resetFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resetFilter.Name = "resetFilter";
            this.resetFilter.Size = new System.Drawing.Size(46, 22);
            this.resetFilter.Text = "Сброс";
            this.resetFilter.Click += new System.EventHandler(this.toolStripButton1_Click);
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
        private System.Windows.Forms.ToolStripMenuItem minValue;
        private System.Windows.Forms.ToolStripMenuItem maxValue;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripDropDownButton filterMarks;
        private System.Windows.Forms.ToolStripDropDownButton sorts;
        private System.Windows.Forms.ToolStripButton resetFilter;
        private System.Windows.Forms.ToolStripMenuItem twoMark;
        private System.Windows.Forms.ToolStripMenuItem threeMark;
        private System.Windows.Forms.ToolStripMenuItem fourMark;
        private System.Windows.Forms.ToolStripMenuItem fiveMark;
        private System.Windows.Forms.ToolStripMenuItem upValues;
        private System.Windows.Forms.ToolStripMenuItem downValues;
        private System.Windows.Forms.ToolStripMenuItem absValues;
        private System.Windows.Forms.ToolStripMenuItem positive;
        private System.Windows.Forms.ToolStripMenuItem neutral;
        private System.Windows.Forms.ToolStripMenuItem negative;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar mainProgressBar;
    }
}