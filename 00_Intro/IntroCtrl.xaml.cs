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

namespace JobFinder._00_Intro
{
    /// <summary>
    /// Interaction logic for IntroCtrl.xaml
    /// </summary>
    public partial class IntroCtrl : UserControl
    {
        public MainWindow? ParentWindow { get; set; } = null;

        protected DoubleAnimation _anim;

        public IntroCtrl()
        {
            InitializeComponent();

            //set the fade in/out animation
            _anim = new DoubleAnimation
            {
                From = 0,
                To = 1,
                Duration = new Duration(TimeSpan.FromSeconds(2)),
                AutoReverse = true,
                BeginTime = TimeSpan.FromSeconds(1)
            };

            //set event for image transition
            _anim.Completed += Anim_Completed1;

            //begin first anim
            MainImg.Source = new BitmapImage(new Uri(@"/00_Intro/Medias/UE.jpg", UriKind.Relative));
            MainImg.BeginAnimation(OpacityProperty, _anim);

        }

        private void Anim_Completed1(object? sender, EventArgs e)
        {
            //stop event
            _anim.Completed -= Anim_Completed1;
            //set event for next step
            _anim.Completed += Anim_Completed2;

            //begin second anim
            MainImg.Source = new BitmapImage(new Uri(@"/00_Intro/Medias/faux.png", UriKind.Relative));
            MainImg.BeginAnimation(OpacityProperty, _anim);
        }

        private void Anim_Completed2(object? sender, EventArgs e)
        {
            _anim.Completed -= Anim_Completed2;

            //next step
            ParentWindow?.Run01();
        }
    }
}
