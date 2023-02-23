namespace Exam1ProgrammingQuestion
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void golfButton_Click(object sender, EventArgs e)
        {
            GolfTeam msuGolf = new GolfTeam("Titleist", "MSU Golf Course", "Jim Harrison",
                "Golf", 15, 8);
            sportTextBox.Text = msuGolf.SportName;
            coachTextBox.Text = msuGolf.CoachName;
            currentPlayersTextBox.Text = msuGolf.CurrentPlayers.ToString();
            maxPlayersTextBox.Text = msuGolf.MaxPlayers.ToString();
            playerSlotsTextBox.Text = msuGolf.RemainingOpenSlots().ToString();

            toStringTextBox.Text = msuGolf.ToString();
            howToPlayTextBox.Text = msuGolf.HowToPlay();
            budgetTextBox.Text = msuGolf.BudgetingStandards() +
                " Our total budget is: " + msuGolf.YearlyBudget().ToString();
        }

        private void baseballButton_Click(object sender, EventArgs e)
        {
            BaseballTeam msuBaseball = new BaseballTeam("Louisville Slugger", "Jane Hendrickson",
                "Baseball", 30, 27);

            sportTextBox.Text = msuBaseball.SportName;
            coachTextBox.Text = msuBaseball.CoachName;
            currentPlayersTextBox.Text = msuBaseball.CurrentPlayers.ToString();
            maxPlayersTextBox.Text = msuBaseball.MaxPlayers.ToString();
            playerSlotsTextBox.Text = msuBaseball.RemainingOpenSlots().ToString();

            toStringTextBox.Text = msuBaseball.ToString();
            howToPlayTextBox.Text = msuBaseball.HowToPlay();
            budgetTextBox.Text = msuBaseball.BudgetingStandards() +
                " Our total budget is: " + msuBaseball.YearlyBudget().ToString();
        }
    }
}