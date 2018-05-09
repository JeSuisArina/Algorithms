using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Tech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Shingles myShingles = new Shingles();
        private Check myCheck = new Check();
        private string text = "";
        private List<string> texts = new List<string>();

        private void Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Text Files|*.txt";

            if (OPF.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(OPF.FileName, RichTextBoxStreamType.PlainText);                
                text = richTextBox1.Text;             
     
            }
            MultyLoad.Enabled = true;
        }

        private void Shingles_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength == 0)
                MessageBox.Show("Добавьте текст!");
            else
            {
                double max = 0;
                string source = myShingles.Shingle(text).ToString();
                int count = 1;                

                foreach (string t in texts)
                {
                    string source1 = myShingles.Shingle(t).ToString();
                    double res = myCheck.CheckHashes(source, source1);
                   
                    string s = "Текст №" + count + "cхож на: " + res + "%";
                    listBox1.Items.Add(s);
                       
                    if (res > max)
                    {
                        max = res;
                        richTextBox4.Text = t;
                        label2.Text = "Текст максимальной схожести: " + count;
                    }
                    count++;
                }
            }
        }

        private void MultyLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Multiselect = true;
            OPF.Filter = "Text File|*.txt";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                foreach (string txt in OPF.FileNames)
                {
                    richTextBox4.LoadFile(txt, RichTextBoxStreamType.PlainText);
                    string str = richTextBox4.Text;
                    texts.Add(str);
                    richTextBox4.Clear();
                }
            }
            Shingles.Enabled = true;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
