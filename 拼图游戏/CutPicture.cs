﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace 拼图游戏
{
    class CutPicture
    {
        public static string PicturePath = "";
        public static List<Bitmap> BitMapList = null;
        ///<summary>
        ///保存照片到根目录的Pictures文件夹下
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <param name="iWidth">调整的宽</param>
        /// <param name="iHeight">调整的高</param>
        /// <returns></returns>
        public static Image Resize (string path,int iWidth,int iHeight)
        {
            Image thumbnail = null;
            try
            {
                var img = Image.FromFile(path);
                thumbnail = img.GetThumbnailImage(iWidth, iHeight, null, IntPtr.Zero);
                thumbnail.Save(Application.StartupPath.ToString() + "\\Picture\\img.jpeg");
            }
            catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            return thumbnail;
        }
        ///<summary>
        ///剪切图片
        /// </summary>
        /// <param name="b">图片</param>
        /// <param name="StartX">x坐标</param>
        /// <param name="StartY">y坐标</param>
        /// <param name="iWidth">宽</param>
        /// <param name="iHeight">高</param>
        /// <returns></returns>
        public static Bitmap Cut (Image b,int StartX,int StartY, int iWidth,int iHeight)
        {
            if (b == null)
            {
                return null;
            }
            int w = b.Width;
            int h = b.Height;
            if (StartX >= w || StartY >= h)
            {
                return null;
            }
            if(StartX+iWidth>w)
            {
                iWidth = w - StartX;
            }
            if(StartY+iHeight>h)
            {
                iHeight = h - StartY;
            }
            try
            {
                Bitmap bmpOut = new Bitmap(iWidth, iHeight, PixelFormat.Format24bppRgb);
                Graphics g = Graphics.FromImage(bmpOut);
                g.DrawImage(b, new Rectangle(0, 0, iWidth, iHeight), new Rectangle(StartX, StartY, iWidth, iHeight), GraphicsUnit.Pixel);
                g.Dispose();
                return bmpOut;
            }
            catch
            {
                return null;
            }
        }
    }
}
