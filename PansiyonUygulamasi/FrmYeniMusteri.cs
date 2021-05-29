using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PansiyonUygulamasi
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5C8GF20;Initial Catalog=Pansiyonum;Integrated Security=True");

        private void btnOda101_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "101";
        }

        private void btnOda102_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "102";
        }

        private void btnOda103_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "103";
        }

        private void btnOda104_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "104";
        }

        private void btnOda105_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "105";
        }

        private void btnOda106_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "106";
        }

        private void btnOda107_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "107";
        }

        private void btnOda108_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "108";
        }

        private void btnOda109_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "109";
        }

        private void btnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mor renkli alanlar dolu odaları gösterir.");
        }

        private void btnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gri renkli alanlar boş odaları gösterir.");
        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.SelectedIndex = 0;
        }

        private void dtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime kucukTarih = Convert.ToDateTime(dtpGirisTarihi.Text);
            DateTime buyukTarih = Convert.ToDateTime(dtpCikisTarihi.Text);

            TimeSpan sonuc;
            sonuc= buyukTarih - kucukTarih;

            label11.Text = sonuc.TotalDays.ToString();

            ucret = Convert.ToInt32(label11.Text)*50;
            txtUcret.Text = ucret.ToString();


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text+"','"+cmbCinsiyet.Text + "','"+txtTelefon.Text+"','"+txtMail.Text +"','"+txtTC.Text+"','"+txtOdaNo.Text+"','"+txtUcret.Text+"','"+dtpGirisTarihi.Value.ToString("yyyy-MM-dd")+"','"+dtpCikisTarihi.Value.ToString("yyyy-MM-dd")+"')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri kaydı başarılı");
            txtAdi.Text="";
            txtSoyadi.Text = "";
            txtMail.Text = "";
            txtTelefon.Text = "";
            txtTC.Text = "";
            txtOdaNo.Text = "";           
            txtUcret.Text = "";
        }
    }
}
