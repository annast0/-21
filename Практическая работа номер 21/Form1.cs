using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Практическая_работа_номер_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Информация о приложении и разработчике");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbSorting1.SelectedIndex)
            {
                case 0:
                    SortAlphabetUp(ref lb2);
                    break;
                case 1:
                    SortAlphabetDown(ref lb2);
                    break;
                case 2:
                    SortLenghtUp(ref lb2);
                    break;
                case 3:
                    SortLenghtDown(ref lb2);
                    break;

            }
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void lb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDlg = new OpenFileDialog();
            if (OpenDlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader Reader = new StreamReader(OpenDlg.FileName, Encoding.Default);
                rtbChoiseWord.Text = Reader.ReadToEnd();
                Reader.Close();
            }
            OpenDlg.Dispose();
        }

        private void rtbChoiseWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Writer = new StreamWriter(saveDlg.FileName);
                for (int i = 0; i < lb2.Items.Count; i++)
                {
                    Writer.WriteLine((string)lb2.Items[i]);
                }
                Writer.Close();
            }
            saveDlg.Dispose();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            lb1.Items.Clear();
            lb2.Items.Clear();
            lb1.BeginUpdate();
            string[] Strings = rtbChoiseWord.Text.Split(new char[] { '\n', '\t', ' ' },
            StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in Strings)
            {
                string Str = s.Trim();
                if (Str == String.Empty) continue;
                if (rbAll.Checked) lb1.Items.Add(Str);
                if (rbContainNum.Checked)
                    if (SaveDlg.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter Writer = new StreamWriter(SaveDlg.FileName);
                        for (int i = 0; i < lb3.Items.Count; i++)
                        {
                            Writer.WriteLine((string)lb3.Items[i]);
                        }
                        Writer.Close();
                    }
                SaveDlg.Dispose();
            }
            lb1.Items.Clear();
            lb2.Items.Clear();
            lb1.BeginUpdate();
            string[] strings = rtbChoiseWord.Text.Split(new char[] { '\n', '\t', ' ' },
            StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in Strings)
            {
                string Str = s.Trim();
                if (Str == String.Empty) continue;
                if (rbAll.Checked) lb1.Items.Add(Str);
                if (rbContainNum.Checked)
                {
                    if (Regex.IsMatch(Str, @"\d")) lb1.Items.Add(Str);
                }
                if (rbContainEmail.Checked)
                {
                    if (Regex.IsMatch(Str, @"\w+@\w+\.\w+")) lb1.Items.Add(Str);
                }
            }
            lb1.EndUpdate();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            lb2.Items.Clear();
            lb3.Items.Clear();
            rtbChoiseWord.Clear();
            tbInputWord.Clear();
            rbContainNum.Checked = false;
            rbAll.Checked = true;
            rbContainEmail.Checked = false;
            cbChapter1.Checked = true;
            cbChapter2.Checked = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lb3.Items.Clear();
            string Find = tbInputWord.Text;
            if (cbChapter1.Checked)
            {
                foreach (string String in lb1.Items)
                {
                    if (String.Contains(Find)) lb3.Items.Add(String);
                }
            }

            if (cbChapter1.Checked)
            {
                foreach (string String in lb1.Items)
                {
                    if (String.Contains(Find)) lb3.Items.Add(String);
                }
            }
            if (cbChapter2.Checked)
            {
                foreach (string String in lb2.Items)
                {
                    if (String.Contains(Find)) lb3.Items.Add(String);
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 AddRec = new Form2(ref lb1, ref lb2);
            AddRec.Owner = this;
            AddRec.ShowDialog();
        }

        public void lb2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = lb1.Items.Count - 1; i >= 0; i--)
            {
                if (lb1.GetSelected(i)) lb1.Items.RemoveAt(i);
            }
            for (int i = lb2.Items.Count - 1; i >= 0; i--)
            {
                if (lb2.GetSelected(i)) lb2.Items.RemoveAt(i);
            }

        }

        private void btnMoveRightAll_Click(object sender, EventArgs e)
        {
            foreach (object i in lb1.Items)
            {
                lb2.Items.Add(i);
            }
            lb1.Items.Clear();
        }

        private void btnMoveLeftAll_Click(object sender, EventArgs e)
        {
            foreach (object i in lb2.Items)
            {
                lb1.Items.Add(i);
            }
            lb2.Items.Clear();
        }

        private void btnMoveRightOne_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lb1.Items.Count; i++)
            {
                if (lb1.GetSelected(i))
                {
                    lb2.Items.Add(lb1.Items[i]);
                    lb1.Items.Remove(lb1.Items[i]);
                }
            }
        }

        private void btnMoveLeftOne_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lb2.Items.Count; i++)
            {
                if (lb2.GetSelected(i))
                {
                    lb1.Items.Add(lb2.Items[i]);
                    lb2.Items.Remove(lb2.Items[i]);
                }
            }
        }

        private void cbSorting1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        private void SortAlphabetUp(ref ListBox lb)
        {
            List<String> list = new List<String>();
            foreach (var item in lb.Items)
                list.Add(item.ToString());

            list.Sort();
            lb.Items.Clear();
            foreach (var item in list)
                lb.Items.Add(item);
        }
        private void SortAlphabetDown(ref ListBox lb)
        {
            List<String> list = new List<String>();
            foreach (var item in lb.Items)
                list.Add(item.ToString());

            list.Sort();
            list.Reverse();
            lb.Items.Clear();
            foreach (var item in list)
                lb.Items.Add(item);
        }
        private void SortLenghtUp(ref ListBox lb)
        {
            List<String> list = new List<string>();
            foreach (var item in lb.Items)
                list.Add(item.ToString());

            lb.Items.Clear();
            var sortResult = list.OrderBy(x => x.Length);
            foreach (var item in sortResult)
                lb.Items.Add(item);
        }
        private void SortLenghtDown(ref ListBox lb)
        {
            List<String> list = new List<string>();
            foreach (var item in lb.Items)
                list.Add(item.ToString());

            lb.Items.Clear();
            var sortResult = list.OrderByDescending(x => x.Length);
            foreach (var item in sortResult)
                lb.Items.Add(item);
        }

        private void btnSort1_Click(object sender, EventArgs e)
        {
            switch(cbSorting1.SelectedIndex)
            {
                case 0:
                    SortAlphabetUp(ref lb1);
                    break;
                case 1:
                    SortAlphabetDown(ref lb1);
                    break;
                case 2:
                    SortLenghtUp(ref lb1);
                    break;
                case 3:
                    SortLenghtDown(ref lb1);
                    break;

                }
            }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            lb2.Items.Clear();
        }
    }
}

