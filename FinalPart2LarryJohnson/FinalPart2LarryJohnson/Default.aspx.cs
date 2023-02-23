using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void generateButton_Click(object sender, EventArgs e)
    {
        if (toDoListBox.Items.Count > 0)
            return;

        Random random = new Random();

        string itemsString = itemsTextBox.Text;
        string nameString = nameTextBox.Text;
        string firstName = nameString.Split(' ')[0];

        if (itemsString != String.Empty && nameString != String.Empty)
        {
            string[] items = itemsString.Split('\n');
            foreach (string item in items)
            {
                string toAddString = firstName + ", I'm not asking, go " + item.ToLower().Trim() + "."; ;
                toDoListBox.Items.Add(toAddString);
            }
        }
        generateButton.Enabled = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        doingNowLabel.Visible = true;
        doingNowLabel.Text = toDoListBox.SelectedValue;
        toDoListBox.Items.Remove(toDoListBox.SelectedItem);
        Button1.Enabled = false;
    }
}