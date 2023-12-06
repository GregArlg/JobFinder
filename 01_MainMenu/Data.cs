using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinder._01_MainMenu
{
    static class Data
    {
        public static List<string> GetLocations()
        {
            return new List<string>
            {
                "Sydney",
                "Sydney",
                "Sydney",
                "Sydney",
                "Sydney",
                "Sydney",
                "Sydney",
                "Sydney",
                "Sydney",
                "Sydney",
                "Sydney",
                "Sydney",
                "Sydney",
                "Sydney",
                "Sydney",
                "Sydney",
                "Sydney",
                "Sydney",
                "Sydney",
                "Sydney"
            };
        }

        public static List<string> GetSalaries()
        {
            return new List<string>
            {
                "Rieng",
                "0",
                "Visibility",
                "tkt",
                "Friends and good moments",
                "yes",
                "Don't be silly",
                "10$ if you manage a whole season"
            };
        }

        public static List<string> GetContracts()
        {
            return new List<string>
            {
                "Full Time",
                "Part Time",
                "Contract",
                "Freelance",
                "Internship"
            };
        }

        public static List<string> GetExperiences()
        {
            return new List<string>
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
            List<Job> jobs = new List<Job>();

            jobs.Add(new Job
            {
                Title = "Game Growth Specialist",
                Company = "Yodo1",
                Location = "Sydney",
                Contract = "Full Time",
                Salary = "yes",
                Experience = "2–5 years exp"
            });

            jobs.Add(new Job
            {
                Title = "Gaming Media Buyer Internship",
                Company = "Hurrah.media",
                Location = "Sydney",
                Contract = "Internship",
                Salary = "Rieng",
                Experience = "10$ if you manage a whole season"
            });

            jobs.Add(new Job
            {
                Title = "Head of Asia Pacific Public Policy & Government Relations",
                Company = "Discord",
                Location = "Sydney",
                Contract = "Full Time",
                Salary = "Don't be silly",
                Experience = "34+ years"
            });

            jobs.Add(new Job
            {
                Title = "Marketing trainee",
                Company = "Ubisoft",
                Location = "Sydney",
                Contract = "Internship",
                Salary = "tkt",
                Experience = "6 years + 2 AAA games released"
            });

            jobs.Add(new Job
            {
                Title = "Lead Sales Manager",
                Company = "Yodo1",
                Location = "Sydney",
                Contract = "Internship",
                Salary = "Visibility",
                Experience = "3 years but freshly graduated"
            });

            return jobs;
        }
    }
}
