using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yazlab.Models;

namespace login
{
    public partial class AnaSayfa : Form
    {
        private Kullanicilar user;

        public AnaSayfa()
        {
            InitializeComponent();
        }

        public AnaSayfa(Kullanicilar user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            LabelKullaniciAdi.Text = user.Kullanici_Adi;
            LabelRol.Text = user.Kullanici_Rol;

        }

        private void ButtonKullaniciAdi_Click(object sender, EventArgs e)
        {

        }
    }
}
