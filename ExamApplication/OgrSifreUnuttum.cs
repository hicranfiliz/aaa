using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExamApplication
{
    public partial class OgrSifreUnuttum : Form
    {
        public OgrSifreUnuttum()
        {
            InitializeComponent();
        }
        Database db = new Database();

        private void btnguncelle_Click(object sender, EventArgs e)
        {
           
            
                if (txtpassword.Text == txtsifretekrar.Text)
                {
                    db.baglanti.Open();
                    SqlCommand komut = new SqlCommand("select QName,QPass,QAdd,QPhone from Candidate where QName=@p1", db.baglanti);
                    komut.Parameters.AddWithValue("@p1", txtName.Text);
                    SqlDataReader read = komut.ExecuteReader();
                    if (read.Read())
                    {
                        if (txtName.Text == read["ad"].ToString() && txtaddress.Text == read["soyad"].ToString())
                        {
                            db.baglanti.Close();
                            db.baglanti.Open();
                            SqlCommand guncelle = new SqlCommand("update Candidate set QPass=@p11 where QName=@p12", db.baglanti);
                            //guncelle.Parameters.AddWithValue("@p10", txtKullaniciAdi.Text);
                            guncelle.Parameters.AddWithValue("@p11", txtpassword.Text);
                            guncelle.Parameters.AddWithValue("@p12", txtName.Text);
                            guncelle.ExecuteNonQuery();
                            db.baglanti.Close();
                            MessageBox.Show("Şifreniz güncellenmiştir.");

                        }
                        else
                        {
                            MessageBox.Show("Bilgilerinizi kontrol ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bilgilerinizi kontrol ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    db.baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Girdiğiniz şifreler uyuşmuyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OgrenciAnaSayfasi anasayf = new OgrenciAnaSayfasi();
            anasayf.Show();
            this.Hide();
        }
    }
}
