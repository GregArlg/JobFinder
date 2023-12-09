using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinder._01_MainMenu
{
    static class Data
    {
        public static ObservableCollection<string> GetLocations()
        {
            return new ObservableCollection<string>
            {
                "Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney",
                "Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney",
                "Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney",
                "Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney",
                "Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney",
                "Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney",
                "Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney",
                "Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney",
                "Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney",
                "Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney",
                "Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney",
                "Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney",
                "Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney",
                "Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney",
                "Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney",
                "Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney",
                "Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney",
                "Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney",
                "Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney",
                "Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney",
                "Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney",
                "Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney",
                "Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney","Sydney"
            };
        }

        public static ObservableCollection<string> GetSalaries()
        {
            return new ObservableCollection<string>
            {
                "Rieng",
                "0",
                "Visibility",
                "As usual",
                "tkt",
                "Friends and good moments",
                "yes",
                "Salawhat?",
                "Don't be silly",
                "10$ if you manage a whole season"
            };
        }

        public static ObservableCollection<string> GetContracts()
        {
            return new ObservableCollection<string>
            {
                "Full Time",
                "Part Time",
                "Contract",
                "Freelance",
                "Internship"
            };
        }

        public static ObservableCollection<string> GetExperiences()
        {
            return new ObservableCollection<string>
            {
                "Entry (0-1 years)",
                "Junior (1-2 years)",
                "Junior (2-5 years)",
                "Junior (5-10 years)",
                "Junior (10+ years)"
            };
        }

        public static List<Job> GetJobs()
        {
            List<Job> jobs = new List<Job>
            {
                new Job
                {
                    Title = "Game Growth Specialist",
                    Company = "Yodo1",
                    Location = "Sydney",
                    Contract = "Full Time",
                    Salary = "yes",
                    Experience = "2–5 years exp",
                    LogoPath = @"\01_MainMenu\Medias\yodo1.jpg"
                },

                new Job
                {
                    Title = "Gaming Media Buyer Internship",
                    Company = "Hurrah.media",
                    Location = "Sydney",
                    Contract = "Internship",
                    Salary = "Rieng",
                    Experience = "Junior (10+ years)",
                    LogoPath = @"\01_MainMenu\Medias\hurrah.jpg"
                },

                new Job
                {
                    Title = "Mobile Market Analyst Assistant",
                    Company = "Ubisoft",
                    Location = "Sydney",
                    Contract = "Internship",
                    Salary = "Friends and good moments",
                    Experience = "Entry (0-1 years) and 2+ years of team management",
                    LogoPath = @"\01_MainMenu\Medias\ubisoft.png"
                },

                new Job
                {
                    Title = "Head of Asia Pacific Public Policy & Government Relations",
                    Company = "Discord",
                    Location = "Sydney",
                    Contract = "Full Time",
                    Salary = "Don't be silly",
                    Experience = "34+ years",
                    LogoPath = @"\01_MainMenu\Medias\discord.png"
                },

                new Job
                {
                    Title = "Social and Content Marketing Manager",
                    Company = "Amazon Games",
                    Location = "Sydney",
                    Contract = "Full Time, crunch, burnouts, salade tomate oignon",
                    Salary = "Salawhat?",
                    Experience = "Whatever, you'll be a slave anyway",
                    LogoPath = @"\01_MainMenu\Medias\amazon.png"
                },

                new Job
                {
                    Title = "Marketing trainee",
                    Company = "Ubisoft",
                    Location = "Sydney",
                    Contract = "Internship",
                    Salary = "As usual",
                    Experience = "6 years + 2 AAA games released",
                    LogoPath = @"\01_MainMenu\Medias\ubisoft.png"
                },

                new Job
                {
                    Title = "Lead Sales Manager",
                    Company = "Yodo1",
                    Location = "Sydney",
                    Contract = "Internship",
                    Salary = "Visibility",
                    Experience = "3 years but freshly graduated",
                    LogoPath = @"\01_MainMenu\Medias\yodo1.jpg"
                },

                new Job
                {
                    Title = "Manager of your ideal society",
                    Company = "6th Republic",
                    Location = "Everywhere",
                    Contract = "Equity",
                    Salary = "Fair and for all",
                    Experience = "Already burnt a few cop cars and 6+ months in ZAD",
                    LogoPath = @"\01_MainMenu\Medias\repu.png"
                }
            };

            return jobs;
        }

        #region LINKS

        public static bool AllLinksOpened { get; private set; } = false;

        private static int _linkIndex = 0;
        public static string GetCurrentLink()
        {
            //if links remain
            if (!AllLinksOpened)
            {
                //get link to open
                string link = _getLinks()[_linkIndex];

                //increment index
                _linkIndex++;

                //check if it was the last link to open
                if(_linkIndex == _getLinks().Count)
                    AllLinksOpened = true;

                return link;
            }
            else return "";
        }

        private static List<string> _getLinks()
        {
            string exePath = System.Environment.ProcessPath ?? "";
            string exeFolderPath = System.IO.Path.GetDirectoryName(exePath) ?? "";

            return new List<string>
            {
                @"https://hitmarker.net/jobs/ubisoft-mobile-market-analyst-assistant---internship-6-months-january-2024-2362139", //Ubi intern
                @"https://apply.jobadder.com/17832/554771/ae36uuatmy3utlcotwivwhfcw4?site=au6&show=details&utm_source=adzuna&utm_medium=adzuna&cmpid=1000-891", //animal care
                @"https://scontent-cdg4-2.xx.fbcdn.net/v/t1.18169-9/268561_120575838033490_1598552_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=9b3078&_nc_ohc=HfwmmfpvoZsAX-B3DA5&_nc_oc=AQnvCb8FTTR3rkcwy2cGZsA4-OAkFFdwdAd3bP0j-u7oeLhBxRKg35Y-GskWpeBL8oU&_nc_ht=scontent-cdg4-2.xx&oh=00_AfD6NYVMwDKIo2sI3KMIXweEVzA43RCQ-DdZLgSL-DQs-w&oe=6598FFB7", //flamby
                @"https://www.youtube.com/watch?v=uQHvjCyhrWs", //pingouin
                @"https://www.youtube.com/watch?v=SvpZMjcjo_g&ab_channel=Lorie", //lorie
                System.IO.Path.Combine(exeFolderPath, @"01_MainMenu\Medias\fb.png"), //montage fb
                @"https://www.youtube.com/watch?v=NCV2YZOffJM&ab_channel=MythSyzer", //myth syzer
                @""
            };
        }
        #endregion

    }
}
