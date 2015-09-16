using _GZFramework.Demo.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace _GZFramework.Demo.Library.MyClass
{
    public class LoadUIImage
    {
        private static string _ImagesPath;
        private static string ImagesPath
        {
            get
            {
                if (String.IsNullOrEmpty(_ImagesPath))
                    _ImagesPath = String.Format(@"{0}\images\", Globals.BaseDirectory);
                return _ImagesPath;
            }
        }

        /// <summary>
        /// 尺寸类型
        /// </summary>
        private enum ImageType
        {
            /// <summary>
            /// 16x16尺寸
            /// </summary>
            Small,
            /// <summary>
            /// 32x32尺寸
            /// </summary>
            Normal,
            /// <summary>
            /// 64x64尺寸
            /// </summary>
            Large
        }
        /// <summary>
        /// 获得尺寸后缀
        /// </summary>
        /// <param name="T"></param>
        /// <returns></returns>
        private static string GetImageFileNameEx(ImageType T, out int ImageSize)
        {
            ImageSize = 0;
            switch (T)
            {
                case ImageType.Small:
                    ImageSize = 16;
                    break;
                case ImageType.Normal:
                    ImageSize = 32;
                    break;
                case ImageType.Large:
                    ImageSize = 64;
                    break;
            }
            return String.Format("_{0}x{0}.png", ImageSize);
        }

        /// <summary>
        /// 获得图片路径
        /// </summary>
        /// <param name="imgFileName"></param>
        /// <param name="IT"></param>
        /// <returns></returns>
        private static Image LoadImage(string imgFileName, ImageType IT)
        {
            int ImageSize = 0;
            string FileName = imgFileName + GetImageFileNameEx(IT, out ImageSize);
            string file = ImagesPath + FileName;

            return ImageLibrary.LoadImageByFileEx(file, ImageSize);
        }


        /// <summary>
        /// 加载NavBarControl Group图标
        /// </summary>
        /// <param name="SimpleImgFileName"></param>
        /// <returns></returns>
        public static Image LoadNavBarImage_Group(string SimpleImgFileName)
        {
            return LoadImage(SimpleImgFileName, ImageType.Small);
        }
        /// <summary>
        /// 加载NavBarControl Item图标
        /// </summary>
        /// <param name="SimpleImgFileName"></param>
        /// <returns></returns>
        public static Image LoadNavBarImage_Item(string SimpleImgFileName)
        {
            return LoadImage(SimpleImgFileName, ImageType.Small);
        }


        /// <summary>
        /// 加载Ribbon BarItem操作组图标
        /// </summary>
        /// <param name="SimpleImgFileName"></param>
        /// <returns></returns>
        public static Image LoadRibbonControlLargeGlyph_BarItem(string SimpleImgFileName)
        {
            return LoadImage(SimpleImgFileName, ImageType.Normal);
        }

        /// <summary>
        /// 加载Ribbon BarItem操作组图标
        /// </summary>
        /// <param name="SimpleImgFileName"></param>
        /// <returns></returns>
        public static Image LoadRibbonControlGlyph_BarItem(string SimpleImgFileName)
        {
            return LoadImage(SimpleImgFileName, ImageType.Small);
        }

        /// <summary>
        /// 加载MDI TagPag图标
        /// </summary>
        /// <param name="SimpleImgFileName"></param>
        /// <returns></returns>
        public static Image LoadMDIImg_TabPag(string SimpleImgFileName)
        {
            return LoadImage(SimpleImgFileName, ImageType.Small);
        }

        /// <summary>
        /// 加载ChildForm ICO
        /// </summary>
        /// <param name="SimpleImgFileName"></param>
        /// <returns></returns>
        public static Icon LoadFormIcon(string SimpleImgFileName)
        {
            Bitmap bmp = new Bitmap(LoadImage(SimpleImgFileName, ImageType.Small));
            return Icon.FromHandle(bmp.GetHicon());

        }

        /// <summary>
        /// 加载模块功能图标
        /// </summary>
        /// <param name="SimpleImgFileName"></param>
        /// <returns></returns>
        public static Image LoadFunctionButtonImg(string SimpleImgFileName)
        {
            return LoadImage(SimpleImgFileName, ImageType.Large);
        }

    }
}
