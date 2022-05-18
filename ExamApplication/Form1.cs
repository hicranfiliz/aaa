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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DisplayCandidates();        }
        Database db = new Database();

        private void Reset()
        {
            txtName.Text = "";
            txtAge.Text = "";
            txtphone.Text = "";
            txtaddress.Text = "";
            txtpassword.Text = "";
        }

        private void DisplayCandidates()
        {
            db.baglanti.Open();
            string Query = "select * from Candidate";
            SqlDataAdapter sda = new SqlDataAdapter(Query, db.baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CandidatesDGV.DataSource = ds.Tables[0];
            db.baglanti.Close();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAge.Text == "" || txtpassword.Text == "" || txtphone.Text == "" || txtaddress.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    int score = 0;
                    db.baglanti.Open();
                    SqlCommand cmd = new SqlCommand("insert into Candidate (CName,CAge,CPass,CScore,CAdd,Cphone) values (@Cn,@Ca,@Cp,@Cs,@Cad,@Cph)", db.baglanti);
                    cmd.Parameters.AddWithValue("@Cn", txtName.Text);
                    cmd.Parameters.AddWithValue("@Ca", txtAge.Text);
                    cmd.Parameters.AddWithValue("@Cp", txtpassword.Text);
                    cmd.Parameters.AddWithValue("@Cs", score);
                    cmd.Parameters.AddWithValue("@Cad", txtaddress.Text);
                    cmd.Parameters.AddWithValue("@Cph", txtphone.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Candidate Saved");
                    db.baglanti.Close();
                    Reset();
                    DisplayCandidates();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        //Güncelleme yapmıyor!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAge.Text == "" || txtpassword.Text == "" || txtaddress.Text == "" || txtphone.Text == "")
            {
                MessageBox.Show("Bilgilerinizi girdiğinizden emin olunuz!");
            }
            else
            {
                try
                {

                    //db.baglanti.Open();
                    //SqlCommand cmd = new SqlCommand("update Candidate set CName=@p1,CAge=@p2,CPass=@p3,CAdd=@p4,CPhone=@p5 where CId=@p6)", db.baglanti);
                    //cmd.Parameters.AddWithValue("@p1", txtName.Text);
                    //cmd.Parameters.AddWithValue("@p2", txtAge.Text);
                    //cmd.Parameters.AddWithValue("@p3", txtpassword.Text);
                    //cmd.Parameters.AddWithValue("@p4", txtaddress.Text);
                    //cmd.Parameters.AddWithValue("@p5", txtphone.Text);
                    //cmd.Parameters.AddWithValue("@p6", Key);
                    //cmd.ExecuteNonQuery();
                    //MessageBox.Show("Kayıt güncellendi.");
                    //db.baglanti.Close();
                    //Reset();
                    //DisplayCandidates();
                    int score = 0;
                    db.baglanti.Open();
                    SqlCommand cmd = new SqlCommand("Update Candidate set CName=@Cn,CAge=@Ca,CPass=@Cp,CAdd=@Cad,Cphone=@Cph where CId=@CKey", db.baglanti);
                    cmd.Parameters.AddWithValue("@Cn", txtName.Text);
                    cmd.Parameters.AddWithValue("@Ca", txtAge.Text);
                    cmd.Parameters.AddWithValue("@Cp", txtpassword.Text);

                    cmd.Parameters.AddWithValue("@Cad", txtaddress.Text);
                    cmd.Parameters.AddWithValue("@Cph", txtphone.Text);
                    cmd.Parameters.AddWithValue("@CKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Candidate Updated");
                    db.baglanti.Close();
                    Reset();
                    DisplayCandidates();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        int key = 0;
        private void CandidatesDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = CandidatesDGV.SelectedCells[0].RowIndex;

            txtName.Text = CandidatesDGV.Rows[secilen].Cells[1].Value.ToString();
            txtAge.Text = CandidatesDGV.Rows[secilen].Cells[2].Value.ToString();
            txtpassword.Text = CandidatesDGV.Rows[secilen].Cells[3].Value.ToString();
            txtaddress.Text = CandidatesDGV.Rows[secilen].Cells[5].Value.ToString();
            txtphone.Text = CandidatesDGV.Rows[secilen].Cells[6].Value.ToString();
            if (txtName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(CandidatesDGV.Rows[secilen].Cells[0].Value.ToString());
            }
        }

    }
}
