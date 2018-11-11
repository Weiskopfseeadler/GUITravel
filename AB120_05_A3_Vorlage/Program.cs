using System;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Windows.Media.Imaging;

namespace AB120_05_A3_Vorlage
{
    public class Program
    {

        public static byte[] BytesFromPath(string Path)
        {
            byte[] b = File.ReadAllBytes(Path);
            return b;
        }

        public static BitmapImage BitmapImageFromBytes(byte[] bytes)
        {
            BitmapImage image = null;
            MemoryStream stream = null;
            try
            {
                if (bytes != null)
                {
                    stream = new MemoryStream(bytes);
                    stream.Seek(0, SeekOrigin.Begin);
                    System.Drawing.Image img = System.Drawing.Image.FromStream(stream);
                    image = new BitmapImage();
                    image.BeginInit();
                    MemoryStream ms = new MemoryStream();
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                    ms.Seek(0, SeekOrigin.Begin);
                    image.StreamSource = ms;
                    image.StreamSource.Seek(0, SeekOrigin.Begin);
                    image.EndInit();
                }
                else
                {
                    stream = new MemoryStream(0);
                    image = new BitmapImage();
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                stream.Close();
                stream.Dispose();
            }
            return image;
        }
    }
}