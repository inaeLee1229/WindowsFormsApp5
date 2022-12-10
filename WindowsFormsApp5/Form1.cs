using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2=new Form2();
            if (radioButton1 != null)
            {
                form2.ShowDialog();
            }
            if (radioButton2 != null)
            {
                form2.Show();
            }
        }
    }
}
