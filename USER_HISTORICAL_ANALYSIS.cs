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
using System.Windows.Forms.DataVisualization.Charting;

namespace DASPP
{
    public partial class USER_HISTORICAL_ANALYSIS : Form
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

        public USER_HISTORICAL_ANALYSIS(string value, string fn, string ln, string email, string cnt, string pass)
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
            Form US_P = new USER_PROFILE(value, fn, ln, email, cnt, pass);
            US_P.Show();
        }

        private void LOGOUT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form US_L = new USER_LOGIN();
            US_L.Show();
        }

        private void END_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void HOME_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form HM = new HOME();
            HM.Show();
        }

        private void cmplt_data_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(STRING);
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
            }
            cmd = new SqlCommand("SELECT * from PSXDATA where Symbol='" + Convert.ToString(cmp_cb.Text) + "'", con);
            adp = new SqlDataAdapter();
            dt = new DataTable();
            adp.SelectCommand = cmd;
            dt.Clear();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            double[] s1 = new double[dataGridView1.Rows.Count];

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                s1[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
            }

            var series1 = new LiveCharts.Wpf.LineSeries()
            {
                Title = cmp_cb.Text.ToString(),
                Values = new LiveCharts.ChartValues<double>(s1),
            };

            // display the series in the chart control
            cartesianChart1.Series.Clear();
            cartesianChart1.Series.Add(series1);

        }

        private void selected_data_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(STRING);
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
            }
            cmd = new SqlCommand("select * from PSXDATA where Symbol = '" + Convert.ToString(cmp_cb.Text) + "'and Date BETWEEN '" + from.Value.ToString("yyyy-MM-dd") + "' and '" + to.Value.ToString("yyyy-MM-dd") + "'", con);
            adp = new SqlDataAdapter();
            dt = new DataTable();
            adp.SelectCommand = cmd;
            dt.Clear();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            double[] s1 = new double[dataGridView1.Rows.Count];

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                s1[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
            }

            var series1 = new LiveCharts.Wpf.LineSeries()
            {
                Title = cmp_cb.Text.ToString(),
                Values = new LiveCharts.ChartValues<double>(s1),
            };

            // display the series in the chart control
            cartesianChart1.Series.Clear();
            cartesianChart1.AxisX.ToList();
            cartesianChart1.Series.Add(series1);

        }
    }
}
