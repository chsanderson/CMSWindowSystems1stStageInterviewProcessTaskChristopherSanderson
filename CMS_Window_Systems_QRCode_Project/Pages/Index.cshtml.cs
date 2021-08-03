using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using QRCoder;

namespace CMS_Window_Systems_QRCode_Project.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        [HttpPost]
        private IActionResult GenerateQrCodeURi(string txt_barcodeInput)
        {
            string itemKey = txt_barcodeInput.Substring(0, 8);
            string jobKey = txt_barcodeInput.Substring(9, 11);
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(txt_barcodeInput, QRCodeGenerator.ECCLevel.Q);
            QRCode qRCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qRCode.GetGraphic(20);
            return ViewResult(BitmapToBytes(qrCodeImage));
            /*
            string itemKey = txt_barcodeInput.Substring(0, 8);
            string jobKey = txt_barcodeInput.Substring(9, 11);
            return string.Format(
                    AuthenticatorUriFormat,
                    _urlEncoder.Encode("https://www.mywebsite.com"),
                    _urlEncoder.Encode(itemKey), jobKey);*/
        }
    }
}
