using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filepath=string.Empty;
            


            using(OpenFileDialog fd = new OpenFileDialog())
            {
                fd.InitialDirectory = @"C:\";
                fd.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
                fd.FilterIndex = 1;
                fd.RestoreDirectory = true;
                if(fd.ShowDialog() == DialogResult.OK)
                {
                    filepath = fd.FileName;
                }
            }
            var FileStream = new FileStream(filepath,FileMode.Open);
            using (StreamReader reader=new StreamReader(FileStream))
            {
                fileContent=reader.ReadToEnd();
            }
            textBox1.Clear();
            textBox1.AppendText(filepath);
            textBox1.AppendText(fileContent);
        }
        
    }
}
