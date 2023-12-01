﻿using System;
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
        public JobCtrl()
        {
            InitializeComponent();
        }

        public JobCtrl(Job job)
        {
            InitializeComponent();

            Title.Content = job.Title;
            Location.Content = job.Location;
            Salary.Content = job.Salary;
            Contract.Content = job.Contract;
            Experience.Content = job.Experience;
            Company.Content = job.Company;
        }
    }
}
