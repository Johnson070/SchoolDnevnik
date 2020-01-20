namespace SchoolMetric
{
    partial class SettingsAnalytics
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsAnalytics));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.individualWeigthsСomplexity = new System.Windows.Forms.DataGridView();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ballFrom = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ballDo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.countWeights = new System.Windows.Forms.DataGridView();
            this.weightName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Сброс = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.individualWeigthsСomplexity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countWeights)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(11, 759);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(805, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Генерировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.individualWeigthsСomplexity);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(4, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 397);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Индивидуальная сложность работ";
            // 
            // individualWeigthsСomplexity
            // 
            this.individualWeigthsСomplexity.AllowUserToAddRows = false;
            this.individualWeigthsСomplexity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.individualWeigthsСomplexity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.individualWeigthsСomplexity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.weight,
            this.names,
            this.ballFrom,
            this.ballDo});
            this.individualWeigthsСomplexity.Location = new System.Drawing.Point(6, 21);
            this.individualWeigthsСomplexity.Name = "individualWeigthsСomplexity";
            this.individualWeigthsСomplexity.Size = new System.Drawing.Size(800, 370);
            this.individualWeigthsСomplexity.TabIndex = 0;
            // 
            // weight
            // 
            this.weight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.weight.HeaderText = "Вес";
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
            this.weight.Width = 57;
            // 
            // names
            // 
            this.names.HeaderText = "Название";
            this.names.Name = "names";
            this.names.ReadOnly = true;
            this.names.Width = 500;
            // 
            // ballFrom
            // 
            this.ballFrom.HeaderText = "Балл от";
            this.ballFrom.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.ballFrom.Name = "ballFrom";
            // 
            // ballDo
            // 
            this.ballDo.HeaderText = "Балл до";
            this.ballDo.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.ballDo.Name = "ballDo";
            // 
            // countWeights
            // 
            this.countWeights.AllowUserToAddRows = false;
            this.countWeights.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.countWeights.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.countWeights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countWeights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.weightName,
            this.nameMarks,
            this.count});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.countWeights.DefaultCellStyle = dataGridViewCellStyle3;
            this.countWeights.Location = new System.Drawing.Point(12, 28);
            this.countWeights.Name = "countWeights";
            this.countWeights.Size = new System.Drawing.Size(805, 322);
            this.countWeights.TabIndex = 29;
            this.countWeights.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            // 
            // weightName
            // 
            this.weightName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.weightName.HeaderText = "Вес";
            this.weightName.MaxInputLength = 15;
            this.weightName.Name = "weightName";
            this.weightName.ReadOnly = true;
            this.weightName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.weightName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.weightName.Width = 43;
            // 
            // nameMarks
            // 
            this.nameMarks.HeaderText = "Имя работы";
            this.nameMarks.Name = "nameMarks";
            this.nameMarks.ReadOnly = true;
            this.nameMarks.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameMarks.Width = 590;
            // 
            // count
            // 
            this.count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.count.DefaultCellStyle = dataGridViewCellStyle2;
            this.count.HeaderText = "Количество";
            this.count.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.count.Name = "count";
            this.count.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.count.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.count.ToolTipText = "Количество работ данного веса";
            this.count.Width = 125;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Сброс});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(829, 25);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Сброс
            // 
            this.Сброс.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Сброс.Image = ((System.Drawing.Image)(resources.GetObject("Сброс.Image")));
            this.Сброс.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Сброс.Name = "Сброс";
            this.Сброс.Size = new System.Drawing.Size(46, 22);
            this.Сброс.Text = "Сброс";
            this.Сброс.Click += new System.EventHandler(this.button2_Click);
            // 
            // SettingsAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 810);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.countWeights);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsAnalytics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Параметры";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.individualWeigthsСomplexity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countWeights)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView individualWeigthsСomplexity;
        private System.Windows.Forms.DataGridView countWeights;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Сброс;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn names;
        private System.Windows.Forms.DataGridViewComboBoxColumn ballFrom;
        private System.Windows.Forms.DataGridViewComboBoxColumn ballDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameMarks;
        private System.Windows.Forms.DataGridViewComboBoxColumn count;
    }
}