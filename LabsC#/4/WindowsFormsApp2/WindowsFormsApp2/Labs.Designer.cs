
namespace WindowsFormsApp2
{
    partial class Labs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idLabDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTeacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database11DataSet3 = new WindowsFormsApp2.Database11DataSet3();
            this.labsTableAdapter = new WindowsFormsApp2.Database11DataSet3TableAdapters.labsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.database11DataSet5 = new WindowsFormsApp2.Database11DataSet5();
            this.labsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.labsTableAdapter1 = new WindowsFormsApp2.Database11DataSet5TableAdapters.labsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLabDataGridViewTextBoxColumn,
            this.idStudentDataGridViewTextBoxColumn,
            this.idTeacherDataGridViewTextBoxColumn,
            this.idSubjectDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.labsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(857, 144);
            this.dataGridView1.TabIndex = 0;
            // 
            // idLabDataGridViewTextBoxColumn
            // 
            this.idLabDataGridViewTextBoxColumn.DataPropertyName = "idLab";
            this.idLabDataGridViewTextBoxColumn.HeaderText = "idLab";
            this.idLabDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idLabDataGridViewTextBoxColumn.Name = "idLabDataGridViewTextBoxColumn";
            this.idLabDataGridViewTextBoxColumn.Width = 125;
            // 
            // idStudentDataGridViewTextBoxColumn
            // 
            this.idStudentDataGridViewTextBoxColumn.DataPropertyName = "idStudent";
            this.idStudentDataGridViewTextBoxColumn.HeaderText = "idStudent";
            this.idStudentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idStudentDataGridViewTextBoxColumn.Name = "idStudentDataGridViewTextBoxColumn";
            this.idStudentDataGridViewTextBoxColumn.Width = 125;
            // 
            // idTeacherDataGridViewTextBoxColumn
            // 
            this.idTeacherDataGridViewTextBoxColumn.DataPropertyName = "idTeacher";
            this.idTeacherDataGridViewTextBoxColumn.HeaderText = "idTeacher";
            this.idTeacherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idTeacherDataGridViewTextBoxColumn.Name = "idTeacherDataGridViewTextBoxColumn";
            this.idTeacherDataGridViewTextBoxColumn.Width = 125;
            // 
            // idSubjectDataGridViewTextBoxColumn
            // 
            this.idSubjectDataGridViewTextBoxColumn.DataPropertyName = "idSubject";
            this.idSubjectDataGridViewTextBoxColumn.HeaderText = "idSubject";
            this.idSubjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idSubjectDataGridViewTextBoxColumn.Name = "idSubjectDataGridViewTextBoxColumn";
            this.idSubjectDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "rating";
            this.ratingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.Width = 125;
            // 
            // labsBindingSource
            // 
            this.labsBindingSource.DataMember = "labs";
            this.labsBindingSource.DataSource = this.database11DataSet3;
            // 
            // database11DataSet3
            // 
            this.database11DataSet3.DataSetName = "Database11DataSet3";
            this.database11DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labsTableAdapter
            // 
            this.labsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 167);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 167);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(260, 167);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 3;
            this.button3.Text = "Закрыть";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // database11DataSet5
            // 
            this.database11DataSet5.DataSetName = "Database11DataSet5";
            this.database11DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labsBindingSource1
            // 
            this.labsBindingSource1.DataMember = "labs";
            this.labsBindingSource1.DataSource = this.database11DataSet5;
            // 
            // labsTableAdapter1
            // 
            this.labsTableAdapter1.ClearBeforeFill = true;
            // 
            // Labs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 286);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Labs";
            this.Text = "Labs";
            this.Load += new System.EventHandler(this.Labs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public Database11DataSet3 database11DataSet3;
        private System.Windows.Forms.BindingSource labsBindingSource;
        public Database11DataSet3TableAdapters.labsTableAdapter labsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTeacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Database11DataSet5 database11DataSet5;
        private System.Windows.Forms.BindingSource labsBindingSource1;
        private Database11DataSet5TableAdapters.labsTableAdapter labsTableAdapter1;
    }
}