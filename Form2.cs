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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Form1 form1 = new Form1();

            form1.setform2 += setLabel;
        }

        public void setLabel(string text)
        {
            Console.WriteLine(text);
            label.Text = text;
        }
    }
}
