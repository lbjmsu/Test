using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.StudentDataBaseDataSetTableAdapters;

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
            // TODO: This line of code loads data into the 'studentDataBaseDataSet1.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.FillA(this.studentDataBaseDataSet1.Student);
            // TODO: This line of code loads data into the 'studentDataBaseDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.FillA(this.studentDataBaseDataSet.Student);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentTableAdapter.FillBy(this.studentDataBaseDataSet.Student);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
