namespace SchoolMetric
{
    partial class addBallsBuffer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addBallsBuffer));
            this.label1 = new System.Windows.Forms.Label();
            this.insertMarks = new System.Windows.Forms.Button();
            this.balls = new System.Windows.Forms.RichTextBox();
            this.copyAndPaste = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скопироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.removeValue = new System.Windows.Forms.Button();
            this.weights = new System.Windows.Forms.ComboBox();
            this.addValue = new System.Windows.Forms.Button();
            this.copyAndPaste.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оценки:";
            // 
            // insertMarks
            // 
            this.insertMarks.Location = new System.Drawing.Point(12, 134);
            this.insertMarks.Name = "insertMarks";
            this.insertMarks.Size = new System.Drawing.Size(420, 66);
            this.insertMarks.TabIndex = 4;
            this.insertMarks.Text = "Вставить в таблицу";
            this.insertMarks.UseVisualStyleBackColor = true;
            this.insertMarks.Click += new System.EventHandler(this.button1_Click);
            // 
            // balls
            // 
            this.balls.ContextMenuStrip = this.copyAndPaste;
            this.balls.Location = new System.Drawing.Point(13, 34);
            this.balls.Multiline = false;
            this.balls.Name = "balls";
            this.balls.Size = new System.Drawing.Size(419, 26);
            this.balls.TabIndex = 5;
            this.balls.Text = "";
            this.balls.WordWrap = false;
            this.balls.TextChanged += new System.EventHandler(this.balls_TextChanged_1);
            // 
            // copyAndPaste
            // 
            this.copyAndPaste.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вставитьToolStripMenuItem,
            this.скопироватьToolStripMenuItem});
            this.copyAndPaste.Name = "copyAndPaste";
            this.copyAndPaste.Size = new System.Drawing.Size(189, 48);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // скопироватьToolStripMenuItem
            // 
            this.скопироватьToolStripMenuItem.Name = "скопироватьToolStripMenuItem";
            this.скопироватьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.скопироватьToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.скопироватьToolStripMenuItem.Text = "Скопировать";
            this.скопироватьToolStripMenuItem.Click += new System.EventHandler(this.скопироватьToolStripMenuItem_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(12, 68);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 24);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Веса:";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // removeValue
            // 
            this.removeValue.Enabled = false;
            this.removeValue.Location = new System.Drawing.Point(216, 98);
            this.removeValue.Name = "removeValue";
            this.removeValue.Size = new System.Drawing.Size(105, 28);
            this.removeValue.TabIndex = 6;
            this.removeValue.Text = "Удалить";
            this.removeValue.UseVisualStyleBackColor = true;
            this.removeValue.Click += new System.EventHandler(this.removeValue_Click);
            // 
            // weights
            // 
            this.weights.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weights.Enabled = false;
            this.weights.FormattingEnabled = true;
            this.weights.Location = new System.Drawing.Point(12, 98);
            this.weights.MaxDropDownItems = 50;
            this.weights.Name = "weights";
            this.weights.Size = new System.Drawing.Size(198, 28);
            this.weights.TabIndex = 7;
            // 
            // addValue
            // 
            this.addValue.Enabled = false;
            this.addValue.Location = new System.Drawing.Point(327, 98);
            this.addValue.Name = "addValue";
            this.addValue.Size = new System.Drawing.Size(105, 28);
            this.addValue.TabIndex = 9;
            this.addValue.Text = "Добавить";
            this.addValue.UseVisualStyleBackColor = true;
            this.addValue.Click += new System.EventHandler(this.button2_Click);
            // 
            // addBallsBuffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 211);
            this.Controls.Add(this.addValue);
            this.Controls.Add(this.weights);
            this.Controls.Add(this.removeValue);
            this.Controls.Add(this.balls);
            this.Controls.Add(this.insertMarks);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(408, 250);
            this.Name = "addBallsBuffer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вставте оценки";
            this.copyAndPaste.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insertMarks;
        public System.Windows.Forms.RichTextBox balls;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button removeValue;
        private System.Windows.Forms.ComboBox weights;
        private System.Windows.Forms.ContextMenuStrip copyAndPaste;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скопироватьToolStripMenuItem;
        private System.Windows.Forms.Button addValue;
    }
}