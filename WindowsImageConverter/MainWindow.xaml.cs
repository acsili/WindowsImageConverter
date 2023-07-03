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

namespace WindowsImageConverter
{ 
    public partial class MainWindow : Window
    {
        MyImageConverter converter = new MyImageConverter();
        public MainWindow()
        {
            InitializeComponent();
            FiletypeSetter.SetFiletypesInComboBox(ComboBoxTo);
        }

        private void ButtonGetImagePath_Click(object sender, RoutedEventArgs e)
        {
            var pathGetter = new PathChooser();
            converter.PathFrom = pathGetter.GetImagePath();
            LabelPathFrom.Content = converter.PathFrom;
        }

        private void ButtonSetNewImagePath_Click(object sender, RoutedEventArgs e)
        {
            var pathGetter = new PathChooser();
            converter.PathTo = pathGetter.SetImagePath();
            LabelPathTo.Content = converter.PathTo;
        }
        private void ComboBoxTo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FiletypeSetter.ChooseFiletypeInComboBox(ComboBoxTo, converter);
        }

        private void ButtonConvert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                converter.ConvertFromPngToJpg(converter.PathFrom, converter.PathTo);
                MessageBox.Show("Done.");
            }
            catch
            {
                MessageBox.Show("Error! Try again.");
            }
        }

    }
}
