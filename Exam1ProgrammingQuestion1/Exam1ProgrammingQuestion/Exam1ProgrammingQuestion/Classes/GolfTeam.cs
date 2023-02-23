using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1ProgrammingQuestion
{
    internal class GolfTeam : SportingTeam, IBudgeting
    {
        public string SponsoredGolfBallBrand { get; protected set; }
        public string GolfCourseName { get; protected set; }

        public GolfTeam(string sponsoredGolfBallBrand, string golfCourseName, string coachName,
            string sportName, int maxPlayers, int currentPlayers) : 
            base(coachName, sportName, maxPlayers, currentPlayers)
        {
            SponsoredGolfBallBrand = sponsoredGolfBallBrand;
            GolfCourseName = golfCourseName;
        }

        public override string ToString()
        {
            return base.ToString() + "This golf team is sponsored by: " + SponsoredGolfBallBrand +
                " and plays at: " + GolfCourseName + ".";
        }

        public override string HowToPlay()
        {
            return base.HowToPlay() + "For golf in particular, first, you'll need a few clubs. " +
                "The big three that you need are the driver, the iron, and the putter. " +
                "Once you have these, meet us at " + GolfCourseName + " for lessons.";
        }

        public override int RemainingOpenSlots()
        {
            return base.RemainingOpenSlots();
        }

        public string BudgetingStandards()
        {
            if (SponsoredGolfBallBrand.ToLower() == "titleist")
                return "*Titleist* has sponsored us this year -- \"budgeting\" is of small concern.";
            else
                return "We do not have a significant sponsor this year, so our yearly budget this year will depend on" +
                    " the generosity of our private donors.";
        }

        public int YearlyBudget()
        {
            if (SponsoredGolfBallBrand.ToLower() == "titleist")
                return 150000;
            else
                return 10000;
        }
    }
}
