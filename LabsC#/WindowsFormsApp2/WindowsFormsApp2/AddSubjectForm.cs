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
    public partial class AddSubjectForm : Form
    {
        public AddSubjectForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Subjects main = this.Owner as Subjects;
            if (main != null)
            {
                DataRow nRow = main.database11DataSet2.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                main.database11DataSet2.Tables[0].Rows.Add(nRow);
                main.subjectsTableAdapter.Update(main.database11DataSet2.subjects);
                main.database11DataSet2.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
            }
        }
    }
}
