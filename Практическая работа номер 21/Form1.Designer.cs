namespace Практическая_работа_номер_21
{
    partial class Form1
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
            this.lbChapter1 = new System.Windows.Forms.Label();
            this.cbSorting1 = new System.Windows.Forms.ComboBox();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.btnSort1 = new System.Windows.Forms.Button();
            this.btnClear1 = new System.Windows.Forms.Button();
            this.gbSearchGroup = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbChapter2 = new System.Windows.Forms.CheckBox();
            this.cbChapter1 = new System.Windows.Forms.CheckBox();
            this.lb3 = new System.Windows.Forms.ListBox();
            this.tbInputWord = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lbChapter2 = new System.Windows.Forms.Label();
            this.cbSorting2 = new System.Windows.Forms.ComboBox();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.btnSort2 = new System.Windows.Forms.Button();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.btnMoveRightOne = new System.Windows.Forms.Button();
            this.btnMoveLeftOne = new System.Windows.Forms.Button();
            this.btnMoveRightAll = new System.Windows.Forms.Button();
            this.btnMoveLeftAll = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.rtbChoiseWord = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.rbContainEmail = new System.Windows.Forms.RadioButton();
            this.rbContainNum = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gbSearchGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbChapter1
            // 
            this.lbChapter1.AutoSize = true;
            this.lbChapter1.Location = new System.Drawing.Point(16, 10);
            this.lbChapter1.Name = "lbChapter1";
            this.lbChapter1.Size = new System.Drawing.Size(53, 13);
            this.lbChapter1.TabIndex = 0;
            this.lbChapter1.Text = "Раздел 1";
            // 
            // cbSorting1
            // 
            this.cbSorting1.FormattingEnabled = true;
            this.cbSorting1.Items.AddRange(new object[] {
            "Алфавиту (по возрастанию) ",
            "Алфавиту (по убыванию) ",
            "Длине слова (по возрастанию) ",
            "Длине слова (по убыванию) "});
            this.cbSorting1.Location = new System.Drawing.Point(19, 26);
            this.cbSorting1.Name = "cbSorting1";
            this.cbSorting1.Size = new System.Drawing.Size(121, 21);
            this.cbSorting1.TabIndex = 1;
            this.cbSorting1.Text = "Сортировка по ...";
            this.cbSorting1.SelectedIndexChanged += new System.EventHandler(this.cbSorting1_SelectedIndexChanged);
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.Location = new System.Drawing.Point(20, 57);
            this.lb1.Name = "lb1";
            this.lb1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb1.Size = new System.Drawing.Size(120, 173);
            this.lb1.TabIndex = 2;
            this.lb1.SelectedIndexChanged += new System.EventHandler(this.lb1_SelectedIndexChanged);
            // 
            // btnSort1
            // 
            this.btnSort1.Location = new System.Drawing.Point(32, 236);
            this.btnSort1.Name = "btnSort1";
            this.btnSort1.Size = new System.Drawing.Size(93, 23);
            this.btnSort1.TabIndex = 3;
            this.btnSort1.Text = "Сортировать";
            this.btnSort1.UseVisualStyleBackColor = true;
            this.btnSort1.Click += new System.EventHandler(this.btnSort1_Click);
            // 
            // btnClear1
            // 
            this.btnClear1.Location = new System.Drawing.Point(32, 264);
            this.btnClear1.Name = "btnClear1";
            this.btnClear1.Size = new System.Drawing.Size(93, 23);
            this.btnClear1.TabIndex = 4;
            this.btnClear1.Text = "Очистить";
            this.btnClear1.UseVisualStyleBackColor = true;
            this.btnClear1.Click += new System.EventHandler(this.btnClear1_Click);
            // 
            // gbSearchGroup
            // 
            this.gbSearchGroup.Controls.Add(this.btnSearch);
            this.gbSearchGroup.Controls.Add(this.cbChapter2);
            this.gbSearchGroup.Controls.Add(this.cbChapter1);
            this.gbSearchGroup.Controls.Add(this.lb3);
            this.gbSearchGroup.Controls.Add(this.tbInputWord);
            this.gbSearchGroup.Controls.Add(this.lblSearch);
            this.gbSearchGroup.Location = new System.Drawing.Point(17, 293);
            this.gbSearchGroup.Name = "gbSearchGroup";
            this.gbSearchGroup.Size = new System.Drawing.Size(267, 189);
            this.gbSearchGroup.TabIndex = 5;
            this.gbSearchGroup.TabStop = false;
            this.gbSearchGroup.Text = "Поиск";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(181, 119);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 60);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbChapter2
            // 
            this.cbChapter2.AutoSize = true;
            this.cbChapter2.Location = new System.Drawing.Point(176, 95);
            this.cbChapter2.Name = "cbChapter2";
            this.cbChapter2.Size = new System.Drawing.Size(72, 17);
            this.cbChapter2.TabIndex = 4;
            this.cbChapter2.Text = "Раздел 2";
            this.cbChapter2.UseVisualStyleBackColor = true;
            // 
            // cbChapter1
            // 
            this.cbChapter1.AutoSize = true;
            this.cbChapter1.Checked = true;
            this.cbChapter1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbChapter1.Location = new System.Drawing.Point(176, 71);
            this.cbChapter1.Name = "cbChapter1";
            this.cbChapter1.Size = new System.Drawing.Size(72, 17);
            this.cbChapter1.TabIndex = 3;
            this.cbChapter1.Text = "Раздел 1";
            this.cbChapter1.UseVisualStyleBackColor = true;
            // 
            // lb3
            // 
            this.lb3.FormattingEnabled = true;
            this.lb3.Location = new System.Drawing.Point(11, 71);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(158, 108);
            this.lb3.TabIndex = 2;
            // 
            // tbInputWord
            // 
            this.tbInputWord.Location = new System.Drawing.Point(11, 44);
            this.tbInputWord.Name = "tbInputWord";
            this.tbInputWord.Size = new System.Drawing.Size(158, 20);
            this.tbInputWord.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(8, 27);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(123, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Введите искоме слово";
            // 
            // lbChapter2
            // 
            this.lbChapter2.AutoSize = true;
            this.lbChapter2.Location = new System.Drawing.Point(275, 10);
            this.lbChapter2.Name = "lbChapter2";
            this.lbChapter2.Size = new System.Drawing.Size(53, 13);
            this.lbChapter2.TabIndex = 6;
            this.lbChapter2.Text = "Раздел 2";
            // 
            // cbSorting2
            // 
            this.cbSorting2.FormattingEnabled = true;
            this.cbSorting2.Items.AddRange(new object[] {
            "Алфавиту (по возрастанию) ",
            "Алфавиту (по убыванию) ",
            "Длине слова (по возрастанию) ",
            "Длине слова (по убыванию) "});
            this.cbSorting2.Location = new System.Drawing.Point(278, 26);
            this.cbSorting2.Name = "cbSorting2";
            this.cbSorting2.Size = new System.Drawing.Size(121, 21);
            this.cbSorting2.TabIndex = 7;
            this.cbSorting2.Text = "Сортировка по ...";
            this.cbSorting2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lb2
            // 
            this.lb2.FormattingEnabled = true;
            this.lb2.Location = new System.Drawing.Point(278, 57);
            this.lb2.Name = "lb2";
            this.lb2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb2.Size = new System.Drawing.Size(120, 173);
            this.lb2.TabIndex = 8;
            this.lb2.SelectedIndexChanged += new System.EventHandler(this.lb2_SelectedIndexChanged);
            // 
            // btnSort2
            // 
            this.btnSort2.Location = new System.Drawing.Point(290, 236);
            this.btnSort2.Name = "btnSort2";
            this.btnSort2.Size = new System.Drawing.Size(93, 23);
            this.btnSort2.TabIndex = 9;
            this.btnSort2.Text = "Сортировать";
            this.btnSort2.UseVisualStyleBackColor = true;
            // 
            // btnClear2
            // 
            this.btnClear2.Location = new System.Drawing.Point(290, 264);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(93, 23);
            this.btnClear2.TabIndex = 10;
            this.btnClear2.Text = "Очистить";
            this.btnClear2.UseVisualStyleBackColor = true;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // btnMoveRightOne
            // 
            this.btnMoveRightOne.Location = new System.Drawing.Point(162, 57);
            this.btnMoveRightOne.Name = "btnMoveRightOne";
            this.btnMoveRightOne.Size = new System.Drawing.Size(93, 27);
            this.btnMoveRightOne.TabIndex = 11;
            this.btnMoveRightOne.Text = ">";
            this.btnMoveRightOne.UseVisualStyleBackColor = true;
            this.btnMoveRightOne.Click += new System.EventHandler(this.btnMoveRightOne_Click);
            // 
            // btnMoveLeftOne
            // 
            this.btnMoveLeftOne.Location = new System.Drawing.Point(162, 90);
            this.btnMoveLeftOne.Name = "btnMoveLeftOne";
            this.btnMoveLeftOne.Size = new System.Drawing.Size(93, 27);
            this.btnMoveLeftOne.TabIndex = 12;
            this.btnMoveLeftOne.Text = "<";
            this.btnMoveLeftOne.UseVisualStyleBackColor = true;
            this.btnMoveLeftOne.Click += new System.EventHandler(this.btnMoveLeftOne_Click);
            // 
            // btnMoveRightAll
            // 
            this.btnMoveRightAll.Location = new System.Drawing.Point(162, 123);
            this.btnMoveRightAll.Name = "btnMoveRightAll";
            this.btnMoveRightAll.Size = new System.Drawing.Size(93, 29);
            this.btnMoveRightAll.TabIndex = 13;
            this.btnMoveRightAll.Text = ">>";
            this.btnMoveRightAll.UseVisualStyleBackColor = true;
            this.btnMoveRightAll.Click += new System.EventHandler(this.btnMoveRightAll_Click);
            // 
            // btnMoveLeftAll
            // 
            this.btnMoveLeftAll.Location = new System.Drawing.Point(162, 158);
            this.btnMoveLeftAll.Name = "btnMoveLeftAll";
            this.btnMoveLeftAll.Size = new System.Drawing.Size(93, 27);
            this.btnMoveLeftAll.TabIndex = 14;
            this.btnMoveLeftAll.Text = "<<";
            this.btnMoveLeftAll.UseVisualStyleBackColor = true;
            this.btnMoveLeftAll.Click += new System.EventHandler(this.btnMoveLeftAll_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(162, 235);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(162, 264);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(290, 407);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 66);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(290, 335);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(105, 66);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rtbChoiseWord
            // 
            this.rtbChoiseWord.Location = new System.Drawing.Point(436, 31);
            this.rtbChoiseWord.Name = "rtbChoiseWord";
            this.rtbChoiseWord.Size = new System.Drawing.Size(274, 383);
            this.rtbChoiseWord.TabIndex = 1;
            this.rtbChoiseWord.Text = "";
            this.rtbChoiseWord.TextChanged += new System.EventHandler(this.rtbChoiseWord_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.rbContainEmail);
            this.groupBox1.Controls.Add(this.rbContainNum);
            this.groupBox1.Controls.Add(this.rbAll);
            this.groupBox1.Location = new System.Drawing.Point(430, 420);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 101);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор слов";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(192, 30);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 48);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Начать";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rbContainEmail
            // 
            this.rbContainEmail.AutoSize = true;
            this.rbContainEmail.Location = new System.Drawing.Point(7, 66);
            this.rbContainEmail.Name = "rbContainEmail";
            this.rbContainEmail.Size = new System.Drawing.Size(131, 17);
            this.rbContainEmail.TabIndex = 2;
            this.rbContainEmail.TabStop = true;
            this.rbContainEmail.Text = "Содержащие \"e-mail\"";
            this.rbContainEmail.UseVisualStyleBackColor = true;
            // 
            // rbContainNum
            // 
            this.rbContainNum.AutoSize = true;
            this.rbContainNum.Location = new System.Drawing.Point(7, 44);
            this.rbContainNum.Name = "rbContainNum";
            this.rbContainNum.Size = new System.Drawing.Size(128, 17);
            this.rbContainNum.TabIndex = 1;
            this.rbContainNum.TabStop = true;
            this.rbContainNum.Text = "Содержащие цифры";
            this.rbContainNum.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(7, 20);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(44, 17);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Все";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lbChapter1);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnMoveLeftAll);
            this.panel1.Controls.Add(this.btnMoveRightAll);
            this.panel1.Controls.Add(this.btnMoveLeftOne);
            this.panel1.Controls.Add(this.gbSearchGroup);
            this.panel1.Controls.Add(this.btnClear2);
            this.panel1.Controls.Add(this.cbSorting1);
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Controls.Add(this.cbSorting2);
            this.panel1.Controls.Add(this.btnSort2);
            this.panel1.Controls.Add(this.lb2);
            this.panel1.Controls.Add(this.btnMoveRightOne);
            this.panel1.Controls.Add(this.btnSort1);
            this.panel1.Controls.Add(this.btnClear1);
            this.panel1.Controls.Add(this.lbChapter2);
            this.panel1.Location = new System.Drawing.Point(19, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 490);
            this.panel1.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctrlOToolStripMenuItem,
            this.ctrlSToolStripMenuItem,
            this.altXToolStripMenuItem});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + O";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // ctrlOToolStripMenuItem
            // 
            this.ctrlOToolStripMenuItem.Name = "ctrlOToolStripMenuItem";
            this.ctrlOToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.ctrlOToolStripMenuItem.Text = "Ctrl + O";
            // 
            // ctrlSToolStripMenuItem
            // 
            this.ctrlSToolStripMenuItem.Name = "ctrlSToolStripMenuItem";
            this.ctrlSToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.ctrlSToolStripMenuItem.Text = "Ctrl + S";
            // 
            // altXToolStripMenuItem
            // 
            this.altXToolStripMenuItem.Name = "altXToolStripMenuItem";
            this.altXToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.altXToolStripMenuItem.Text = "Alt + X";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + S";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeyDisplayString = "Alt + X";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtbChoiseWord);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbSearchGroup.ResumeLayout(false);
            this.gbSearchGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbSearchGroup;
        private System.Windows.Forms.CheckBox cbChapter2;
        private System.Windows.Forms.CheckBox cbChapter1;
        private System.Windows.Forms.ListBox lb3;
        private System.Windows.Forms.TextBox tbInputWord;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnClear1;
        private System.Windows.Forms.Button btnSort1;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.ComboBox cbSorting1;
        private System.Windows.Forms.Label lbChapter1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMoveLeftAll;
        private System.Windows.Forms.Button btnMoveRightAll;
        private System.Windows.Forms.Button btnMoveLeftOne;
        private System.Windows.Forms.Button btnMoveRightOne;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.Button btnSort2;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.ComboBox cbSorting2;
        private System.Windows.Forms.Label lbChapter2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RichTextBox rtbChoiseWord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton rbContainEmail;
        private System.Windows.Forms.RadioButton rbContainNum;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctrlOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

