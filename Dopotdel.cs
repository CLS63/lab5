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
    public partial class Dopotdel : Form
    {
        public Dopotdel()
        {
            InitializeComponent();
        }

        private void Dopotdel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Prichina_yvolnenya". При необходимости она может быть перемещена или удалена.
            this.prichina_yvolnenyaTableAdapter.Fill(this.cinemaDataSet.Prichina_yvolnenya);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Dolzhnost". При необходимости она может быть перемещена или удалена.
            this.dolzhnostTableAdapter.Fill(this.cinemaDataSet.Dolzhnost);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dolzhnostBindingSource.EndEdit();
            dolzhnostTableAdapter.Update(cinemaDataSet);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            prichinayvolnenyaBindingSource.EndEdit();
            prichina_yvolnenyaTableAdapter.Update(cinemaDataSet);
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

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                dataGridView2.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                        if (dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(toolStripTextBox2.Text))
                        {
                            dataGridView2.Rows[i].Selected = true;
                            break;
                        }
            }
        }
    }
}
