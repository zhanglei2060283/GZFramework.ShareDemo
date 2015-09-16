using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace _GZFramework.Demo.Common
{
    public class ImageLibrary
    {
        /// <summary>
        /// 生成空图标
        /// </summary>
        /// <param name="Width"></param>
        /// <param name="Height"></param>
        /// <param name="Text"></param>
        /// <returns></returns>
        private static Image GenerateNullImage(int Width, int Height, string Text)
        {
            Bitmap bmp = new Bitmap(Width, Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.PaleVioletRed, new Rectangle() { X = 0, Y = 0, Height = 100, Width = 100 });

            Font font = new Font("宋体", 8);

            StringFormat sf = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            g.DrawString(Text, font, Brushes.Black, new Rectangle(0, 0, Width, Height), sf);


            return bmp;
        }

        public static Image LoadImageByFileEx(string fileName, int ImageSize)
        {
            if (File.Exists(fileName))
                return Image.FromFile(fileName);
            else
            {
                string str = String.Format("No {0}", System.IO.Path.GetFileNameWithoutExtension(fileName));
                return GenerateNullImage(ImageSize, ImageSize, String.Format("No {0}", str));
            }
        }

        public static Image LoadImageByFile(string file)
        {
            if (File.Exists(file))
                return Image.FromFile(file);
            else
                return null;
        }


        public static Bitmap LoadBitmapByFile(string file)
        {
            if (File.Exists(file))
                return new Bitmap(Bitmap.FromFile(file));
            else
                return null;
        }
    }
}
