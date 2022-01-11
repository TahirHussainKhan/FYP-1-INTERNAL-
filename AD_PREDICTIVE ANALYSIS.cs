using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace DASPP
{
    public partial class AD_PREDICTIVE_ANALYSIS : Form
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


        public AD_PREDICTIVE_ANALYSIS(string value, string fn, string ln, string email, string cnt, string pass)
        {
            InitializeComponent();
            
            this.value = value;
            un.Text = value;
            this.fn= fn;
            this.ln = ln;
            this.email = email;
            this.cnt = cnt;
            this.pass = pass;
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
        public String linedata;
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

        private void USR_PROFILE_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form AD_P = new ADMIN_PROFILE(value, fn, ln, email, cnt, pass);
            AD_P.Show();
        }

        private void KES_IND_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form AD_kse = new AD_PREDICTIVE_ANALYSIS(value, fn, ln, email, cnt, pass);
            AD_kse.Show();
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

        private void HOME_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form HM = new HOME();
            HM.Show();
        }

        private void LOGOUT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form AD_L = new ADMIN_LOGIN();
            AD_L.Show();
        }

        private void HIST_AN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form AD_CMP = new AD_HISTORICAL_ANALYSIS(value, fn, ln, email, cnt, pass);
            AD_CMP.Show();
        }

        private void PREDICT_AN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form ADKA = new AD_PREDICTIVE_ANALYSIS(value, fn, ln, email, cnt, pass);
            ADKA.Show();
        }

        private void DASH_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form us_m = new USER_MANAGEMENT(value, fn, ln, email, cnt, pass);
            us_m.Show();
        }
    }
}
