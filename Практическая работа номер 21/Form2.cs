using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Практическая_работа_номер_21
{
    public partial class Form2 : Form
    {
        ListBox lb1;
        ListBox lb2;

        public Form2(ref ListBox lb1, ref ListBox lb2)
        {
            InitializeComponent();

            this.lb1 = lb1;
            this.lb2 = lb2;

        }

        private void lbEnterText_Click(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Form1 Main = this.Owner as Form1;
            if (tbInputTxt.Text != "")
            {
                if (this.rbChapter1.Checked == true)
                {
                    lb1.Items.Add(this.tbInputTxt.Text);
                }
                else 
                {
                    lb2.Items.Add(this.tbInputTxt.Text);
                }

            }
        }

        private void rbChapter1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
