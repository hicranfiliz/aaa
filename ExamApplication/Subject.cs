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
    public partial class Subject : Form
    {
        public Subject()
        {
            InitializeComponent();
            DisplaySubjects();
        }
        Database db = new Database();
        int Key = 0;
        private void Reset()
        {
            txtSubjectName.Text = "";
            Key = 0;
        }
        
        private void DisplaySubjects()
        {
            db.baglanti.Open();
            string Query = "select * from Subject";
            SqlDataAdapter sda = new SqlDataAdapter(Query, db.baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SubjectDGV.DataSource = ds.Tables[0];
            db.baglanti.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtSubjectName.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    db.baglanti.Open();
                    SqlCommand cmd = new SqlCommand("insert into Subject (SName) values (@Sn)", db.baglanti);
                    cmd.Parameters.AddWithValue("@Sn", txtSubjectName.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject Saved");
                    db.baglanti.Close();
                    Reset();
                    DisplaySubjects();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void SubjectDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = SubjectDGV.SelectedCells[0].RowIndex;

            txtSubjectName.Text = SubjectDGV.Rows[secilen].Cells[1].Value.ToString();
            if (txtSubjectName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(SubjectDGV.Rows[secilen].Cells[0].Value.ToString());
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtSubjectName.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    db.baglanti.Open();
                    SqlCommand cmd = new SqlCommand("Update Subject set SName=@Sn where SId=@SKey", db.baglanti);
                    cmd.Parameters.AddWithValue("@Sn", txtSubjectName.Text);
                    cmd.Parameters.AddWithValue("@SKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject Updated");
                    db.baglanti.Close();
                    Reset();
                    DisplaySubjects();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Question qu = new Question();
            qu.Show();
            this.Hide();
        }
    }
}
