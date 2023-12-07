using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JobFinder._01_MainMenu
{
    /// <summary>
    /// Interaction logic for JobCtrl.xaml
    /// </summary>
    public partial class JobCtrl : UserControl
    {
        private Job _job;

        public JobCtrl()
        {
            InitializeComponent();

            _job = new Job();
        }

        public JobCtrl(Job job)
        {
            InitializeComponent();

            _job = job;

            Title.Content = _job.Title;
            Location.Content = _job.Location;
            Salary.Content = _job.Salary;
            Contract.Content = _job.Contract;
            Experience.Content = _job.Experience;
            Company.Content = _job.Company;
        }

        private void Title_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _job.OpenLink();
        }
    }
}
