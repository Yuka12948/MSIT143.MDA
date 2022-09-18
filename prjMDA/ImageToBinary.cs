using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMDA
{
    class ImageToBinary
    {
        public Image ConvertToImage(byte[] picBinary)
        {

            Image image = null;

            using (MemoryStream me = new MemoryStream(picBinary))
            {
                image = Image.FromStream(me);
            }
            return image;
        }

        public byte[] ConvertToByte(Image image)
        {
            if (image == null) { return null; }
            try
            {
                using (Bitmap bitmap = new Bitmap(image))
                {
                    using (var ms = new MemoryStream())
                    {
                        bitmap.Save(ms, image.RawFormat);
                        return ms.ToArray();
                    }
                }
            }
            finally
            {
                if (image != null)
                {
                    image.Dispose();
                    image = null;
                }
            }


        }
    }
}
