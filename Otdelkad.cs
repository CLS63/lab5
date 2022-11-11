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
    public partial class Otdelkad : Form
    {
        public Otdelkad()
        {
            InitializeComponent();
        }

        private void Otdelkad_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Prichina_yvolnenya". При необходимости она может быть перемещена или удалена.
            this.prichina_yvolnenyaTableAdapter.Fill(this.cinemaDataSet.Prichina_yvolnenya);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Dolzhnost". При необходимости она может быть перемещена или удалена.
            this.dolzhnostTableAdapter.Fill(this.cinemaDataSet.Dolzhnost);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Otdel_kadrov". При необходимости она может быть перемещена или удалена.
            this.otdel_kadrovTableAdapter.Fill(this.cinemaDataSet.Otdel_kadrov);

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
          Dopotdel dopotdel = new Dopotdel();
          dopotdel.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
         otdelkadrovBindingSource.EndEdit();
            otdel_kadrovTableAdapter.Update(cinemaDataSet);
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
    }
}
