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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JobFinder._01_MainMenu
{
    /// <summary>
    /// Interaction logic for MainMenuCtrl.xaml
    /// </summary>
    public partial class MainMenuCtrl : UserControl
    {
        public MainWindow? ParentWindow { get; set; } = null;

        public MainMenuCtrl()
        {
            InitializeComponent();

            MainGrid.Opacity = 0;

            DoubleAnimation anim = new DoubleAnimation
            {
                From = 0,
                To = 1,
                Duration = new Duration(TimeSpan.FromSeconds(3)),
                AutoReverse = false,
                BeginTime = TimeSpan.FromSeconds(2)
            };

            MainGrid.BeginAnimation(OpacityProperty, anim);

            InitializeJobsList();

            InitializeComboBoxes();
        }

        private void InitializeJobsList()
        {
            JobsGrid.RowDefinitions.Clear();

            var jobs = Data.GetJobs();

            jobs.ForEach(job =>
            {
                //create new row
                JobsGrid.RowDefinitions.Add(new RowDefinition());

                //instanciate job control
                var jobCtrl = new JobCtrl(job);
                //add control to grid
                JobsGrid.Children.Add(jobCtrl);
                //map control to row
                Grid.SetRow(jobCtrl, JobsGrid.RowDefinitions.Count - 1);
            });
        }

        private void InitializeComboBoxes()
        {
            LocationCB.Items.Clear();
            LocationCB.ItemsSource = Data.GetLocations();

            SalaryCB.Items.Clear();
            SalaryCB.ItemsSource = Data.GetSalaries();

            ContractCB.Items.Clear();
            ContractCB.ItemsSource = Data.GetContracts();

            ExperienceCB.Items.Clear();
            ExperienceCB.ItemsSource = Data.GetExperiences();
        }
    }
}
