using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SUBJECT
{
    public partial class Form1 : Form
    {
        string text;
        string [] buffer;
        string[] str;
        int num;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "что вы хотите рашифровать ";
            openFileDialog1.Filter = "Все фаилы | *.*|Текстовые фаилы | *.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                int j = 0;
                string patc = openFileDialog1.FileName;
                text = File.ReadAllText(patc);
                text = text.ToLower();
                File.WriteAllText(patc, text);
                str = text.Split(' ');
                Array.Sort(str);
                Create();
                for (int i = 0; i < buffer.Length ; i++)
                {
                        num = 0;
                    string tempword = buffer[i];
                    for ( j = 0; j < str.Length  ; j++)
                    {
                        if (tempword.Equals(str[j]))
                        {
                            num++;
                        }
                    }
                    
                    listBox1.Items.Add(tempword + num).ToString();

                }
               

            }
            
        }
        private void Create()
        {
            buffer = str.Distinct().ToArray();
        }
    }  
}
