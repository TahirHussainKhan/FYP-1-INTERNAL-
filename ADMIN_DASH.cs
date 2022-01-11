using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DASPP
{
    public partial class ADMIN_DASH : Form
    {
        public string value { get; set; }
        public string fn { get; set; }
        public string ln { get; set; }
        public string email { get; set; }
        public string pass { get; set; }
        public string cnt { get; set; }


        public string STRING = "Data Source=DESKTOP-SP96GJ2\\SQLEXPRESS;Initial Catalog=DASPP;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        DataTable dt;
        SqlDataReader dr;
        SqlDataAdapter adp;


        public ADMIN_DASH(string value, string fn, string ln, string email, string cnt, string pass)
        {
            InitializeComponent();
           
            this.value = value;
            this.fn = fn;
            this.ln = ln;
            this.email = email;
            this.cnt = cnt;
            this.pass = pass;
        }
        
        private void ADMIN_DASH_Load(object sender, EventArgs e)
        {
            un.Text = Convert.ToString(value);
        }

        private void HOME_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form HOME = new HOME();
            HOME.Show();
        }

        private void LOGOUT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form ADMIN_LOGIN = new ADMIN_LOGIN();
            ADMIN_LOGIN.Show();
        }

        private void USR_PROFILE_Click(object sender, EventArgs e)
        {
  
            this.Hide();
            Form AD_P = new ADMIN_PROFILE(value,fn,ln,email,cnt,pass);
            AD_P.Show();
        }

        private void KES_IND_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form ADKA = new AD_PREDICTIVE_ANALYSIS(value, fn, ln, email, cnt, pass);
            ADKA.Show();
        }

        private void COMPANIES_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form AD_CMP = new AD_HISTORICAL_ANALYSIS(value, fn, ln, email, cnt, pass);
            AD_CMP.Show();
        }

        private void END_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form us_m = new USER_MANAGEMENT(value, fn, ln, email, cnt, pass);
            us_m.Show();
        }
    }
}
