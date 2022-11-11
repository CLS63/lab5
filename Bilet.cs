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
    public partial class Bilet : Form
    {
        public Bilet()
        {
            InitializeComponent();
        }

        private void Bilet_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Otdel_kadrov". При необходимости она может быть перемещена или удалена.
            this.otdel_kadrovTableAdapter.Fill(this.cinemaDataSet.Otdel_kadrov);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Film". При необходимости она может быть перемещена или удалена.
            this.filmTableAdapter.Fill(this.cinemaDataSet.Film);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.cinemaDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Pokypka_bileta". При необходимости она может быть перемещена или удалена.
            this.pokypka_biletaTableAdapter.Fill(this.cinemaDataSet.Pokypka_bileta);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dopbilet dopbilet = new Dopbilet();
            dopbilet.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(toolStripTextBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            pokypkabiletaBindingSource.EndEdit();
            pokypka_biletaTableAdapter.Update(cinemaDataSet);
        }
    }
}
