﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsImageConverter
{
    internal class MyImageConverter
    {
        public string? PathFrom { get; set; }
        public string? PathTo { get; set; }
        public ImageFormat? Format { get; set; }
        public string? StringFormat { get; set; }
        private string GenerateFileName()
        {
            string letters = "qwertyuioplkjhgfdsazxcvbnm";
            string digits = "1234567890";
            string fileName = "";
            for (int i = 0; i < 30; i++)
            {
                Random random = new Random();   
                int what = random.Next(2);
                if (what == 1)
                {
                    fileName += letters[random.Next(letters.Length)];
                }
                else
                {
                    fileName += digits[random.Next(digits.Length)];
                }
            }
            return fileName + "." + StringFormat;
        }
        async public void ConvertFromPngToJpg(string pathFrom, string pathTo)
        {
            Bitmap bitmap = new Bitmap(pathFrom);
            ImageCodecInfo imageEncoder = GetEncoder(Format);

            System.Drawing.Imaging.Encoder encoder = System.Drawing.Imaging.Encoder.Quality;

            EncoderParameters encoderParameters = new EncoderParameters(1);

            EncoderParameter myEncoderParameter = new EncoderParameter(encoder, 100L);
            encoderParameters.Param[0] = myEncoderParameter;
            string newFileName = pathTo + "\\" + GenerateFileName();
            bitmap.Save(newFileName, imageEncoder, encoderParameters);
            //await Task.Run(() => bitmap.Save(newFileName, imageEncoder, encoderParameters));
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
    
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }
    }
}
