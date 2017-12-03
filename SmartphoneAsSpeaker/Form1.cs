using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartphoneAsSpeaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string getLocalIp()
        {
            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
            foreach(IPAddress addr in localIPs)
            {
                if (addr.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork) return addr.ToString();
            }
            return "error";
        }
        public static bool isInNetwork()
        {
            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
            foreach(IPAddress adress in localIPs){
                if (adress.ToString() == "::1") return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (isInNetwork())
            {
                string adress = getLocalIp();
                Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                picQRcode.Image = qrcode.Draw(adress, 20);
            }
            else MessageBox.Show("Computer isn't in any network");
        }
    }
}
