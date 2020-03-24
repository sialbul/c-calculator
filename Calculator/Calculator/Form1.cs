using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0")
                textBoxResult.Clear();

            Button button = (Button)sender;
            textBoxResult.Text = textBoxResult.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {

        }
    }
}
