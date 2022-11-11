﻿using System;
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
    public partial class Dopeda : Form
    {
        public Dopeda()
        {
            InitializeComponent();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigator3_RefreshItems(object sender, EventArgs e)
        {

        }

        private void Dopeda_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Dolzhnost". При необходимости она может быть перемещена или удалена.
            this.dolzhnostTableAdapter.Fill(this.cinemaDataSet.Dolzhnost);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Prichina_yvolnenya". При необходимости она может быть перемещена или удалена.
            this.prichina_yvolnenyaTableAdapter.Fill(this.cinemaDataSet.Prichina_yvolnenya);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.cinemaDataSet.Tovar);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.cinemaDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Otdel_kadrov". При необходимости она может быть перемещена или удалена.
            this.otdel_kadrovTableAdapter.Fill(this.cinemaDataSet.Otdel_kadrov);

        }

        private void bindingNavigator1_RefreshItems_1(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            otdelkadrovBindingSource.EndEdit();
            otdel_kadrovTableAdapter.Update(cinemaDataSet);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            clientBindingSource.EndEdit();
            clientTableAdapter.Update(cinemaDataSet);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            tovarBindingSource.EndEdit();
            tovarTableAdapter.Update(cinemaDataSet);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView3.RowCount; i++)
            {
                dataGridView3.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView3.ColumnCount; j++)
                    if (dataGridView3.Rows[i].Cells[j].Value != null)
                        if (dataGridView3.Rows[i].Cells[j].Value.ToString().Contains(toolStripTextBox1.Text))
                        {
                            dataGridView3.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(toolStripTextBox2.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                dataGridView2.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                        if (dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(toolStripTextBox3.Text))
                        {
                            dataGridView2.Rows[i].Selected = true;
                            break;
                        }
            }
        }
    }
}
