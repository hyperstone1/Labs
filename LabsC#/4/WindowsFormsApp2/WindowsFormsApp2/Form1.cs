using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database11DataSet4.students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter1.Fill(this.database11DataSet4.students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database11DataSet.students". При необходимости она может быть перемещена или удалена.
            //..this.studentsTableAdapter.Fill(this.database11DataSet.students);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter.Update(this.database11DataSet.students);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.Owner = this;
            af.Show();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Owner = this;
            sf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Teachers th = new Teachers();
            th.Owner = this;
            th.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Subjects th = new Subjects();
            th.Owner = this;
            th.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Labs th = new Labs();
            th.Owner = this;
            th.Show();
        }
    }
}
