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
    public partial class SonuclariGor : Form
    {
        public SonuclariGor()
        {
            InitializeComponent();
            lblkullaniciadi.Text = Login.CandName;
            GetSubjects();
            DisplayResults();
        }

        Database db = new Database();
        private void GetSubjects()
        {
            db.baglanti.Open();
            SqlCommand cmd = new SqlCommand("select SName from Subject", db.baglanti);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SName", typeof(string));
            dt.Load(rdr);
            cmbsubject.ValueMember = "SName";
            cmbsubject.DataSource = dt;
            db.baglanti.Close();
        }

        private void DisplayResults()
        {
            db.baglanti.Open();
            string Query = "select * from Result where RCandidate='"+lblkullaniciadi.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, db.baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ResultDGV.DataSource = ds.Tables[0];
            db.baglanti.Close();
        }
        private void FilterBySub()
        {
            db.baglanti.Open();
            string Query = "select * from Result where RSubject='" + cmbsubject.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, db.baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ResultDGV.DataSource = ds.Tables[0];
            db.baglanti.Close();
        }

        private void cmbsubject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterBySub();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OgrenciAnaSayfasi anasay = new OgrenciAnaSayfasi();
            anasay.Show();
            this.Hide();

        }
    }
}
