using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kofein_Calculator
{
    public partial class Form1 : Form
    {
        int kofein = 0;
        int kafe = 0;
        int tea = 0;
        bool dual = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kafe = Convert.ToInt32(textBox1.Text);
            tea = Convert.ToInt32(textBox2.Text);
            dual = checkBox1.Checked;
            if (dual == true)
            {
                kofein = (40 * 2 * kafe) + (20 * tea);
                MessageBox.Show("Právě v sobě máte " + kofein + "mg kofeinu");
                progress.Value = 100;
                toolStripStatusLabel1.Text = "Hotovo";
            }
            else
            {
                kofein = (40 * kafe) + (20 * tea);
                MessageBox.Show("Právě v sobě máte " + kofein + "mg kofeinu");
                progress.Value = 100;
                toolStripStatusLabel1.Text = "Hotovo";
            }


        }
    }
}
