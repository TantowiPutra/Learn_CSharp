using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Functions
{
    public partial class Form1 : Form
    {
        public delegate void setForm2(string text);
        public event setForm2 setform2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textBoxValue = textBox1.Text;
            setform2?.Invoke(textBoxValue);


            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
