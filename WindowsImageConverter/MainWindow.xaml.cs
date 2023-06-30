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

namespace WindowsImageConverter
{ 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonGetImagePath_Click(object sender, RoutedEventArgs e)
        {
            var pathGetter = new PathChooser();
            var myImageConverter = new MyImageConverter();
            myImageConverter.ConvertFromPngToJpg(pathGetter.GetImagePath(), pathGetter.SetImagePath());
        }

        private void ButtonSetNewImagePath_Click(object sender, RoutedEventArgs e)
        {
            /*var pathGetter = new PathChooser();
            var myImageConverter = new MyImageConverter();
            myImageConverter.ConvertFromPngToJpg(pathGetter.SetImagePath());*/
        }
    }
}
