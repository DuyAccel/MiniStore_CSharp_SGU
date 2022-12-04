using AForge.Video.DirectShow;
using MiniStore.Costumized;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace MiniStore.ExtendedFeatures
{
    public class Barcode
    {
        private FilterInfoCollection filter;
        private VideoCaptureDevice device;
        private PictureBox pictureBox;
        private CostumTextbox txt_code;
        private CostumTextbox Quantity_txt;
        
        public Barcode()
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        }

        public static string GenerateBarcode(string code)
        {
            BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
            string working = Environment.CurrentDirectory;
            string path = Directory.GetParent(working).Parent.FullName;
            writer.Write(code).Save(path + @"\static\Barcode\" + code + ".png", ImageFormat.Png);
            return path + @"\static\Barcode\" + code + ".png";
        }
        public void Scan(PictureBox pictureBox, CostumTextbox txt_code, CostumTextbox Quantity_txt)
        {
            device = new VideoCaptureDevice(filter[0].MonikerString);
            this.txt_code = txt_code;
            this.pictureBox = pictureBox;
            this.Quantity_txt = Quantity_txt;
            device.NewFrame += Device_NewFrame;
            device.Start();
        }

        private void Device_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result  = reader.Decode(bitmap);
            if (result != null)
            { 
                txt_code.Texts = result.ToString();
                Quantity_txt.Texts = "1";
            }
            pictureBox.Image = bitmap;
        }

        public void StopScan()
        {
            if (device != null)
            {
                if (device.IsRunning)
                {
                    device.Stop();
                }
            }
        }
    }
    
}
