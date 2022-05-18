using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamApplication
{
    public partial class OgrenciAnaSayfasi : Form
    {
        public OgrenciAnaSayfasi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OgrSifreUnuttum sf = new OgrSifreUnuttum();
            sf.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Exam exam = new Exam();
            exam.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SonuclariGor gor = new SonuclariGor();
            gor.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}
