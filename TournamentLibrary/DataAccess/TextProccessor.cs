using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;

using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using TournamentLibrary.Models;

namespace TournamentLibrary.DataAccess.TextHelper
{
    public static class TextProccessor
    {
        public static string fullFilePath(this string fileName)
        {
            //first part is the filepatch then filename
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{ fileName }";
        }
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }
        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines)
            {
                //comma will seperate each line in the csv file
                string[] cols = line.Split(',');

                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = (cols[2]);        
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);
                output.Add(p);

            }
            return output;
        }
        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.PhoneNumber = cols[4];
                output.Add(p);
            }
            return output;
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFileName)
        {
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = peopleFileName.fullFilePath().LoadFile().ConvertToPersonModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                TeamModel t = new TeamModel();
                t.Id = int.Parse(cols[0]);
                t.TeamName = cols[1];

                string[] personIds = cols[2].Split('|');

                foreach (string id in personIds)
                {
                    t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
                }
                output.Add(t);
            }
            return output;
        }

        public static List<TournamentModel> ConvertToTournamentModels(this List<string> lines, string teamFileName, string peopleFileName, string prizeFileName)
        {
            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = teamFileName.fullFilePath().LoadFile().ConvertToTeamModels(peopleFileName);
            List<PrizeModel> prizes = prizeFileName.fullFilePath().LoadFile().ConvertToPrizeModels();
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.fullFilePath().LoadFile().ConvertToMatchupModels();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TournamentModel tm = new TournamentModel();
                tm.Id = int.Parse(cols[0]);
                tm.TournamentName = cols[1];
                tm.EntryFee = decimal.Parse(cols[2]);

                string[] teamIds = cols[3].Split('|');

                foreach (string id in teamIds)
                {
                    tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }

                string[] prizeIds = cols[4].Split('|');

                foreach(string id in prizeIds)
                {
                    tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                }
                string[] rounds = cols[5].Split('|');
                List<MatchupModel> ms = new List<MatchupModel>();
                foreach(string round in rounds)
                {
                    string[] m = round.Split('^');

                    foreach (string matchupmodeltextid in m)
                    {
                        ms.Add(matchups.Where(x => x.Id == int.Parse(matchupmodeltextid)).First());
                    }
                    tm.Rounds.Add(ms);
                }

                output.Add(tm);

            }
            return output;
        }

        public static void WriteToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{ p.Id },{ p.PlaceNumber },{ p.PlaceName },{ p.PrizeAmount },{ p.PrizePercentage }");
            }
            File.WriteAllLines(fileName.fullFilePath(), lines);
        }
        public static void WriteToPeopleFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                lines.Add($"{ p.Id },{ p.FirstName },{ p.LastName },{ p.EmailAddress },{ p.PhoneNumber }");
            }
            File.WriteAllLines(fileName.fullFilePath(), lines);
        }
        public static void WriteToTeamsFile(this List<TeamModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel t in models)
            {
                lines.Add($" { t.Id },{ t.TeamName },{ convertPeopleToString(t.TeamMembers) } ");
            }

            File.WriteAllLines(fileName.fullFilePath(), lines);
        }

        public static void SaveToTournamentFile(this List<TournamentModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach(TournamentModel tm in models)
            {
                lines.Add($"{ tm.Id },{ tm.TournamentName },{ tm.EntryFee },{ ConvertTeamListToString(tm.EnteredTeams) },{ ConvertPrizeListToString(tm.Prizes) },{ ConvertRoundListToString(tm.Rounds) }");
            }

            File.WriteAllLines(fileName.fullFilePath(), lines);
        }
        public static void SaveRoundsToFile(this TournamentModel model, string matchupFile, string matchupEntryFile)
        {
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    matchup.SaveMatchupToFile(matchupFile, matchupEntryFile);
                }
            }
        }
        public static List<MatchupEntryModel> ConvertToMatchupEntryModels(this List<string> lines)
        {
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                MatchupEntryModel m = new MatchupEntryModel();
                m.Id = int.Parse(cols[0]);
                if (cols[1].Length == 0)
                {
                    m.TeamCompeting = null;
                }
                else
                {
                    m.TeamCompeting = LookupTeamById(int.Parse(cols[1]));
                }
                
                m.Score = double.Parse(cols[2]);

                int parentId = 0;
                if (int.TryParse(cols[3], out parentId))
                {
                    m.ParentMatchup = LookupMatchupById(parentId);
                }
                else
                {
                    m.ParentMatchup = null;
                }
               
                output.Add(m);
            }
            return output;
        }
        private static MatchupModel LookupMatchupById(int id)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.fullFilePath().LoadFile().ConvertToMatchupModels();

            return matchups.Where(x => x.Id == id).First();
        }
        private static List<MatchupEntryModel> ConvertStringToMatchupEntryModels(string input)
        {
            string[] ids = input.Split('|');
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.fullFilePath().LoadFile().ConvertToMatchupEntryModels();
            foreach (string id in ids)
            {
                output.Add(entries.Where(x => x.Id == int.Parse(id)).First());
            }
            return output;

        }
        private static TeamModel LookupTeamById(int id)
        {
            List<TeamModel> teams = GlobalConfig.TeamFile.fullFilePath().LoadFile().ConvertToTeamModels(GlobalConfig.PeopleFile);

            return teams.Where(x => x.Id == id).First();
        }
        public static List<MatchupModel> ConvertToMatchupModels(this List<string> lines)
        {
            List<MatchupModel> output = new List<MatchupModel>();

            foreach (string line in lines)

            {
                string[] cols = line.Split(',');
                MatchupModel p = new MatchupModel();
                p.Id = int.Parse(cols[0]);
                p.Entries = ConvertStringToMatchupEntryModels(cols[1]);
                p.Winner = LookupTeamById(int.Parse(cols[2]));
                p.MatchupROund = int.Parse(cols[3]);
                output.Add(p);
            }
            return output;
        }
        public static void SaveEntryToFile(this MatchupEntryModel entry, string matchupEntryFile)
        {
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.fullFilePath().LoadFile().ConvertToMatchupEntryModels();

            int current = 1;

            if (entries.Count > 0)
            {
                current = entries.OrderByDescending(x => x.Id).First().Id + 1;
            }
            entry.Id = current;
            entries.Add(entry);

            List<string> lines = new List<string>();
            foreach (MatchupEntryModel e in entries)
            {
                string parent = "";
                if (e.ParentMatchup != null)
                {
                    parent = e.ParentMatchup.Id.ToString();
                }
                string teamCompeting = "";
                if (e.TeamCompeting != null)
                {
                    teamCompeting = e.TeamCompeting.Id.ToString();
                }
                lines.Add($"{ e.Id },{ teamCompeting },{ e.Score },{ parent }");
            }
            File.WriteAllLines(GlobalConfig.MatchupEntryFile.fullFilePath(), lines);
        }
        public static void SaveMatchupToFile(this MatchupModel matchup, string matchupFile, string matchupEntryFile)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.fullFilePath().LoadFile().ConvertToMatchupModels();
            int current = 1;
            if(matchups.Count > 0)
            {
                current = matchups.OrderByDescending(x => x.Id).First().Id + 1;
            }
            matchup.Id = current;

            foreach(MatchupEntryModel e in matchup.Entries)
            {
                e.SaveEntryToFile(matchupEntryFile);
            }

            List<string> lines = new List<string>();
            foreach(MatchupModel m in matchups)

            {
                string winner = "";
                if (m.Winner != null)
                {
                    winner = m.Winner.Id.ToString();
                }
                lines.Add($"{ m.Id },{ ConvertMatchupEntryListToString(m.Entries) },{ winner },{ m.MatchupROund }");
            }
            File.WriteAllLines(GlobalConfig.MatchupFile.fullFilePath(), lines);
            
        }
        public static string ConvertMatchupEntryListToString(List<MatchupEntryModel> entries)
        {
            string output = "";

            if(entries.Count == 0)
            {
                return "";
            }
            foreach(MatchupEntryModel e in entries)
            {
                output += $"{ e.Id }|";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }


       

        private static string ConvertRoundListToString(List<List<MatchupModel>> rounds)
        {
            string output = "";

            if (rounds.Count == 0)
            {
                return "";
            }
            foreach (List<MatchupModel> p in rounds)
            {
                output += $"{ ConvertMatchupListToString(p) }|";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string ConvertMatchupListToString(List<MatchupModel> matchups)
        {
            string output = "";

            if (matchups.Count == 0)
            {
                return "";
            }
            foreach (MatchupModel p in matchups)
            {
                output += $"{ p.Id }^";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string ConvertPrizeListToString(List<PrizeModel> prizes)
        {
            string output = "";

            if (prizes.Count == 0)
            {
                return "";
            }
            foreach (PrizeModel p in prizes)
            {
                output += $"{ p.Id }|";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string ConvertTeamListToString(List<TeamModel> teams)
        {
            string output = "";

            if (teams.Count == 0)
            {
                return "";
            }
            foreach (TeamModel p in teams)
            {
                output += $"{ p.Id }|";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }
        private static string convertPeopleToString(List<PersonModel> people)
        {
            string output = "";

            if(people.Count == 0)
            {
                return "";
            }
            foreach (PersonModel p in people)
            {
                output += $"{ p.Id }|";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }
    }
}
