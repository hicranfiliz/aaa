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
    public partial class Question : Form
    {
        public Question()
        {
            InitializeComponent();
            GetSubjects();
            DisplayQuestions();
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
        private void Reset()
        {
            txtquestion.Text = "";
            txtoption1.Text = "";
            txtoption2.Text = "";
            txtoption3.Text = "";
            txtoption4.Text = "";
            txtanswer.Text = "";
            cmbsubject.SelectedIndex = 0;
        }
        private void DisplayQuestions()
        {
            db.baglanti.Open();
            string Query = "select * from Question";
            SqlDataAdapter sda = new SqlDataAdapter(Query, db.baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            QuestionDGV.DataSource = ds.Tables[0];
            db.baglanti.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtquestion.Text == "" || txtoption1.Text == "" || txtoption2.Text == "" || txtoption3.Text == "" || txtoption4.Text == "" || txtanswer.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    db.baglanti.Open();
                    SqlCommand cmd = new SqlCommand("insert into Question (QDesc,QO1,QO2,QO3,QO4,QA,QS) values (@Qd,@O1,@O2,@O3,@O4,@Qan,@Qsu)", db.baglanti);
                    cmd.Parameters.AddWithValue("@Qd", txtquestion.Text);
                    cmd.Parameters.AddWithValue("@O1", txtoption1.Text);
                    cmd.Parameters.AddWithValue("@O2", txtoption2.Text);
                    cmd.Parameters.AddWithValue("@O3", txtoption3.Text);
                    cmd.Parameters.AddWithValue("@O4", txtoption4.Text);
                    cmd.Parameters.AddWithValue("@Qan", txtanswer.Text);
                    cmd.Parameters.AddWithValue("@Qsu", cmbsubject.SelectedValue.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Question Added");
                    db.baglanti.Close();
                    Reset();
                    DisplayQuestions();

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

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtquestion.Text == "" || txtoption1.Text == "" || txtoption2.Text == "" || txtoption3.Text == "" || txtoption4.Text == "" || txtanswer.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    db.baglanti.Open();
                    SqlCommand cmd = new SqlCommand("Update Question set QDesc=@Qd,QO1=@O1,QO2=@O2,QO3=@O3,QO4=@O4,QA=@Qan,QS=@Qsu where QId=@QKey", db.baglanti);
                    cmd.Parameters.AddWithValue("@Qd", txtquestion.Text);
                    cmd.Parameters.AddWithValue("@O1", txtoption1.Text);
                    cmd.Parameters.AddWithValue("@O2", txtoption2.Text);
                    cmd.Parameters.AddWithValue("@O3", txtoption3.Text);
                    cmd.Parameters.AddWithValue("@O4", txtoption4.Text);
                    cmd.Parameters.AddWithValue("@Qan", txtanswer.Text);
                    cmd.Parameters.AddWithValue("@Qsu", cmbsubject.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@QKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Question Updated");
                    db.baglanti.Close();
                    Reset();
                    DisplayQuestions();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int key = 0;
        private void QuestionDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = QuestionDGV.SelectedCells[0].RowIndex;

            txtquestion.Text = QuestionDGV.Rows[secilen].Cells[1].Value.ToString();
            txtoption1.Text = QuestionDGV.Rows[secilen].Cells[2].Value.ToString();
            txtoption2.Text = QuestionDGV.Rows[secilen].Cells[3].Value.ToString();
            txtoption3.Text = QuestionDGV.Rows[secilen].Cells[4].Value.ToString();
            txtoption4.Text = QuestionDGV.Rows[secilen].Cells[5].Value.ToString();
            txtanswer.Text = QuestionDGV.Rows[secilen].Cells[6].Value.ToString();
            cmbsubject.SelectedValue = QuestionDGV.Rows[secilen].Cells[7].Value.ToString();
            if (txtquestion.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(QuestionDGV.Rows[secilen].Cells[0].Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Subject su = new Subject();
            su.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();        }
    }
}
