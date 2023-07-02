using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WindowsImageConverter
{
    internal class FiletypeSetter
    {
        public static void SetFiletypesInComboBox(ComboBox comboBox)
        {
            comboBox.Items.Add("png");
            comboBox.Items.Add("jpg");
            comboBox.Items.Add("gif");
            comboBox.Items.Add("tiff");
            comboBox.Items.Add("bmp");
        }
        public static void ChooseFiletypeInComboBox(ComboBox comboBox, MyImageConverter converter)
        {
            if (comboBox.SelectedIndex == 0)
            {
                converter.Format = ImageFormat.Png;
                converter.StringFormat = "png";
            }
            else if (comboBox.SelectedIndex == 1)
            {
                converter.Format = ImageFormat.Jpeg;
                converter.StringFormat = "jpg";
            }
            else if (comboBox.SelectedIndex == 2)
            {
                converter.Format = ImageFormat.Gif;
                converter.StringFormat = "gif";
            }
            else if (comboBox.SelectedIndex == 3)
            {
                converter.Format = ImageFormat.Tiff;
                converter.StringFormat = "tiff";
            }
            else if (comboBox.SelectedIndex == 4)
            {
                converter.Format = ImageFormat.Bmp;
                converter.StringFormat = "bmp";
            }
        }
    }
}
