using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WindowsImageConverter
{
    internal class PathChooser
    {
        /// <summary>
        /// Method opens PNG, JPG image using OpenFileDialog
        /// </summary>
        public string GetImagePath()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Multiselect = true,
                Filter = "Image files (*.png;*.jpg;*.gif;*.tiff;*.bmp)|*.png;*.jpg;*.gif;*.tiff;*.bmp",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            if (openFileDialog.ShowDialog() == true)
            {
                return openFileDialog.FileName;
            }
            return null;
        }
        public string SetImagePath()
        {
            using var dialog = new System.Windows.Forms.FolderBrowserDialog
            {
                Description = "Time to select a folder",
                UseDescriptionForTitle = true,
                SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + Path.DirectorySeparatorChar,
                ShowNewFolderButton = true
            };

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return dialog.SelectedPath;
            }
            return null;
        }

    }
}
