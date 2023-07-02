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
            FiletypeSetter.SetFiletypesInComboBox(ComboBoxFrom);
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

        private void ComboBoxFrom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FiletypeSetter.ChooseFiletypeInComboBox(ComboBoxFrom, converter);
        }

        private void ComboBoxTo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ButtonConvert_Click(object sender, RoutedEventArgs e)
        {
            converter.ConvertFromPngToJpg(converter.PathFrom, converter.PathTo);
            MessageBox.Show("done");
        }

        private void SliderQuality_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int value = Convert.ToInt32(e.NewValue);
            string msg = String.Format("Value: {0}", value);
            TextBlockQuality.Text = msg;
            converter.ImageQuality = value;
        }
    }
}
