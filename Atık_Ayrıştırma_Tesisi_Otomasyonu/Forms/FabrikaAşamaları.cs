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
    public partial class FabrikaAşamaları : Form
    {
        public FabrikaAşamaları()
        {
            InitializeComponent();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            KullanıcıDüzenlemeSayfası kullanıcıDüzenlemeSayfası = new KullanıcıDüzenlemeSayfası();
            kullanıcıDüzenlemeSayfası.Show();
        }

        private void gbTumSistem_Enter(object sender, EventArgs e)
        {
            FabrikaGenel fabrikaGenel = new FabrikaGenel();
            fabrikaGenel.Show();
        }

        private void gbKonveyor_Enter(object sender, EventArgs e)
        {
            Kontrol_Sayfası_2 konveyorSayfasi = new Kontrol_Sayfası_2();
            konveyorSayfasi.Show();

        }

        private void gbPiston_Enter(object sender, EventArgs e)
        {
            PistonControl pistonControl = new PistonControl();
            pistonControl.Show();
        }

       

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            FabrikaGenel fabrikaGenel = new FabrikaGenel();
            fabrikaGenel.Show();
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            Kontrol_Sayfası_2 konveyorSayfasi = new Kontrol_Sayfası_2();
            konveyorSayfasi.Show();
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            PistonControl pistonControl = new PistonControl();
            pistonControl.Show();
        }

        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            KullanıcıDüzenlemeSayfası kullanıcıDüzenlemeSayfası = new KullanıcıDüzenlemeSayfası();
            kullanıcıDüzenlemeSayfası.Show();
        }
    }
}
