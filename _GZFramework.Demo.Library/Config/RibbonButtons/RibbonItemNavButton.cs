using _GZFramework.Demo.Library.MyClass;
using GZFramework.UI.Dev;
using GZFramework.UI.Dev.RibbonButton;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace _GZFramework.Demo.Library.Config.RibbonButtons
{
    public class RibbonItemNavButton : RibbonItemButtonBase, IDisposable
    {
        private Image img = null;
        public string ImgFileName { get; set; }


        public override Image LoadImage
        {
            get
            {
                if (img == null)
                    img = LoadUIImage.LoadRibbonControlGlyph_BarItem(ImgFileName);

                return img;
            }
        }
        public void Dispose()
        {
            if (img != null)
            {
                img.Dispose();
                img = null;
            }
        }
    }
}
