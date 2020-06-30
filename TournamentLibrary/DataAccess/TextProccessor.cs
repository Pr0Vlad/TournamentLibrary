using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;

using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
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
