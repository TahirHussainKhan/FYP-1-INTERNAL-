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

namespace DASPP
{
    public partial class USER_MANAGEMENT : Form
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

        public USER_MANAGEMENT(string value, string fn, string ln, string email, string cnt, string pass)
        {
            InitializeComponent();
            this.value = value;
            this.fn = fn;
            this.ln = ln;
            this.email = email;
            this.cnt = cnt;
            this.pass = pass;
        }

        private void USR_PROFILE_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form AD_P = new ADMIN_PROFILE(value, fn, ln, email, cnt, pass);
            AD_P.Show();
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

        private void END_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void USER_MANAGEMENT_Load(object sender, EventArgs e)
        {
            un.Text = Convert.ToString(value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form us_m = new USER_MANAGEMENT(value, fn, ln, email, cnt, pass);
            us_m.Show();
        }

        private void LO_USER_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(STRING);
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
            }
            cmd = new SqlCommand("SELECT USERNAME,FirstName,LastName,EMAIL,CONTACT from USERS", con);
            adp = new SqlDataAdapter();
            dt = new DataTable();
            adp.SelectCommand = cmd;
            dt.Clear();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["USERNAME"].FormattedValue.ToString();
           
        }

        private void RESTRICT_USER_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(STRING);
            con.Open();
            cmd = new SqlCommand(" UPDATE USERS SET STATUSS ="+0+" WHERE USERNAME ='"+Convert.ToString(textBox1.Text)+"'", con);
            adp = new SqlDataAdapter();
            dt = new DataTable();
            adp.SelectCommand = cmd;
            dt.Clear();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void DELETE_USER_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(STRING);
            con.Open();
            cmd = new SqlCommand("delete  from  USERS where USERNAME ='" + Convert.ToString(textBox1.Text) + "'", con);
            adp = new SqlDataAdapter();
            dt = new DataTable();
            adp.SelectCommand = cmd;
            dt.Clear();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void L_USERS_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(STRING);
            con.Open();
            cmd = new SqlCommand("SELECT USERNAME,FirstName,LastName,EMAIL,CONTACT from USERS where STATUSS ='" + 0 + "'", con);
            adp = new SqlDataAdapter();
            dt = new DataTable();
            adp.SelectCommand = cmd;
            dt.Clear();
            adp.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView2.Rows[e.RowIndex].Cells["USERNAME"].FormattedValue.ToString();
        }

        private void R_REST_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(STRING);
            con.Open();
            cmd = new SqlCommand(" UPDATE USERS SET STATUSS =" + 1 + " WHERE USERNAME ='" + Convert.ToString(textBox2.Text) + "'", con);
            adp = new SqlDataAdapter();
            dt = new DataTable();
            adp.SelectCommand = cmd;
            dt.Clear();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            con = new SqlConnection(STRING);
            con.Open();
            cmd = new SqlCommand("delete  from  RESTRICTED where USERNAME ='" + Convert.ToString(textBox2.Text) + "'", con);
            adp = new SqlDataAdapter();
            dt = new DataTable();
            adp.SelectCommand = cmd;
            dt.Clear();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void FN_BOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void LN_BOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void MAIL_BOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && e.KeyChar != 8 && (!char.IsDigit(e.KeyChar)) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
            }

        }

        private void CNT_BOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CNT_BOX.Text.Length < 11)
            {
                if ((!char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
            else
            {
                MessageBox.Show("CONTACT NO MUST CONTAIN 11 DIGITS", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.None);
                CNT_BOX.Focus();
                CNT_BOX.SelectAll();
            }
        }

        private void USERNAME_BOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PASS_BOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CONPASS_BOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SIGNUP_Click(object sender, EventArgs e)
        {
            string ff_n = Convert.ToString(FN_BOX.Text);
            string ll_n = Convert.ToString(LN_BOX.Text);
            string mmail = Convert.ToString(MAIL_BOX.Text);
            Int64 ccnt = Convert.ToInt64(CNT_BOX.Text);
            string uu_n = Convert.ToString(USERNAME_BOX.Text);
            string ppass = Convert.ToString(PASS_BOX.Text);
            string cc_pass = Convert.ToString(CONPASS_BOX.Text);

            if (ff_n != null && ll_n != null && mmail != null && ccnt != null && uu_n != null && ppass != null)
            {
                if (cc_pass != ppass)
                {
                    MessageBox.Show("PLEASE CONFIRM THE PASSWORD", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    PASS_BOX.Clear();
                    CONPASS_BOX.Clear();
                    PASS_BOX.Focus();
                }
                else
                {
                    con = new SqlConnection(STRING);
                    con.Open();

                    cmd = new SqlCommand("sp_user_insert", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("u_n", uu_n);
                    cmd.Parameters.AddWithValue("f_n", ff_n);
                    cmd.Parameters.AddWithValue("l_n", ll_n);
                    cmd.Parameters.AddWithValue("email", mmail);
                    cmd.Parameters.AddWithValue("cnt", ccnt);
                    cmd.Parameters.AddWithValue("pass", ppass);
                    cmd.Parameters.AddWithValue("st", 1);
                    int k = cmd.ExecuteNonQuery();
                    if (k != 0)
                    {
                        MessageBox.Show("ACCOUNT CREATED", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.None);
                        con.Close();
                    

                    }
                    else
                    {
                        MessageBox.Show("ACCOUNT CREATION UNSUCCESSFULL", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.None);
                        con.Close();
                        

                    }
                }
            }
            else
            {
                MessageBox.Show("PLEASE FILL THE FORM CORRECTLY", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.None);
                FN_BOX.Focus();

            }
        }
    }
}
