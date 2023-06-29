using System;
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
        public void VaryQualityLevel()
        {
            string path = Console.ReadLine();

            Bitmap bitmap = new Bitmap(path);
            ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

            System.Drawing.Imaging.Encoder encoder = System.Drawing.Imaging.Encoder.Quality;

            EncoderParameters encoderParameters = new EncoderParameters(1);

            EncoderParameter myEncoderParameter = new EncoderParameter(encoder, 50L);
            encoderParameters.Param[0] = myEncoderParameter;
            bitmap.Save(@"D:\TestPhotoQualityFifty.jpg", jpgEncoder, encoderParameters);

            myEncoderParameter = new EncoderParameter(encoder, 100L);
            encoderParameters.Param[0] = myEncoderParameter;
            bitmap.Save(@"D:\TestPhotoQualityHundred.jpg", jpgEncoder, encoderParameters);

            myEncoderParameter = new EncoderParameter(encoder, 0L);
            encoderParameters.Param[0] = myEncoderParameter;
            bitmap.Save(@"D:\TestPhotoQualityZero.jpg", jpgEncoder, encoderParameters);

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
