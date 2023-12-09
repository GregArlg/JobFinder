using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinder._01_MainMenu
{
    public class Job
    {
        public string Title { get; set; } = "";
        public string Company { get; set; } = "";
        public string Location { get; set; } = "";
        public string Contract { get; set; } = "";
        public string Salary { get; set; } = "";
        public string Experience { get; set; } = "";
        public string LogoPath { get; set; } = "";

        public string Link { get; set; } = "";

        public Job() { }

        public void OpenLink()
        {
            if (!string.IsNullOrWhiteSpace(Link))
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = Link,
                    UseShellExecute = true
                }); 
            }
        }

        public void OpenLink(string link)
        {
            if (!string.IsNullOrWhiteSpace(link))
            {
                Link = link;

                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = Link,
                    UseShellExecute = true
                });
            }
        }
    }
}
