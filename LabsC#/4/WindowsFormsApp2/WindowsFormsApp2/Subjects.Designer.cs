
namespace WindowsFormsApp2
{
    partial class Subjects
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database11DataSet2 = new WindowsFormsApp2.Database11DataSet2();
            this.subjectsTableAdapter = new WindowsFormsApp2.Database11DataSet2TableAdapters.subjectsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.database11DataSet6 = new WindowsFormsApp2.Database11DataSet6();
            this.subjectsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsTableAdapter1 = new WindowsFormsApp2.Database11DataSet6TableAdapters.subjectsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameSubjectDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.subjectsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(327, 110);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameSubjectDataGridViewTextBoxColumn
            // 
            this.nameSubjectDataGridViewTextBoxColumn.DataPropertyName = "nameSubject";
            this.nameSubjectDataGridViewTextBoxColumn.HeaderText = "nameSubject";
            this.nameSubjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameSubjectDataGridViewTextBoxColumn.Name = "nameSubjectDataGridViewTextBoxColumn";
            this.nameSubjectDataGridViewTextBoxColumn.Width = 125;
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "subjects";
            this.subjectsBindingSource.DataSource = this.database11DataSet2;
            // 
            // database11DataSet2
            // 
            this.database11DataSet2.DataSetName = "Database11DataSet2";
            this.database11DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectsTableAdapter
            // 
            this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 133);
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
            this.button2.Location = new System.Drawing.Point(127, 132);
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
            this.button3.Location = new System.Drawing.Point(243, 132);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 3;
            this.button3.Text = "Закрыть";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // database11DataSet6
            // 
            this.database11DataSet6.DataSetName = "Database11DataSet6";
            this.database11DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectsBindingSource1
            // 
            this.subjectsBindingSource1.DataMember = "subjects";
            this.subjectsBindingSource1.DataSource = this.database11DataSet6;
            // 
            // subjectsTableAdapter1
            // 
            this.subjectsTableAdapter1.ClearBeforeFill = true;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 384);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Subjects";
            this.Text = "Subjects";
            this.Load += new System.EventHandler(this.Subjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public Database11DataSet2 database11DataSet2;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        public Database11DataSet2TableAdapters.subjectsTableAdapter subjectsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Database11DataSet6 database11DataSet6;
        private System.Windows.Forms.BindingSource subjectsBindingSource1;
        private Database11DataSet6TableAdapters.subjectsTableAdapter subjectsTableAdapter1;
    }
}