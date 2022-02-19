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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "деканатDataSet.Дисциплины". При необходимости она может быть перемещена или удалена.
            this.дисциплиныTableAdapter.Fill(this.деканатDataSet.Дисциплины);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "деканатDataSet.Группы". При необходимости она может быть перемещена или удалена.
            this.группыTableAdapter.Fill(this.деканатDataSet.Группы);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
