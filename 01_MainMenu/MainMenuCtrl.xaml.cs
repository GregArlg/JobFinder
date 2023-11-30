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

        }
    }
}
