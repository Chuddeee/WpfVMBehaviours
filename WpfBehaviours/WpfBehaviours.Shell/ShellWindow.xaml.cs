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
using Microsoft.Practices.Unity;
using WpfBehaviours.ControlSet.Windows.Controls;

namespace WpfBehaviours.Shell
{
    public partial class ShellWindow : Window
    {
        // 4 резолвится ShellViewModel goto ShellViewModel ctor
        public ShellWindow
            (
                [Dependency]ShellViewModel viewModel
            )
        {
            // 6 инициализированную VM назначаем в качестве контекста данных
            this.DataContext = viewModel;
            InitializeComponent();
        }
    }
}
