using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2TechCloud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<string> text = new List<string>();
        private Canonize myCanonize = new Canonize();
        public int[] mas = new int[1000];
        private List<string> words_text;
        private List<string> words;

        private void Load_Click(object sender, EventArgs e)
        {
            string text1 = "";
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Text Files|*.txt";

            if (OPF.ShowDialog() == DialogResult.OK && OPF.FileName != "")
            {
                StreamReader stream1 = new StreamReader(OPF.FileName, Encoding.GetEncoding(1251));
                text1 = stream1.ReadToEnd();

                words_text = new List<string>();
                words_text = myCanonize.canonize(text1);
            }
        }

        private void Dictionar_Click(object sender, EventArgs e)
        {
            string textDict = "";
            StreamReader sr = new StreamReader(@"C:\word_rus.txt", Encoding.GetEncoding(1251));
            textDict = sr.ReadToEnd();

            words = new List<string>();
            words = myCanonize.canonize(textDict);
        }

        private void CloudBut_Click(object sender, EventArgs e)
        {
            int num = 0;
            foreach (var word in words_text.Where(w => w.Length > 4 && words.Any(word => Canonize.LevenshteinDistance(word, w) < 2)))
            {
                var count = words_text.Count(w => w == word);

                if (count > 0)
                {
                    text.Add(word);
                    mas[num] = count;
                    num++;
                }
            }
            WriteCloud();
        }

        private void WriteCloud()
        {
            for (int i = 0; i < text.Count; i++)
            { 
                if (mas[i] > 1)
                {                   
                        textBox1.Text += text[i] + " " + mas[i].ToString() + Environment.NewLine;
                }                      
                                    
            }
               
        }

       
    }
}

