namespace WindowsFormsApp2
{
    partial class Form1
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
            this.major_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.major_Chair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.major_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataBaseDataSet1 = new WindowsFormsApp2.StudentDataBaseDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataBaseDataSet = new WindowsFormsApp2.StudentDataBaseDataSet();
            this.studentTableAdapter = new WindowsFormsApp2.StudentDataBaseDataSetTableAdapters.StudentTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.studentDataBaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorChairDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBaseDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBaseDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.major_Name,
            this.major_Chair,
            this.major_Phone,
            this.studentIDDataGridViewTextBoxColumn,
            this.studentFirstNameDataGridViewTextBoxColumn,
            this.studentLastNameDataGridViewTextBoxColumn,
            this.majorIDDataGridViewTextBoxColumn,
            this.studentPhoneDataGridViewTextBoxColumn,
            this.majorNameDataGridViewTextBoxColumn,
            this.majorChairDataGridViewTextBoxColumn,
            this.majorPhoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(854, 447);
            this.dataGridView1.TabIndex = 0;
            // 
            // major_Name
            // 
            this.major_Name.DataPropertyName = "major_Name";
            this.major_Name.HeaderText = "major_Name";
            this.major_Name.Name = "major_Name";
            // 
            // major_Chair
            // 
            this.major_Chair.DataPropertyName = "major_Chair";
            this.major_Chair.HeaderText = "major_Chair";
            this.major_Chair.Name = "major_Chair";
            // 
            // major_Phone
            // 
            this.major_Phone.DataPropertyName = "major_Phone";
            this.major_Phone.HeaderText = "major_Phone";
            this.major_Phone.Name = "major_Phone";
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "Student";
            this.studentBindingSource1.DataSource = this.studentDataBaseDataSet1;
            // 
            // studentDataBaseDataSet1
            // 
            this.studentDataBaseDataSet1.DataSetName = "StudentDataBaseDataSet";
            this.studentDataBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.studentDataBaseDataSet;
            // 
            // studentDataBaseDataSet
            // 
            this.studentDataBaseDataSet.DataSetName = "StudentDataBaseDataSet";
            this.studentDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(901, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // studentDataBaseDataSet1BindingSource
            // 
            this.studentDataBaseDataSet1BindingSource.DataSource = this.studentDataBaseDataSet1;
            this.studentDataBaseDataSet1BindingSource.Position = 0;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "student_ID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "student_ID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            // 
            // studentFirstNameDataGridViewTextBoxColumn
            // 
            this.studentFirstNameDataGridViewTextBoxColumn.DataPropertyName = "student_FirstName";
            this.studentFirstNameDataGridViewTextBoxColumn.HeaderText = "student_FirstName";
            this.studentFirstNameDataGridViewTextBoxColumn.Name = "studentFirstNameDataGridViewTextBoxColumn";
            // 
            // studentLastNameDataGridViewTextBoxColumn
            // 
            this.studentLastNameDataGridViewTextBoxColumn.DataPropertyName = "student_LastName";
            this.studentLastNameDataGridViewTextBoxColumn.HeaderText = "student_LastName";
            this.studentLastNameDataGridViewTextBoxColumn.Name = "studentLastNameDataGridViewTextBoxColumn";
            // 
            // majorIDDataGridViewTextBoxColumn
            // 
            this.majorIDDataGridViewTextBoxColumn.DataPropertyName = "major_ID";
            this.majorIDDataGridViewTextBoxColumn.HeaderText = "major_ID";
            this.majorIDDataGridViewTextBoxColumn.Name = "majorIDDataGridViewTextBoxColumn";
            // 
            // studentPhoneDataGridViewTextBoxColumn
            // 
            this.studentPhoneDataGridViewTextBoxColumn.DataPropertyName = "student_Phone";
            this.studentPhoneDataGridViewTextBoxColumn.HeaderText = "student_Phone";
            this.studentPhoneDataGridViewTextBoxColumn.Name = "studentPhoneDataGridViewTextBoxColumn";
            // 
            // majorNameDataGridViewTextBoxColumn
            // 
            this.majorNameDataGridViewTextBoxColumn.DataPropertyName = "major_Name";
            this.majorNameDataGridViewTextBoxColumn.HeaderText = "major_Name";
            this.majorNameDataGridViewTextBoxColumn.Name = "majorNameDataGridViewTextBoxColumn";
            // 
            // majorChairDataGridViewTextBoxColumn
            // 
            this.majorChairDataGridViewTextBoxColumn.DataPropertyName = "major_Chair";
            this.majorChairDataGridViewTextBoxColumn.HeaderText = "major_Chair";
            this.majorChairDataGridViewTextBoxColumn.Name = "majorChairDataGridViewTextBoxColumn";
            // 
            // majorPhoneDataGridViewTextBoxColumn
            // 
            this.majorPhoneDataGridViewTextBoxColumn.DataPropertyName = "major_Phone";
            this.majorPhoneDataGridViewTextBoxColumn.HeaderText = "major_Phone";
            this.majorPhoneDataGridViewTextBoxColumn.Name = "majorPhoneDataGridViewTextBoxColumn";
            // 
            // studentBindingSource2
            // 
            this.studentBindingSource2.DataMember = "Student";
            this.studentBindingSource2.DataSource = this.studentDataBaseDataSet1BindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 520);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBaseDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBaseDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StudentDataBaseDataSet studentDataBaseDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private StudentDataBaseDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private StudentDataBaseDataSet studentDataBaseDataSet1;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn major_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn major_Chair;
        private System.Windows.Forms.DataGridViewTextBoxColumn major_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorChairDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentDataBaseDataSet1BindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource2;
    }
}

