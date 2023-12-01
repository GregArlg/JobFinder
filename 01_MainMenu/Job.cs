using System;
using System.Collections.Generic;
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

        public Job() { }
    }
}
