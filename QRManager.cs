using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QRCoder;

namespace CCWFA
{
    class QRManager
    {
        public static string GenerateInfo(string name, string thanks)
        {
            string result = "#" + name + "*" + thanks;
            return result;
        }

        public static string GenerateInfo(string name, string thanks, out Bitmap QrBitmap)
        {
            string text = GenerateInfo(name, thanks);

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            QrBitmap = qrCode.GetGraphic(5);

            return text;
        }
    }
}
