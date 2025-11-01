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

namespace Atık_Ayrıştırma_Tesisi_Otomasyonu
{
    public partial class Kontrol_Sayfası_2 : Form
    {
        private Plc plc;
        private bool Connected;
        public Kontrol_Sayfası_2()
        {
            InitializeComponent();
            plc = new Plc(CpuType.S71200, "192.168.1.100", 0, 1);
        }

        private void Kontrol_Sayfası_2_Load(object sender, EventArgs e)
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
                    bool AnaKonveyorDurum = (bool)plc.Read("DB1.DBX0.2");
                    bool MetalKonveyorDurum = (bool)plc.Read("DB2.DBX0.4");
                    bool CamKonveyorDurum = (bool)plc.Read("DB3.DBX0.4");
                    bool PlastikKonveyorDurum = (bool)plc.Read("DB6.DBX0.4");
                    bool KagitKonveyorDurum = (bool)plc.Read("DB8.DBX0.4");



                    if (AnaKonveyorDurum)
                    {
                        pBAnaKonveyorCalisiyorLight.Visible = true;
                        pBAnaKonveyorDuruyorLight.Visible = false;

                        AnaKonveyorCalisti.Visible = true;
                        AnaKonveyorDurdu.Visible = false;

                    }
                    else
                    {
                        pBAnaKonveyorCalisiyorLight.Visible = false;
                        pBAnaKonveyorDuruyorLight.Visible = true;

                        AnaKonveyorCalisti.Visible = false;
                        AnaKonveyorDurdu.Visible = true;
                    }




                    if (MetalKonveyorDurum)
                    {
                        pBMetalKonveyorCalisiyorLight.Visible = true;
                        pBMetalKonveyorDuruyorLight.Visible = false;

                        MetalKonveyorCalisti.Visible = true;
                        MetalKonveyorDurdu.Visible = false;
                    }
                    else
                    {
                        pBMetalKonveyorCalisiyorLight.Visible = false;
                        pBMetalKonveyorDuruyorLight.Visible = true;


                        MetalKonveyorCalisti.Visible = false;
                        MetalKonveyorDurdu.Visible = true;
                    }






                    if (PlastikKonveyorDurum)
                    {
                        pBPlastikKonveyorCalisiyorLight.Visible = true;
                        pbPlastikKonveyorDuruyorLight.Visible = false;

                        PlastikKonveyorCalisti.Visible = true;
                        PlastikKonveyorDurdu.Visible = false;
                    }
                    else
                    {
                        pBPlastikKonveyorCalisiyorLight.Visible = false;
                        pbPlastikKonveyorDuruyorLight.Visible = true;

                        PlastikKonveyorCalisti.Visible = false;
                        PlastikKonveyorDurdu.Visible = true;
                    }





                    if (CamKonveyorDurum)
                    {
                        pBCamKonveyorCalisiyorLight.Visible = true;
                        pBCamKonveyorDuruyorLight.Visible = false;

                        CamKonveyorCalisti.Visible = true;
                        CamKonveyorDurdu.Visible = false;
                    }
                    else
                    {
                        pBCamKonveyorCalisiyorLight.Visible = false;
                        pBCamKonveyorDuruyorLight.Visible = true;

                        CamKonveyorCalisti.Visible = false;
                        CamKonveyorDurdu.Visible = true;
                    }



                    if (KagitKonveyorDurum)
                    {
                        pBKagitKonveyorCalisiyorLight.Visible = true;
                        pBKagitKonveyorDuruyorLight.Visible = false;

                        KagitKonveyorCalisti.Visible = true;
                        KagitKonveyorDurdu.Visible = false;

                    }
                    else
                    {
                        pBKagitKonveyorCalisiyorLight.Visible = false;
                        pBKagitKonveyorDuruyorLight.Visible = true;

                        KagitKonveyorCalisti.Visible = false;
                        KagitKonveyorDurdu.Visible = true;
                    }




                }
                catch (Exception ex)
                {
                    timer1.Stop();
                    MessageBox.Show("PLC okuma hatası: " + ex.Message);
                }
            }


        }

        private void btnAnaKonveyorCalisiyor_Click(object sender, EventArgs e)
        {
            if (Connected)
            {
                plc.Write("DB1.DBX0.3", false);
            }
        }

        private void btnAnaKonveyorDuruyor_Click(object sender, EventArgs e)
        {
            if (Connected)
            {
                plc.Write("DB1.DBX0.3", true);
            }
        }



        private void btnCamKonveyorCalisiyor_Click(object sender, EventArgs e)
        {
            if (Connected)
            {
                plc.Write("DB3.DBX0.7", false);
            }
        }

        private void btnCamKonveyorDurdur_Click(object sender, EventArgs e)
        {
            if (Connected)
            {
                plc.Write("DB3.DBX0.7", true);
            }
        }

        private void btnMetalKonveyorCalistir_Click(object sender, EventArgs e)
        {
            if (Connected)
            {
                plc.Write("DB2.DBX0.7", false);
            }
        }

        private void btnMetalKonveyorDurdu_Click(object sender, EventArgs e)
        {
            if (Connected)
            {
                plc.Write("DB2.DBX0.7", true);
            }
        }

        private void btnKagitKonveyorCalistir_Click(object sender, EventArgs e)
        {
            if (Connected)
            {
                plc.Write("DB8.DBX0.7", false);
            }
        }

        private void btnKagitKonveyorDurdur_Click(object sender, EventArgs e)
        {
            if (Connected)
            {
                plc.Write("DB8.DBX0.7", true);
            }
        }

        private void btnPlastikKonveyorDuruyor_Click_1(object sender, EventArgs e)
        {
            if (Connected)
            {
                plc.Write("DB6.DBX0.7", true);
            }
        }


        private void btnPlastikKonveyorCalisiyor_Click_1(object sender, EventArgs e)
        {
            if (Connected)
            {
                plc.Write("DB6.DBX0.7", false);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
