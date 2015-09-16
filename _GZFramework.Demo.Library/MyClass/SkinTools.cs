using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraEditors;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace _GZFramework.Demo.Library.MyClass
{
    public class SkinTools
    {

        public static void InitSkinGallery(DevExpress.XtraBars.RibbonGalleryBarItem rgbiSkin)
        {
            new SkinTools(rgbiSkin);
        }

        /// <summary>
        /// 在Program中调用
        /// </summary>
        public static void InitOtherSkin()
        {
            //皮肤
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.Skins.SkinManager.EnableMdiFormSkins();
        }


        string defaultSkinName;//皮肤
        string defaultRbStyle;//ribboncontrol Style



        private string _xmlPath;
        string XMLPath
        {
            get
            {
                if (String.IsNullOrEmpty(_xmlPath))
                {
                    _xmlPath = Application.StartupPath + @"\Config\SkinInfo.xml";//保存有皮肤信息的XML文件
                    try
                    {
                        if (System.IO.File.Exists(_xmlPath) == false)
                        {
                            string path = _xmlPath.Substring(0, _xmlPath.LastIndexOf("\\"));
                            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

                            XMLCreate(_xmlPath);
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return _xmlPath;
            }
        }

        DevExpress.XtraBars.RibbonGalleryBarItem RgbiSkin;

        /// <summary>
        /// 构造器
        /// </summary>
        /// <param name="rgbiSkin"></param>
        SkinTools(DevExpress.XtraBars.RibbonGalleryBarItem rgbiSkin)
        {
            GetXmlSkin();//获取xml主题
            InitOtherSkin();//添加皮肤
            InitialSkin(rgbiSkin);

        }
       

        /// <summary>
        /// 加载皮肤到控件
        /// </summary>
        /// <param name="RGBISkin"></param>
        void InitialSkin(DevExpress.XtraBars.RibbonGalleryBarItem RGBISkin)
        {
            RgbiSkin = RGBISkin;
            SkinHelper.InitSkinGallery(RgbiSkin);

            UserLookAndFeel.Default.SetSkinStyle(defaultSkinName);//设置主题样式
            RgbiSkin.Caption = "主题：" + defaultSkinName;


            RgbiSkin.GalleryItemClick += rgbiSkin_GalleryItemClick;
        }
   
        /// <summary>
        /// 皮肤改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void rgbiSkin_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            try
            {

                string name = string.Empty;
                string caption = string.Empty;

                if (RgbiSkin.Gallery == null) return;
                caption = RgbiSkin.Gallery.GetCheckedItems()[0].Caption;//主题的描述
                caption = caption.Replace("主题：", "");
                //name = bsiPaintStyle.Manager.PressedLink.Item.Tag.ToString();//主题的名称
                RgbiSkin.Caption = "主题：" + caption;

                System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
                doc.Load(XMLPath);
                System.Xml.XmlNodeList nodelist = doc.SelectSingleNode("SetSkin").ChildNodes;
                foreach (System.Xml.XmlNode node in nodelist)
                {
                    System.Xml.XmlElement xe = (System.Xml.XmlElement)node;//将子节点类型转换为XmlElement类型 
                    if (xe.Name == "Skinstring")
                    {
                        xe.InnerText = caption;
                    }
                }

                doc.Save(XMLPath);
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 获得皮肤
        /// </summary>
        void GetXmlSkin()
        {
            try
            {
                XmlDocument mydoc = new XmlDocument();
                mydoc.Load(XMLPath);
                System.Xml.XmlNode ressNode = mydoc.SelectSingleNode("SetSkin");
                defaultSkinName = ressNode.SelectSingleNode("Skinstring").InnerText;
                defaultRbStyle = ressNode.SelectSingleNode("Stylestring").InnerText;
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        /// <summary>
        /// 创建XML文件
        /// </summary>
        /// <param name="filename">要将文档保存到其中的文件位置</param>
        public void XMLCreate(string filename)
        {
            XmlDocument doc = new XmlDocument();
            //建立xml定义声明
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);

            //创建根节点
            XmlElement root = doc.CreateElement("SetSkin");
            XmlElement rootone = doc.CreateElement("Skinstring");//皮肤
            XmlElement rootonestyle = doc.CreateElement("Stylestring");//皮肤

            //将one，two，插入到root节点下
            doc.AppendChild(root);
            root.AppendChild(rootone);
            root.AppendChild(rootonestyle);
            doc.Save(filename);
        }
    }
}
