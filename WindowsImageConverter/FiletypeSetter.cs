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
        }
        public static void ChooseFiletypeInComboBox(ComboBox comboBox, MyImageConverter converter)
        {
            if (comboBox.SelectedIndex == 0)
            {
                converter.Format = ImageFormat.Png;
            }
            else if (comboBox.SelectedIndex == 1)
            {
                converter.Format = ImageFormat.Jpeg;
            }
        }
    }
}
