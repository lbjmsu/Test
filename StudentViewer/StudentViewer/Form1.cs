using StudentNamespace;
using System.Collections.Generic;
namespace StudentViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Student> students = new List<Student>();
        
        private void studentNamesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (students.Count == 0)
                students.Add(new Student("69420", "Joshua", "Henderson", "Pogs", "Hehe"));
            showFirstBox.Text = students[studentNamesBox.SelectedIndex].FirstName;
            showLastBox.Text = students[studentNamesBox.SelectedIndex].LastName;
            showMajorBox.Text = students[studentNamesBox.SelectedIndex].Major;
            showIDBox.Text = students[studentNamesBox.SelectedIndex].IdNumber;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(students.Count == 0)
                students.Add(new Student("69420", "Joshua", "Henderson", "Pogs", "Hehe"));
            Student temp = new Student(addIDBox.Text, addFirstBox.Text, addLastBox.Text, addMajorBox.Text, "5");
            students.Add(temp);
            studentNamesBox.Items.Add(temp.FirstName + " " + temp.LastName);
            clearButton_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            addIDBox.Text = "";
            addFirstBox.Text = "";
            addLastBox.Text = "";
            addMajorBox.Text = "";
        }
    }
}