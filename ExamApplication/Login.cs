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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            GetSubjects();
        }
        Database db = new Database();

        public static string CandName = "", SubName = "";

        private void btngiris_Click(object sender, EventArgs e)
        {
            if (txtkullaniciadi.Text == "" || txtsifre.Text == "")
            {
                MessageBox.Show("Enter Candidate Name and Password");
            }
            else
            {
                db.baglanti.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Candidate where cpass='" + txtsifre.Text + "' and CName='" + txtkullaniciadi.Text + "'", db.baglanti);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    CandName = txtkullaniciadi.Text;
                    SubName = cmbSubject.SelectedValue.ToString();
                    OgrenciAnaSayfasi ogr = new OgrenciAnaSayfasi();
                    ogr.Show();
                    this.Hide();
                    db.baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Candidate Name or Password");
                    txtkullaniciadi.Text = "";
                    txtsifre.Text = "";
                }
                db.baglanti.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OgrSifreUnuttum ogr = new OgrSifreUnuttum();
            ogr.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbkullanicitur.SelectedIndex==0)
            {
                panelsinavsorumlusu.Visible = false;
                paneladmin.Visible = false;
                panelogrenci.Visible = true;
            }
            else if (cmbkullanicitur.SelectedIndex==1)
            {
                panelogrenci.Visible = false;
                paneladmin.Visible = false;
                panelsinavsorumlusu.Visible = true;
            }
            else if (cmbkullanicitur.SelectedIndex==2)
            {
                paneladmin.Visible = true;
                panelogrenci.Visible = false;
                panelsinavsorumlusu.Visible = false;
            }
                 
        }

        private void Login_Load(object sender, EventArgs e)
        {
            panelsinavsorumlusu.Visible = false;
            panelogrenci.Visible = false;
            paneladmin.Visible = false;
        }

        private void btnsinavsorgiris_Click(object sender, EventArgs e)
        {
            if (txtsinavsorumlusuad.Text== "Hicran Filiz" && txtsinavsorumlususifre.Text=="1")
            {
                Question qu = new Question();
                qu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış kullanıcı adı veya şifre!!");
            }
            
        }

        private void btnadmingiris_Click(object sender, EventArgs e)
        {
            if (txtadminad.Text=="Hicran Filiz" && txtadminsifre.Text=="1234")
            {
                Question qu = new Question();
                qu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!! ");
            }
        }

        private void GetSubjects()
        {
            db.baglanti.Open();
            SqlCommand cmd = new SqlCommand("select SName from Subject", db.baglanti);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SName", typeof(string));
            dt.Load(rdr);
            cmbSubject.ValueMember = "SName";
            cmbSubject.DataSource = dt;
            db.baglanti.Close();
        }
    }
}
