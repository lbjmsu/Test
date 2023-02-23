using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1ProgrammingQuestion
{
    abstract internal class SportingTeam
    {
        public string CoachName { get; protected set; }
        public string SportName { get; protected set; }
        public int MaxPlayers { get; protected set; }
        public int CurrentPlayers { get; protected set; }

        public SportingTeam(string coachName, string sportName, int maxPlayers, int currentPlayers)
        {
            CoachName = coachName;
            SportName = sportName;
            MaxPlayers = maxPlayers;
            CurrentPlayers = currentPlayers;
        }

        public override string ToString()
        {
            return CoachName + " coaches " + SportName + ". The team has " + CurrentPlayers + 
                " out of " + MaxPlayers + " maximum players. ";
        }

        virtual public string HowToPlay()
        {
            return "To play any sport... First you must stop programming and go outside. Then... \n";
        }

        virtual public int RemainingOpenSlots()
        {
            return MaxPlayers - CurrentPlayers;
        }
    }
}
