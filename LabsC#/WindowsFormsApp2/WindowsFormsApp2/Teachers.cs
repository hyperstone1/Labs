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
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database11DataSet1.teachers". При необходимости она может быть перемещена или удалена.
            this.teachersTableAdapter.Fill(this.database11DataSet1.teachers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.teachersTableAdapter.Update(this.database11DataSet1.teachers);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddTeacherForm af = new AddTeacherForm();
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
    }
}
