using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "деканатDataSet.Преподаватели". При необходимости она может быть перемещена или удалена.
            this.преподавателиTableAdapter.Fill(this.деканатDataSet.Преподаватели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "деканатDataSet.Дисциплины". При необходимости она может быть перемещена или удалена.
            this.дисциплиныTableAdapter.Fill(this.деканатDataSet.Дисциплины);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "деканатDataSet.Группы". При необходимости она может быть перемещена или удалена.
            this.группыTableAdapter.Fill(this.деканатDataSet.Группы);

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 dlg = new Form2();
            dlg.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 dlg = new Form3();
            dlg.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 dlg = new Form4();
            dlg.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                Close();
            }
        }
    }
}
