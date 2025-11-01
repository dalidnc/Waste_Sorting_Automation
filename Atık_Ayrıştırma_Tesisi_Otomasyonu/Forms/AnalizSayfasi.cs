using S7.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atık_Ayrıştırma_Tesisi_Otomasyonu.Forms
{
    public partial class AnalizSayfasi : Form
    {
        private Plc plc;
        private bool Connected;

        public AnalizSayfasi()
        {
            InitializeComponent();
            plc = new Plc(CpuType.S71200, "192.168.1.100", 0, 1);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnMetalAtikSayisi_Click(object sender, EventArgs e)
        {
            plc.Write("DB2.DBX1.4", true);
            plc.Write("DB2.DBX1.4", false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            object result = plc.Read("DB11.DBD0");
            object cam = plc.Read("DB11.DBD4");
            object Plastik = plc.Read("DB11.DBD8");
            object Kagit = plc.Read("DB11.DBD12");
            object ToplamAtikSayisi = plc.Read("DB11.DBD16");


            if (result != null)
            {
                int MetalAtikSayisi = Convert.ToInt32(plc.Read("DB11.DBD0"));
                int CamAtikSayisi = Convert.ToInt32(plc.Read("DB11.DBD4"));
                int PlastikSayisi = Convert.ToInt32(plc.Read("DB11.DBD8"));
                int KagitSayisi = Convert.ToInt32(plc.Read("DB11.DBD12"));
                int ToplamAtik = Convert.ToInt32(plc.Read("DB11.DBD16"));
                txtMetalAtik.Text = MetalAtikSayisi.ToString();
                txtCamAtikSayisi.Text = CamAtikSayisi.ToString();
                txtPlastikAtik.Text = PlastikSayisi.ToString();
                txtKagitKartonAtikSayisi.Text = KagitSayisi.ToString();
                txtToplamAtikSayisi.Text = ToplamAtikSayisi.ToString();



            }

        }

        private void AnalizSayfasi_Load(object sender, EventArgs e)
        {
            try
            {
                plc.Open();
                Connected = plc.IsConnected;

                if (!Connected)
                {
                    MessageBox.Show("PLC bağlantısı yok!");
                    return;
                }

                timer1.Interval = 500; // 0.5s
                timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PLC bağlantı hatası: " + ex.Message);
            }
        }

        private void btnPlastikAtikSayisi_Click(object sender, EventArgs e)
        {
            plc.Write("DB6.DBX1.3", true);
            plc.Write("DB6.DBX1.3", false);
        }

        private void btnCamAtikSayisi_Click(object sender, EventArgs e)
        {
            plc.Write("DB3.DBX1.4", true);
            plc.Write("DB3.DBX1.4", false);
        }

        private void btnKagitAtikSayisi_Click(object sender, EventArgs e)
        {
            plc.Write("DB8.DBX1.4", true);
            plc.Write("DB8.DBX1.4", false);
        }
    }
}
