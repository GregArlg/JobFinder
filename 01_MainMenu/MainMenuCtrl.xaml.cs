using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
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

        public ObservableCollection<string> Locations { get; set; } = new ObservableCollection<string>();
        public ObservableCollection<string> Salaries { get; set; } = new ObservableCollection<string>();
        public ObservableCollection<string> Contracts { get; set; } = new ObservableCollection<string>();
        public ObservableCollection<string> Experiences { get; set; } = new ObservableCollection<string>();

        private string _exeFolderPath;

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

            string exePath = System.Environment.ProcessPath ?? "";
            _exeFolderPath = System.IO.Path.GetDirectoryName(exePath) ?? "";
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
            LocationCB.DataContext = this;
            Locations = Data.GetLocations();
            LocationCB.ItemsSource = Locations;

            SalaryCB.DataContext = this;
            Salaries = Data.GetSalaries();
            SalaryCB.ItemsSource = Salaries;

            ContractCB.DataContext = this;
            Contracts = Data.GetContracts();
            ContractCB.ItemsSource = Contracts;

            ExperienceCB.DataContext = this;
            Experiences = Data.GetExperiences();
            ExperienceCB.ItemsSource = Experiences;
        }

        private void PlaySound(string relativeSoundPath)
        {
            string soundPath = System.IO.Path.Combine(_exeFolderPath, relativeSoundPath);

            SoundPlayer player = new SoundPlayer(soundPath);
            player.Load();
            player.Play();

            player.Dispose();
        }

        private bool _toggleContract = true;
        private void ContractCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!Data.AllLinksOpened)
            {
                if (ContractCB.SelectedItem.ToString() != "Internship")
                {
                    ContractCB.SelectedItem = "Internship";

                    if (_toggleContract)
                    {
                        PlaySound(@"01_MainMenu\Medias\calme_toi.wav");
                    }
                    else
                    {
                        PlaySound(@"01_MainMenu\Medias\redescend.wav");
                    }
                    _toggleContract = !_toggleContract;
                } 
            }
        }

        private void SalaryCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PlaySound(@"01_MainMenu\Medias\coin_sound.wav");
        }

        private void LocationCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PlaySound(@"01_MainMenu\Medias\wave.wav");
        }

        private bool _onceOnly = true;

        private void RiddleBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Data.AllLinksOpened)
            {
                if (_onceOnly)
                {
                    //on the first time we click on the img
                    //we add elements to comboboxes
                    //and show the message

                    _onceOnly = false;

                    List<string> content = new List<string>();

                    Locations.Insert(150, "Manly");

                    Salaries.Insert(8, "100k+");

                    Contracts.Add("Full Time Hybrid");

                    Experiences.Add("NOT JUNIOR");

                    MessageBox.Show(
                        "let's take it from the start.\nPrecise your search.",
                        "What now?", MessageBoxButton.OK, MessageBoxImage.Question);
                }
                else
                {
                    //if it is not the first time we click on the image
                    //and all wanted values are selected

                    if (
                    (string)LocationCB.SelectedItem == "Manly" &&
                    (string)SalaryCB.SelectedItem == "100k+" &&
                    (string)ContractCB.SelectedItem == "Full Time Hybrid" &&
                    (string)ExperienceCB.SelectedItem == "NOT JUNIOR")
                    {
                        //open slideshow !
                        bool debug = true;
                    }
                    else
                    {
                        //else show message again
                        MessageBox.Show(
                            "let's take it from the start.\nPrecise your search.",
                            "What now?", MessageBoxButton.OK, MessageBoxImage.Question);
                    }
                }
            }

        }
        
    }
}
