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
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5C8GF20;Initial Catalog=Pansiyonum;Integrated Security=True");

        private void verileriGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriID"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());


                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            verileriGoster();
        }

        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            cmbCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtTC.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;

        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from MusteriEkle where MusteriID=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Temizle();
            listView1.Items.Clear();
            verileriGoster();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtMail.Clear();
            txtOdaNo.Clear();
            txtTC.Clear();
            txtTelefon.Clear();
            txtUcret.Clear();
            cmbCinsiyet.Text="";
            dtpCikisTarihi.Text = "";
            dtpGirisTarihi.Text = "";
        }
        private void Temizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtMail.Clear();
            txtOdaNo.Clear();
            txtTC.Clear();
            txtTelefon.Clear();
            txtUcret.Clear();
            cmbCinsiyet.Text = "";
            dtpCikisTarihi.Text = "";
            dtpGirisTarihi.Text = "";
        }

       
    }
}

//Data Source=DESKTOP-5C8GF20;Initial Catalog=Pansiyonum;Integrated Security=True
