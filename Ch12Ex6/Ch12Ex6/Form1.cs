namespace Ch12Ex6
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            // Constant conversion values
            // The unit on the right is the output when multiplying by the value of the constant.
            // Dividing by these constants flips the output, e.g., dividing LB_TO_OZ converts from OZ to LB.
            const double LB_TO_OZ = 16;
            const double KG_TO_LB = 2.2046;
            const double KG_TO_G = 1000;

            try
            {
                if (poundsTextBox.Enabled)
                {
                    ouncesTextBox.Text = String.Format("{0:F5}", double.Parse(poundsTextBox.Text) * LB_TO_OZ);
                    kilogramsTextBox.Text = String.Format("{0:F5}", double.Parse(poundsTextBox.Text) / KG_TO_LB);
                    gramsTextBox.Text = String.Format("{0:F2}", double.Parse(kilogramsTextBox.Text) * KG_TO_G);
                }
                else if (gramsTextBox.Enabled)
                {
                    kilogramsTextBox.Text = String.Format("{0:F5}", double.Parse(gramsTextBox.Text) / KG_TO_G);
                    poundsTextBox.Text = String.Format("{0:F5}", double.Parse(kilogramsTextBox.Text) / KG_TO_LB);
                    ouncesTextBox.Text = String.Format("{0:F5}", double.Parse(poundsTextBox.Text) * LB_TO_OZ);
                }
                else if (kilogramsTextBox.Enabled)
                {
                    gramsTextBox.Text = String.Format("{0:F2}", double.Parse(kilogramsTextBox.Text) * KG_TO_G);
                    poundsTextBox.Text = String.Format("{0:F5}", double.Parse(kilogramsTextBox.Text) * KG_TO_LB);
                    ouncesTextBox.Text = String.Format("{0:F5}", double.Parse(poundsTextBox.Text) * LB_TO_OZ);
                }
                else if (ouncesTextBox.Enabled)
                {
                    poundsTextBox.Text = String.Format("{0:F5}", double.Parse(ouncesTextBox.Text) / LB_TO_OZ);
                    kilogramsTextBox.Text = String.Format("{0:F2}", double.Parse(poundsTextBox.Text) / KG_TO_LB);
                    gramsTextBox.Text = String.Format("{0:F5}", double.Parse(kilogramsTextBox.Text) * KG_TO_G);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("You cringed it!!!!1!111!!!");
            }
        }

        private void unitListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            allTextBoxesDisabled();
            allTextBoxesEmpty();
            if(unitListBox.SelectedIndex == 0)
                poundsTextBox.Enabled = true;

            else if (unitListBox.SelectedIndex == 1)
                gramsTextBox.Enabled = true;

            else if (unitListBox.SelectedIndex == 2)
                kilogramsTextBox.Enabled = true;

            else
                ouncesTextBox.Enabled = true;
        }

        private void allTextBoxesDisabled()
        {
            poundsTextBox.Enabled = false;
            gramsTextBox.Enabled = false;
            kilogramsTextBox.Enabled = false;
            ouncesTextBox.Enabled = false;
        }

        private void allTextBoxesEmpty()
        {
            poundsTextBox.Text = "";
            gramsTextBox.Text = "";
            kilogramsTextBox.Text = "";
            ouncesTextBox.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}