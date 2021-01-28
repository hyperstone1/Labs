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
    public partial class Subjects : Form
    {
        public Subjects()
        {
            InitializeComponent();
        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database11DataSet6.subjects". При необходимости она может быть перемещена или удалена.
            this.subjectsTableAdapter1.Fill(this.database11DataSet6.subjects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database11DataSet2.subjects". При необходимости она может быть перемещена или удалена.
            this.subjectsTableAdapter.Fill(this.database11DataSet2.subjects);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.subjectsTableAdapter.Update(this.database11DataSet2.subjects);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddSubjectForm af = new AddSubjectForm();
            af.Owner = this;
            af.Show();
        }
    }
}
