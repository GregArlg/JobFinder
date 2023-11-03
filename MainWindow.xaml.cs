using JobFinder._00_Intro;
using JobFinder._01_MainMenu;
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

namespace JobFinder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Run00();
        }

        public void Run00()
        {
            IntroCtrl ctrl = new IntroCtrl
            {
                ParentWindow = this
            };
            MainContentControl.Content = ctrl;
        }

        public void Run01()
        {
            MainMenuCtrl ctrl = new MainMenuCtrl
            {
                ParentWindow = this
            };
            MainContentControl.Content = ctrl;
        }
    }
}
