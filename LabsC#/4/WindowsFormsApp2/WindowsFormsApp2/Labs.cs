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
    public partial class Labs : Form
    {
        public Labs()
        {
            InitializeComponent();
        }

        private void Labs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database11DataSet5.labs". При необходимости она может быть перемещена или удалена.
            this.labsTableAdapter1.Fill(this.database11DataSet5.labs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database11DataSet3.labs". При необходимости она может быть перемещена или удалена.
            this.labsTableAdapter.Fill(this.database11DataSet3.labs);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.labsTableAdapter.Update(this.database11DataSet3.teachers); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddLabForm af = new AddLabForm();
            af.Owner = this;
            af.Show();
        }
    }
}
