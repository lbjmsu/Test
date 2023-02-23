using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1ProgrammingQuestion
{
    internal class BaseballTeam : SportingTeam, IBudgeting
    {
        public string BaseballBatBrand { get; protected set; }

        public BaseballTeam(string baseballBatBrand, string coachName, string sportName,
            int maxPlayers, int currentPlayers) : base(coachName, sportName, maxPlayers, currentPlayers)
        {
            BaseballBatBrand = baseballBatBrand;
        }

        public string BudgetingStandards()
        {
            return "We rely on donations from our private donors and revenue from games.";
        }

        public int YearlyBudget()
        {
            return 35000;
        }

        public override string ToString()
        {
            return base.ToString() + "The team proudly uses " + BaseballBatBrand + ".";
        }

        public override string HowToPlay()
        {
            return base.HowToPlay() + "Now, the easiest way to play baseball is to be one of the basemen." +
                " For this, simply wait for the ball to be hit, catch it if it comes your way," +
                " and if any batters run toward you, touch them with the baseball before they get to the plate.";
        }

        public override int RemainingOpenSlots()
        {
            return base.RemainingOpenSlots();
        }
    }
}
