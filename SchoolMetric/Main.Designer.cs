namespace SchoolMetric
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.marksTable = new System.Windows.Forms.DataGridView();
            this.rightClickActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.generateMarksMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.insertMarksBufferMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.insertMarksDnevnikMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.upRowMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.downRowMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addColumnMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addRowMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteColumnMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRowMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.eraseCellMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.eraseTableMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.correctTableMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolActions = new System.Windows.Forms.ToolStrip();
            this.file = new System.Windows.Forms.ToolStripDropDownButton();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.actionTable = new System.Windows.Forms.ToolStripDropDownButton();
            this.generateMarksTool = new System.Windows.Forms.ToolStripMenuItem();
            this.insertMarksBufferTool = new System.Windows.Forms.ToolStripMenuItem();
            this.dnevnikCopyMarksTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.upRowTool = new System.Windows.Forms.ToolStripMenuItem();
            this.downRowTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.addColumnTool = new System.Windows.Forms.ToolStripMenuItem();
            this.addRowTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteColumnTool = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRowTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.eraseCellTool = new System.Windows.Forms.ToolStripMenuItem();
            this.eraseTableTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.correctTableTool = new System.Windows.Forms.ToolStripMenuItem();
            this.basic = new System.Windows.Forms.ToolStripDropDownButton();
            this.settings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.updateProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.writeProblem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeProblemMail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutProgramBox = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.marksTable)).BeginInit();
            this.rightClickActions.SuspendLayout();
            this.toolActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // marksTable
            // 
            this.marksTable.AllowDrop = true;
            this.marksTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marksTable.ContextMenuStrip = this.rightClickActions;
            this.marksTable.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.marksTable.Location = new System.Drawing.Point(12, 28);
            this.marksTable.MultiSelect = false;
            this.marksTable.Name = "marksTable";
            this.marksTable.Size = new System.Drawing.Size(920, 681);
            this.marksTable.TabIndex = 0;
            this.marksTable.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.marksTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.marksTable.Click += new System.EventHandler(this.dataGridView1_Click);
            this.marksTable.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragDrop);
            this.marksTable.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragEnter);
            // 
            // rightClickActions
            // 
            this.rightClickActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateMarksMenu,
            this.insertMarksBufferMenu,
            this.insertMarksDnevnikMenu,
            this.toolStripSeparator1,
            this.upRowMenu,
            this.downRowMenu,
            this.toolStripSeparator2,
            this.addColumnMenu,
            this.addRowMenu,
            this.toolStripSeparator3,
            this.deleteColumnMenu,
            this.deleteRowMenu,
            this.toolStripSeparator8,
            this.eraseCellMenu,
            this.eraseTableMenu,
            this.toolStripSeparator13,
            this.correctTableMenu});
            this.rightClickActions.Name = "contextMenuStrip1";
            this.rightClickActions.Size = new System.Drawing.Size(225, 298);
            // 
            // generateMarksMenu
            // 
            this.generateMarksMenu.Name = "generateMarksMenu";
            this.generateMarksMenu.Size = new System.Drawing.Size(224, 22);
            this.generateMarksMenu.Text = "Генерировать";
            this.generateMarksMenu.Click += new System.EventHandler(this.генерироватьToolStripMenuItem_Click);
            // 
            // insertMarksBufferMenu
            // 
            this.insertMarksBufferMenu.Name = "insertMarksBufferMenu";
            this.insertMarksBufferMenu.Size = new System.Drawing.Size(224, 22);
            this.insertMarksBufferMenu.Text = "Вставить оценки из буфера";
            this.insertMarksBufferMenu.Click += new System.EventHandler(this.вставитьОценкиИзБуфераToolStripMenuItem_Click);
            // 
            // insertMarksDnevnikMenu
            // 
            this.insertMarksDnevnikMenu.Name = "insertMarksDnevnikMenu";
            this.insertMarksDnevnikMenu.Size = new System.Drawing.Size(224, 22);
            this.insertMarksDnevnikMenu.Text = "Вставить оценки из э.ж.";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // upRowMenu
            // 
            this.upRowMenu.Name = "upRowMenu";
            this.upRowMenu.Size = new System.Drawing.Size(224, 22);
            this.upRowMenu.Text = "Поднять строку";
            this.upRowMenu.Click += new System.EventHandler(this.поднятьСтрокуToolStripMenuItem_Click);
            // 
            // downRowMenu
            // 
            this.downRowMenu.Name = "downRowMenu";
            this.downRowMenu.Size = new System.Drawing.Size(224, 22);
            this.downRowMenu.Text = "Опустить строку";
            this.downRowMenu.Click += new System.EventHandler(this.опуститьСтрокуToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // addColumnMenu
            // 
            this.addColumnMenu.Name = "addColumnMenu";
            this.addColumnMenu.Size = new System.Drawing.Size(224, 22);
            this.addColumnMenu.Text = "Добавить столбец";
            this.addColumnMenu.Click += new System.EventHandler(this.добавитьСтолбецToolStripMenuItem_Click);
            // 
            // addRowMenu
            // 
            this.addRowMenu.Name = "addRowMenu";
            this.addRowMenu.Size = new System.Drawing.Size(224, 22);
            this.addRowMenu.Text = "Добавить строку";
            this.addRowMenu.Click += new System.EventHandler(this.добавитьСтрокуToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(221, 6);
            // 
            // deleteColumnMenu
            // 
            this.deleteColumnMenu.Name = "deleteColumnMenu";
            this.deleteColumnMenu.Size = new System.Drawing.Size(224, 22);
            this.deleteColumnMenu.Text = "Удалить столбец";
            this.deleteColumnMenu.Click += new System.EventHandler(this.удалитьСтолбецToolStripMenuItem_Click);
            // 
            // deleteRowMenu
            // 
            this.deleteRowMenu.Name = "deleteRowMenu";
            this.deleteRowMenu.Size = new System.Drawing.Size(224, 22);
            this.deleteRowMenu.Text = "Удалить строку";
            this.deleteRowMenu.Click += new System.EventHandler(this.удалитьСтрокуToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(221, 6);
            // 
            // eraseCellMenu
            // 
            this.eraseCellMenu.Name = "eraseCellMenu";
            this.eraseCellMenu.Size = new System.Drawing.Size(224, 22);
            this.eraseCellMenu.Text = "Очистить ячейку";
            this.eraseCellMenu.Click += new System.EventHandler(this.clearCell);
            // 
            // eraseTableMenu
            // 
            this.eraseTableMenu.Name = "eraseTableMenu";
            this.eraseTableMenu.Size = new System.Drawing.Size(224, 22);
            this.eraseTableMenu.Text = "Очистить таблицу";
            this.eraseTableMenu.Click += new System.EventHandler(this.очиститьТаблицуToolStripMenuItem_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(221, 6);
            // 
            // correctTableMenu
            // 
            this.correctTableMenu.Name = "correctTableMenu";
            this.correctTableMenu.Size = new System.Drawing.Size(224, 22);
            this.correctTableMenu.Text = "Редактировать таблицу";
            this.correctTableMenu.Click += new System.EventHandler(this.редактироватьТаблицуToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolActions
            // 
            this.toolActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.actionTable,
            this.basic});
            this.toolActions.Location = new System.Drawing.Point(0, 0);
            this.toolActions.Name = "toolActions";
            this.toolActions.Size = new System.Drawing.Size(944, 25);
            this.toolActions.TabIndex = 10;
            this.toolActions.Text = "toolStrip1";
            // 
            // file
            // 
            this.file.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFile,
            this.saveFile});
            this.file.Image = ((System.Drawing.Image)(resources.GetObject("file.Image")));
            this.file.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(49, 22);
            this.file.Text = "Файл";
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            this.openFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFile.Size = new System.Drawing.Size(180, 22);
            this.openFile.Text = "Открыть";
            this.openFile.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // saveFile
            // 
            this.saveFile.Name = "saveFile";
            this.saveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFile.Size = new System.Drawing.Size(180, 22);
            this.saveFile.Text = "Сохранить";
            this.saveFile.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // actionTable
            // 
            this.actionTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.actionTable.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateMarksTool,
            this.insertMarksBufferTool,
            this.dnevnikCopyMarksTool,
            this.toolStripSeparator4,
            this.upRowTool,
            this.downRowTool,
            this.toolStripSeparator12,
            this.addColumnTool,
            this.addRowTool,
            this.toolStripSeparator5,
            this.deleteColumnTool,
            this.deleteRowTool,
            this.toolStripSeparator6,
            this.eraseCellTool,
            this.eraseTableTool,
            this.toolStripSeparator7,
            this.correctTableTool});
            this.actionTable.Image = ((System.Drawing.Image)(resources.GetObject("actionTable.Image")));
            this.actionTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.actionTable.Name = "actionTable";
            this.actionTable.Size = new System.Drawing.Size(71, 22);
            this.actionTable.Text = "Действия";
            // 
            // generateMarksTool
            // 
            this.generateMarksTool.Name = "generateMarksTool";
            this.generateMarksTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.generateMarksTool.Size = new System.Drawing.Size(257, 22);
            this.generateMarksTool.Text = "Генерировать";
            this.generateMarksTool.Click += new System.EventHandler(this.генерироватьToolStripMenuItem_Click);
            // 
            // insertMarksBufferTool
            // 
            this.insertMarksBufferTool.Name = "insertMarksBufferTool";
            this.insertMarksBufferTool.Size = new System.Drawing.Size(257, 22);
            this.insertMarksBufferTool.Text = "Вставить оценки из буфера";
            this.insertMarksBufferTool.Click += new System.EventHandler(this.вставитьОценкиИзБуфераToolStripMenuItem_Click);
            // 
            // dnevnikCopyMarksTool
            // 
            this.dnevnikCopyMarksTool.Name = "dnevnikCopyMarksTool";
            this.dnevnikCopyMarksTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.dnevnikCopyMarksTool.Size = new System.Drawing.Size(257, 22);
            this.dnevnikCopyMarksTool.Text = "Вставить оценки из э.ж.";
            this.dnevnikCopyMarksTool.Click += new System.EventHandler(this.dnevnikCopyMarks_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(254, 6);
            // 
            // upRowTool
            // 
            this.upRowTool.Name = "upRowTool";
            this.upRowTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.upRowTool.Size = new System.Drawing.Size(257, 22);
            this.upRowTool.Text = "Поднять строку";
            this.upRowTool.Click += new System.EventHandler(this.поднятьСтрокуToolStripMenuItem_Click);
            // 
            // downRowTool
            // 
            this.downRowTool.Name = "downRowTool";
            this.downRowTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.downRowTool.Size = new System.Drawing.Size(257, 22);
            this.downRowTool.Text = "Опустить строку";
            this.downRowTool.Click += new System.EventHandler(this.опуститьСтрокуToolStripMenuItem_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(254, 6);
            // 
            // addColumnTool
            // 
            this.addColumnTool.Name = "addColumnTool";
            this.addColumnTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addColumnTool.Size = new System.Drawing.Size(257, 22);
            this.addColumnTool.Text = "Добавить столбец";
            this.addColumnTool.Click += new System.EventHandler(this.добавитьСтолбецToolStripMenuItem_Click);
            // 
            // addRowTool
            // 
            this.addRowTool.Name = "addRowTool";
            this.addRowTool.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.addRowTool.Size = new System.Drawing.Size(257, 22);
            this.addRowTool.Text = "Добавить строку";
            this.addRowTool.Click += new System.EventHandler(this.добавитьСтрокуToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(254, 6);
            // 
            // deleteColumnTool
            // 
            this.deleteColumnTool.Name = "deleteColumnTool";
            this.deleteColumnTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.deleteColumnTool.Size = new System.Drawing.Size(257, 22);
            this.deleteColumnTool.Text = "Удалить столбец";
            this.deleteColumnTool.Click += new System.EventHandler(this.удалитьСтолбецToolStripMenuItem_Click);
            // 
            // deleteRowTool
            // 
            this.deleteRowTool.Name = "deleteRowTool";
            this.deleteRowTool.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.deleteRowTool.Size = new System.Drawing.Size(257, 22);
            this.deleteRowTool.Text = "Удалить строку";
            this.deleteRowTool.Click += new System.EventHandler(this.удалитьСтрокуToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(254, 6);
            // 
            // eraseCellTool
            // 
            this.eraseCellTool.Name = "eraseCellTool";
            this.eraseCellTool.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.eraseCellTool.Size = new System.Drawing.Size(257, 22);
            this.eraseCellTool.Text = "Очистить ячейку";
            this.eraseCellTool.Click += new System.EventHandler(this.clearCell);
            // 
            // eraseTableTool
            // 
            this.eraseTableTool.Name = "eraseTableTool";
            this.eraseTableTool.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Delete)));
            this.eraseTableTool.Size = new System.Drawing.Size(257, 22);
            this.eraseTableTool.Text = "Очистить таблицу";
            this.eraseTableTool.Click += new System.EventHandler(this.очиститьТаблицуToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(254, 6);
            // 
            // correctTableTool
            // 
            this.correctTableTool.Name = "correctTableTool";
            this.correctTableTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.correctTableTool.Size = new System.Drawing.Size(257, 22);
            this.correctTableTool.Text = "Редактировать таблицу";
            this.correctTableTool.Click += new System.EventHandler(this.редактироватьТаблицуToolStripMenuItem_Click);
            // 
            // basic
            // 
            this.basic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.basic.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settings,
            this.toolStripSeparator11,
            this.updateProgram,
            this.aboutUpdate,
            this.toolStripSeparator9,
            this.writeProblem,
            this.writeProblemMail,
            this.toolStripSeparator10,
            this.aboutProgramBox});
            this.basic.Image = ((System.Drawing.Image)(resources.GetObject("basic.Image")));
            this.basic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.basic.Name = "basic";
            this.basic.Size = new System.Drawing.Size(77, 22);
            this.basic.Text = "Основные";
            // 
            // settings
            // 
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(255, 22);
            this.settings.Text = "Настройки";
            this.settings.Click += new System.EventHandler(this.настрокиToolStripMenuItem_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(252, 6);
            // 
            // updateProgram
            // 
            this.updateProgram.Name = "updateProgram";
            this.updateProgram.Size = new System.Drawing.Size(255, 22);
            this.updateProgram.Text = "Обновление программы";
            this.updateProgram.Click += new System.EventHandler(this.programUpdate);
            // 
            // aboutUpdate
            // 
            this.aboutUpdate.Name = "aboutUpdate";
            this.aboutUpdate.Size = new System.Drawing.Size(255, 22);
            this.aboutUpdate.Text = "Посмотреть инфо о обновлении";
            this.aboutUpdate.Click += new System.EventHandler(this.посмотретьНоввоведенияВЭтойВерсииToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(252, 6);
            // 
            // writeProblem
            // 
            this.writeProblem.Name = "writeProblem";
            this.writeProblem.Size = new System.Drawing.Size(255, 22);
            this.writeProblem.Text = "Написать разработчику";
            this.writeProblem.Click += new System.EventHandler(this.написатьОПроблемеToolStripMenuItem_Click);
            // 
            // writeProblemMail
            // 
            this.writeProblemMail.Name = "writeProblemMail";
            this.writeProblemMail.Size = new System.Drawing.Size(255, 22);
            this.writeProblemMail.Text = "Сообщить о проблеме";
            this.writeProblemMail.Click += new System.EventHandler(this.сообщитьОПроблемеToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(252, 6);
            // 
            // aboutProgramBox
            // 
            this.aboutProgramBox.Name = "aboutProgramBox";
            this.aboutProgramBox.Size = new System.Drawing.Size(255, 22);
            this.aboutProgramBox.Text = "О программе";
            this.aboutProgramBox.Click += new System.EventHandler(this.aboutProgram);
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 721);
            this.Controls.Add(this.toolActions);
            this.Controls.Add(this.marksTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(320, 275);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Shown += new System.EventHandler(this.Main_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.marksTable)).EndInit();
            this.rightClickActions.ResumeLayout(false);
            this.toolActions.ResumeLayout(false);
            this.toolActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStrip toolActions;
        private System.Windows.Forms.ToolStripDropDownButton file;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripMenuItem saveFile;
        public System.Windows.Forms.DataGridView marksTable;
        private System.Windows.Forms.ToolStripDropDownButton actionTable;
        private System.Windows.Forms.ToolStripMenuItem generateMarksTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem addColumnTool;
        private System.Windows.Forms.ToolStripMenuItem addRowTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem deleteColumnTool;
        private System.Windows.Forms.ToolStripMenuItem deleteRowTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem eraseTableTool;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem correctTableTool;
        private System.Windows.Forms.ToolStripDropDownButton basic;
        private System.Windows.Forms.ToolStripMenuItem settings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem writeProblem;
        private System.Windows.Forms.ToolStripMenuItem eraseCellTool;
        private System.Windows.Forms.ToolStripMenuItem writeProblemMail;
        private System.Windows.Forms.ToolStripMenuItem updateProgram;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem upRowTool;
        private System.Windows.Forms.ToolStripMenuItem downRowTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem aboutUpdate;
        private System.Windows.Forms.ToolStripMenuItem insertMarksBufferTool;
        private System.Windows.Forms.ContextMenuStrip rightClickActions;
        private System.Windows.Forms.ToolStripMenuItem generateMarksMenu;
        private System.Windows.Forms.ToolStripMenuItem insertMarksBufferMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem upRowMenu;
        private System.Windows.Forms.ToolStripMenuItem downRowMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem addColumnMenu;
        private System.Windows.Forms.ToolStripMenuItem addRowMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem deleteColumnMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteRowMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem eraseCellMenu;
        private System.Windows.Forms.ToolStripMenuItem eraseTableMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem correctTableMenu;
        private System.Windows.Forms.ToolStripMenuItem dnevnikCopyMarksTool;
        private System.Windows.Forms.ToolStripMenuItem insertMarksDnevnikMenu;
    }
}

