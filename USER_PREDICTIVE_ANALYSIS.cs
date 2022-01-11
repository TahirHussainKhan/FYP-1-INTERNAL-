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
using System.Windows.Forms.DataVisualization.Charting;

namespace DASPP
{
    public partial class USER_PREDICTIVE_ANALYSIS : Form
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
        SqlDataAdapter adp;
        SqlDataReader sdr;
        float[] close;
        DateTime[] datee;

        public USER_PREDICTIVE_ANALYSIS(string value, string fn, string ln, string email, string cnt, string pass)
        {
            InitializeComponent();
            this.value = value;
            un.Text = value;
            this.fn = fn;
            this.ln = ln;
            this.email = email;
            this.cnt = cnt;
            this.pass = pass;
        }

        private void USR_PROFILE_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form USER_P = new USER_PROFILE(value, fn, ln, email, cnt, pass);
            USER_P.Show();
        }

        private void cmplt_data_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(STRING);
            con.Open();
            adp = new SqlDataAdapter("select * from KSE100", con);
            dt = new DataTable();
            adp.Fill(dt);
            kse_data.DataSource = dt;
            con.Close();
        }

        private void selected_data_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(STRING);
            con.Open();
            adp = new SqlDataAdapter("SELECT * from KSE100 WHERE datee BETWEEN '" + from.Value.ToShortDateString() + "' AND  '" + to.Value.ToShortDateString() + "'", con);

            dt = new DataTable();
            adp.Fill(dt);
            kse_data.DataSource = dt;
            con.Close();
        }

        private void LOAD_GRAPH_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(STRING);
            con.Open();
            adp = new SqlDataAdapter("SELECT datee,Cl from KSE100 WHERE datee BETWEEN '" + FROM_GRAPH.Value.ToShortDateString() + "' AND  '" + TO_GRAPH.Value.ToShortDateString() + "'", con);
            dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void KES_IND_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form US_kse = new USER_PREDICTIVE_ANALYSIS(value, fn, ln, email, cnt, pass);
            US_kse.Show();
        }

        private void COMPANIES_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form US_CMP = new USER_HISTORICAL_ANALYSIS(value, fn, ln, email, cnt, pass);
            US_CMP.Show();
        }

        private void LOGOUT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form USER_L = new USER_LOGIN();
            USER_L.Show();

        }

        private void END_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HOME_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form HM = new HOME();
            HM.Show();
        }
    }
}
