using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TournamentLibrary.Models;

namespace TournamentLibrary
{
    public static class Logic
    {
        public static void CreateRounds(TournamentModel model)
        {
            List<TeamModel> randomTeams = RandomTeamOrder(model.EnteredTeams);
            int rounds = FindRounds(randomTeams.Count);
            int byes = numbByes(rounds, randomTeams.Count);

            model.Rounds.Add(CreateFirstRound(byes, randomTeams));
            createOthers(model, rounds);
        }
        private static void createOthers(TournamentModel model, int rounds)
        {
            int round = 2;
            List<MatchupModel> prevRound = model.Rounds[0];
            List<MatchupModel> currROund = new List<MatchupModel>();
            MatchupModel currMatchup = new MatchupModel();

            while (round <= rounds)
            {
                foreach (MatchupModel match in prevRound)
                {
                    currMatchup.Entries.Add(new MatchupEntryModel { ParentMatchup = match });

                    if (currMatchup.Entries.Count > 1)
                    {
                        currMatchup.MatchupROund = round;
                        currROund.Add(currMatchup);
                        currMatchup = new MatchupModel();
                    }
                }
                model.Rounds.Add(currROund);
                prevRound = currROund;

                currROund = new List<MatchupModel>();
                round += 1;

            }

        }
          
        private static List<MatchupModel> CreateFirstRound(int byes, List<TeamModel> teams)
        {
            List<MatchupModel> output = new List<MatchupModel>();
            MatchupModel curr = new MatchupModel();

            foreach(TeamModel team in teams)
            {
                curr.Entries.Add(new MatchupEntryModel { TeamCompeting = team });

                if (byes > 0 || curr.Entries.Count > 1)
                {
                    curr.MatchupROund = 1;
                    output.Add(curr);
                    curr = new MatchupModel();

                    if (byes > 0)
                    {
                        byes -= 1;
                    }
                }
            }
            return output;
        }
        private static int numbByes(int rounds, int numberTeams)
        {
            int output = 0;
            int totalTeams = 1;

            for (int i = 0; i < rounds; i++)
            {
                totalTeams *= 2;
            }

            output = totalTeams - numberTeams;

            return output;
        }
        private static int FindRounds(int teamCount)
        {
            int output = 1;
            int val = 2;
            
            while (val < teamCount)
            {
                output = +1;
                val *= 2;
            }

            return output;
        }

        private static List<TeamModel> RandomTeamOrder(List<TeamModel> teams)
        {
            return teams.OrderBy(x => Guid.NewGuid()).ToList();
        }
    }
}
