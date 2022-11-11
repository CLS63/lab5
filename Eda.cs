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
    public partial class Eda : Form
    {
        public Eda()
        {
            InitializeComponent();
        }

        private void Eda_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Otdel_kadrov". При необходимости она может быть перемещена или удалена.
            this.otdel_kadrovTableAdapter.Fill(this.cinemaDataSet.Otdel_kadrov);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.cinemaDataSet.Tovar);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.cinemaDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Prodaza_edu_v_kinobare". При необходимости она может быть перемещена или удалена.
            this.prodaza_edu_v_kinobareTableAdapter.Fill(this.cinemaDataSet.Prodaza_edu_v_kinobare);

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Dopeda dopeda = new Dopeda();
            dopeda.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            prodazaeduvkinobareBindingSource.EndEdit();
            prodaza_edu_v_kinobareTableAdapter.Update(cinemaDataSet);
        }
    }
}
