namespace Практическая_работа_номер_21
{
    partial class Form2
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
            this.rbChapter1 = new System.Windows.Forms.RadioButton();
            this.rbChapter2 = new System.Windows.Forms.RadioButton();
            this.lbEnterText = new System.Windows.Forms.Label();
            this.tbInputTxt = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.rbAddin = new System.Windows.Forms.GroupBox();
            this.rbAddin.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbChapter1
            // 
            this.rbChapter1.AutoSize = true;
            this.rbChapter1.Location = new System.Drawing.Point(6, 19);
            this.rbChapter1.Name = "rbChapter1";
            this.rbChapter1.Size = new System.Drawing.Size(68, 17);
            this.rbChapter1.TabIndex = 1;
            this.rbChapter1.TabStop = true;
            this.rbChapter1.Text = "Раздел1";
            this.rbChapter1.UseVisualStyleBackColor = true;
            this.rbChapter1.CheckedChanged += new System.EventHandler(this.rbChapter1_CheckedChanged);
            // 
            // rbChapter2
            // 
            this.rbChapter2.AutoSize = true;
            this.rbChapter2.Location = new System.Drawing.Point(6, 40);
            this.rbChapter2.Name = "rbChapter2";
            this.rbChapter2.Size = new System.Drawing.Size(71, 17);
            this.rbChapter2.TabIndex = 2;
            this.rbChapter2.TabStop = true;
            this.rbChapter2.Text = "Раздел 2";
            this.rbChapter2.UseVisualStyleBackColor = true;
            // 
            // lbEnterText
            // 
            this.lbEnterText.AutoSize = true;
            this.lbEnterText.Location = new System.Drawing.Point(9, 80);
            this.lbEnterText.Name = "lbEnterText";
            this.lbEnterText.Size = new System.Drawing.Size(80, 13);
            this.lbEnterText.TabIndex = 3;
            this.lbEnterText.Text = "Введите текст";
            this.lbEnterText.Click += new System.EventHandler(this.lbEnterText_Click);
            // 
            // tbInputTxt
            // 
            this.tbInputTxt.Location = new System.Drawing.Point(12, 105);
            this.tbInputTxt.Name = "tbInputTxt";
            this.tbInputTxt.Size = new System.Drawing.Size(212, 20);
            this.tbInputTxt.TabIndex = 4;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(12, 131);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(103, 23);
            this.btAdd.TabIndex = 5;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(121, 131);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(103, 23);
            this.btnUndo.TabIndex = 6;
            this.btnUndo.Text = "Отмена";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // rbAddin
            // 
            this.rbAddin.Controls.Add(this.rbChapter1);
            this.rbAddin.Controls.Add(this.rbChapter2);
            this.rbAddin.Location = new System.Drawing.Point(12, 12);
            this.rbAddin.Name = "rbAddin";
            this.rbAddin.Size = new System.Drawing.Size(200, 65);
            this.rbAddin.TabIndex = 7;
            this.rbAddin.TabStop = false;
            this.rbAddin.Text = "Добавить в";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 168);
            this.Controls.Add(this.rbAddin);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbInputTxt);
            this.Controls.Add(this.lbEnterText);
            this.Name = "Form2";
            this.Text = "Добавление записи";
            this.rbAddin.ResumeLayout(false);
            this.rbAddin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbChapter1;
        private System.Windows.Forms.RadioButton rbChapter2;
        private System.Windows.Forms.Label lbEnterText;
        private System.Windows.Forms.TextBox tbInputTxt;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.GroupBox rbAddin;
    }
}