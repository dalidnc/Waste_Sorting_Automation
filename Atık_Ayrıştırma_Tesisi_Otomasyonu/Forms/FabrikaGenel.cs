using System;
using System.Windows.Forms;
using S7.Net;
using System.Threading.Tasks;

namespace Atık_Ayrıştırma_Tesisi_Otomasyonu
{
    public partial class FabrikaGenel : Form
    {
        private Plc plc;
        private bool Connected;

        
        public FabrikaGenel()
        {
            InitializeComponent();
            plc = new Plc(CpuType.S71200, "192.168.1.100", 0, 1);
        }

        private void FabrikaGenel_Load(object sender, EventArgs e)
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Connected)
            {
                plc.Write("DB1.DBX0.0", true);  
                plc.Write("DB1.DBX0.1", false); 
            }
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            if (Connected)
            {
                plc.Write("DB1.DBX0.1", true);  
                plc.Write("DB1.DBX0.0", false); 
            }
        }

        private void FabrikaGenel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (plc != null && Connected)
                plc.Close();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (!Connected) return;

            // Girişler
            bool startBut = (bool)plc.Read("DB1.DBX0.0");
            bool stopBut = (bool)plc.Read("DB1.DBX0.1");

            //Sensörler
            bool MetalSensörMem = (bool)plc.Read("DB2.DBX0.1");
            bool MetalPiston = (bool)plc.Read("DB2.DBX0.3");
            bool MetalKonveyör = (bool)plc.Read("DB2.DBX0.4");
            //************************************//
            bool CamSensörMem = (bool)plc.Read("DB3.DBX0.1");
            bool CamPiston = (bool)plc.Read("DB3.DBX0.3");
            bool CamKonveyör = (bool)plc.Read("DB3.DBX0.4");
            //***********************************//
            bool PlastikSensörMem = (bool)plc.Read("DB6.DBX0.1");
            bool PlastikPiston = (bool)plc.Read("DB6.DBX0.3");
            bool PlastikKonveyör = (bool)plc.Read("DB6.DBX0.4");
            //***************************************//
            bool KagitSensörMem = (bool)plc.Read("DB8.DBX0.1");
            bool KagitPiston = (bool)plc.Read("DB8.DBX0.3");
            bool KagitKonveyör = (bool)plc.Read("DB8.DBX0.4");


            if (startBut && !stopBut && !CamPiston && !MetalPiston && !PlastikPiston && !KagitPiston)
            {
                StartLight.Visible = true;
                stopLight.Visible = false;
                plc.Write("DB1.DBX0.2", true);
                lblÇalıştı.Visible = true;
                lblDurdu.Visible = false;
                ConveyorLightStart.Visible = true;
                ConveyorLightStop.Visible = false;
                pcBoxCalisanKonveyor.Visible = true;
                pcBoxDuranKonveyor.Visible = false;


            }
            else
            {
                StartLight.Visible = false;
                stopLight.Visible = true;
                plc.Write("DB1.DBX0.2", false);
                lblÇalıştı.Visible = false;
                lblDurdu.Visible = true;
                ConveyorLightStart.Visible = false;
                ConveyorLightStop.Visible = true;
                pcBoxCalisanKonveyor.Visible = false;
                pcBoxDuranKonveyor.Visible = true;
                plc.Write("DB2.DBX0.4", false);
                plc.Write("DB6.DBX0.3",false);
            }


            if (!MetalPiston)
            {
                lblMetalPistonCalisiyor.Visible = false;
                lblMetalPistonDuruyor.Visible = true;
                pbPistonMetalStartLight.Visible = false;
                pcPistonMetalStopLight.Visible = true;
            }
            else
            {
                lblMetalPistonCalisiyor.Visible = true;
                lblMetalPistonDuruyor.Visible = false;
                pbPistonMetalStartLight.Visible = true;
                pcPistonMetalStopLight.Visible = false;
            }

            if(!MetalKonveyör)
            {
                lblMetalKonDuruyor.Visible = true;
                lblMetalKonCalısıyor.Visible = false;

                pbMetalKonveyörCalısıyorLight.Visible = false;
                pBMetalKonveyörDuruyorLight.Visible = true;

                pbMetalKonveyorCalisti.Visible = false;
                PbMetalKonveyörDurdu.Visible = true;
            }
            else
            {
                lblMetalKonDuruyor.Visible = false;
                lblMetalKonCalısıyor.Visible = true;

                pbMetalKonveyörCalısıyorLight.Visible = true;
                pBMetalKonveyörDuruyorLight.Visible = false;

                pbMetalKonveyorCalisti.Visible = true;
                PbMetalKonveyörDurdu.Visible = false;

                pngMetal.Left += 5;
                
            }







            if (!CamPiston)
            {
                lblCamPistonDuruyor.Visible = true;
                lblCamPistonCalisiyor.Visible = false;

                pBCamPistonCalisiyorLight.Visible = false;
                pBCamPistonDuruyorLight.Visible= true;
            }
            else
            {
                lblCamPistonDuruyor.Visible = false;
                lblCamPistonCalisiyor.Visible = true;

                pBCamPistonCalisiyorLight.Visible = true;
                pBCamPistonDuruyorLight.Visible = false;
            }

            if (!CamKonveyör)
            {
                LblCamKonveyorCalisiyor.Visible = false;
                LblCamKonveyörDuruyor.Visible= true;


                pBCamKonveyorCalisiyorLight.Visible = false;
                pBCamKonveyorDuruyorLight.Visible = true;

                PBCamKonveyorCalisti.Visible = false;
                PBCamKonveyorDurdu.Visible = true;

            }
            else
            {
                LblCamKonveyorCalisiyor.Visible = true;
                LblCamKonveyörDuruyor.Visible = false;


                pBCamKonveyorCalisiyorLight.Visible = true;
                pBCamKonveyorDuruyorLight.Visible = false;

                PBCamKonveyorCalisti.Visible = true;
                PBCamKonveyorDurdu.Visible = false;

                pngCam.Left += 5;

            }




            if (!PlastikPiston)
            {
                lblPlastikPistonDuruyor.Visible = true;
                lblPlastikPistonCalisiyor.Visible = false;

                pBPlastikPistonCalistiLight.Visible = false;
                pBPlastikPistonDurduLight.Visible = true;
            }
            else
            {
                lblPlastikPistonDuruyor.Visible = false;
                lblPlastikPistonCalisiyor.Visible = true;

                pBPlastikPistonCalistiLight.Visible = true;
                pBPlastikPistonDurduLight.Visible = false;
            }


            if (!PlastikKonveyör)
            {
                lblPlastikKonveyorCalisiyor.Visible= false;
                lblPlastikKonveyorDuruyor.Visible=true;

                pBPlastikKonveyorCalisti.Visible = false;
                pBPlastikKonveyorDurdu.Visible=true;

                pBPlastikKonveyorCalisiyorLight.Visible = false;
                pBPlastikKonveyorDuruyorLight.Visible = true;

            }
            else
            {
                lblPlastikKonveyorCalisiyor.Visible = true;
                lblPlastikKonveyorDuruyor.Visible = false;

                pBPlastikKonveyorCalisti.Visible = true;
                pBPlastikKonveyorDurdu.Visible = false;

                pBPlastikKonveyorCalisiyorLight.Visible = true;
                pBPlastikKonveyorDuruyorLight.Visible = false;

                pngPlastik.Left += 5;

            }


            if (!KagitPiston)
            {
                lblKagitPistonDuruyor.Visible = true;
                lblKagitPistonCalisiyor.Visible = false;

                pBKagitPistonCalisiyor.Visible = false;
                pBKagitPistonDuruyor.Visible = true;
            }
            else
            {
                lblKagitPistonDuruyor.Visible = false;
                lblKagitPistonCalisiyor.Visible = true;

                pBKagitPistonCalisiyor.Visible = true;
                pBKagitPistonDuruyor.Visible = false;
            }


            if (!KagitKonveyör)
            {
                lblKagitKonveyorCalisiyor.Visible = false;
                lblKagitKonveyorDuruyor.Visible = true;

                pBKagitKonveyorCalisti.Visible = false;
                pBKagitKonveyorDurdu.Visible = true;

                pBKagitKonveyorDuruyorLight.Visible = true;
                pBKagitKonveyorCalisiyorLight.Visible = false;

            }
            else
            {
                lblKagitKonveyorCalisiyor.Visible = true;
                lblKagitKonveyorDuruyor.Visible = false;

                pBKagitKonveyorCalisti.Visible = true;
                pBKagitKonveyorDurdu.Visible = false;

                pBKagitKonveyorDuruyorLight.Visible = false;
                pBKagitKonveyorCalisiyorLight.Visible = true;

                pngKagit.Left += 5;

            }


        }
    }
}
