using S7.Net;
using System;
using System.Windows.Forms;

namespace Atık_Ayrıştırma_Tesisi_Otomasyonu.Forms
{
    public partial class PistonControl : Form
    {
        private Plc plc;
        private bool Connected;

        public PistonControl()
        {
            InitializeComponent();
            plc = new Plc(CpuType.S71200, "192.168.1.100", 0, 1);
        }

        private void PistonControl_Load(object sender, EventArgs e)
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

                timer1.Interval = 500; // 0.5 saniye
                timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PLC bağlantı hatası: " + ex.Message);
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Connected)
            {
                try
                {
                    bool MetalpistonDurum = (bool)plc.Read("DB2.DBX0.3");
                    bool PlastikPistonDurum = (bool)plc.Read("DB6.DBX0.3");
                    bool CamPistonDurum = (bool)plc.Read("DB3.DBX0.3");
                    bool KagitPistonDurum = (bool)plc.Read("DB8.DBX0.3");


                    if (MetalpistonDurum)
                    {
                        pBMetalPistonCalisiyorLight.Visible = true;
                        pBMetalPistonDurduLight.Visible = false;

                        pngMetal.Visible = true;
                        pngMetal.Top -= 2;
                    }
                    else
                    {
                        pBMetalPistonCalisiyorLight.Visible = false;
                        pBMetalPistonDurduLight.Visible = true;

                        pngMetal.Visible = false;
                    }



                    if (PlastikPistonDurum)
                    {
                        PbPlastikPistonCalisiyorLight.Visible = true;
                        pBPlastikPistonDurduLight.Visible = false;

                        pngPlastik.Visible = true;
                        pngPlastik.Top -= 2;
                    }
                    else
                    {
                        PbPlastikPistonCalisiyorLight.Visible = false;
                        pBPlastikPistonDurduLight.Visible = true;

                        pngPlastik.Visible = false;
                    }



                    if (CamPistonDurum)
                    {
                        pBCamPistonCalistiLight.Visible = true;
                        pBCamPistonDurdurduLight.Visible = false;

                        pngCam.Visible = true;
                        pngCam.Top -= 2;
                    }
                    else
                    {
                        pBCamPistonCalistiLight.Visible = false;
                        pBCamPistonDurdurduLight.Visible = true;

                        pngCam.Visible = false;
                    }



                    if (KagitPistonDurum)
                    {
                        pBKagitPistonCalisiyorLight.Visible = true;
                        pBKagitPistonDuruyorLight.Visible = false;

                        pngKagit.Visible = true;
                        pngKagit.Top -= 2;

                    }
                    else
                    {
                        pBKagitPistonCalisiyorLight.Visible = false;
                        pBKagitPistonDuruyorLight.Visible = true;

                        pngKagit.Visible = false;
                    }



                }
                catch (Exception ex)
                {
                    timer1.Stop();
                    MessageBox.Show("PLC okuma hatası: " + ex.Message);
                }
            }
        }


        private void btnBaşlatMetalPiston_Click(object sender, EventArgs e)
        {
            if (Connected)
            {
                plc.Write("DB2.DBX0.6", false);
            }
        }

        private void btnMetalPistonDurdur_Click(object sender, EventArgs e)
        {
            if (Connected)
            {
                plc.Write("DB2.DBX0.6", true); // Kapali piston üzerinden aldığım için burayı böyle yaptım

            }
        }

        private void btnPlastikPistonBaslat_Click(object sender, EventArgs e)
        {
            if (Connected)
            {
                plc.Write("DB6.DBX0.6", false);
            }
        }

        private void btnPlastikPistonDurdur_Click(object sender, EventArgs e)
        {
            if (Connected)
            {
                plc.Write("DB6.DBX0.6", true);
            }
        }

        private void btnCamAtıkPistonBaslat_Click(object sender, EventArgs e)
        {
            if (Connected)
            {
                plc.Write("DB3.DBX0.6", false);
            }
        }

        private void btnCamPistonDurdur_Click(object sender, EventArgs e)
        {
            if (Connected)
            {
                plc.Write("DB3.DBX0.6", true);
            }
        }

        private void btnKagitPistonBaslat_Click(object sender, EventArgs e)
        {
            if (Connected)
            {
                plc.Write("DB8.DBX0.6", false);
            }
        }

        private void btnKagitPistonDurdur_Click(object sender, EventArgs e)
        {
            if (Connected)
            {
                plc.Write("DB8.DBX0.6", true);
            }
        }
    }
}
