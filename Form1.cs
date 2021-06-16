using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPproject_w61934
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try {
                double x = double.Parse(textBox1.Text);
                if (comboBox1.SelectedIndex == 0) 
                x = x* 1.23;
            if(comboBox1.SelectedIndex == 1)
                x =  x * 1.08;
            if (comboBox1.SelectedIndex == 2)
                x = x * 1.07;
            if (comboBox1.SelectedIndex == 3)
                x = x * 1.05;
            if (comboBox1.SelectedIndex == 4)
                x = x;
             textBox3.Text = x.ToString();
        }
            catch (Exception)
            {
                MessageBox.Show( "Wprowadż prawidłowe znaczenia", "Uwaga!", MessageBoxButtons.OK);
            }

}
    }
}
