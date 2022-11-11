using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Otdelkad otdelkad = new Otdelkad();
            otdelkad.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bilet bilet = new Bilet();
            bilet.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Eda eda = new Eda();
            eda.ShowDialog();
        }
    }
}
