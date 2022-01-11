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
using System.Net;
using System.Net.Mail;
using Microsoft.VisualBasic;



namespace DASPP
{
    public partial class ADMIN_LOGIN : Form
    {
      
        public string STRING = "Data Source=DESKTOP-SP96GJ2\\SQLEXPRESS;Initial Catalog=DASPP;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        DataTable dt ;
        SqlDataAdapter adp;
        SqlDataReader dr;

        public string f_n;
        public string l_n;
        public string mail;
        public Int64 cnt;
        public string cnt1;
        public string u_n;
        public string pass;
        public string c_pass;
        public string VALUE;

        public ADMIN_LOGIN()
        {
            InitializeComponent();
           
        }
      
        //BUTTONS
        private void END_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void TO_HOME_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form HOME = new HOME();
            HOME.Show();
        }



        //LOGIN PART VALIDATION
        private void hidepass2_CheckedChanged(object sender, EventArgs e)
        {
            if (hidepass2.Checked)
            {
                PASS_LOGIN.UseSystemPasswordChar = true;
                hidepass2.Text = "SHOW";
            }
            else
            {
                PASS_LOGIN.UseSystemPasswordChar = false;
                hidepass2.Text = "HIDE";
            }
        }
        private void UN_LOGIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private void PASS_LOGIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void LOGIN_BUTTON_Click(object sender, EventArgs e)
        {
            u_n = Convert.ToString(UN_LOGIN.Text);
            pass = Convert.ToString(PASS_LOGIN.Text);

            if (u_n != null && pass != null)
            {

                con = new SqlConnection(STRING);
                con.Open();
                dt = new DataTable();
                adp = new SqlDataAdapter();
                cmd = new SqlCommand("admin_login_check", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@u_n", u_n);
                cmd.Parameters.AddWithValue("@pass", pass);
                adp.SelectCommand = cmd;
                adp.Fill(dt);
                cmd.Dispose();
                if (dt.Rows.Count > 0)
                {
                    dt.Clear();
                    dt.Dispose();
                    adp.Dispose();
                    con.Close();
                    MessageBox.Show("LOGIN SUCCESSFULL", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    VALUE = u_n;
                   

                    con = new SqlConnection(STRING);
                    con.Open();
                    cmd = new SqlCommand("SELECT FirstName,LastName,EMAIL,CONTACT,PASS from ADMIN where USERNAME='" + Convert.ToString(VALUE) + "'", con);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {

                        f_n = dr["FirstName"].ToString();
                        l_n = dr["LastName"].ToString();
                        mail = dr["EMAIL"].ToString();
                        cnt1 = dr["CONTACT"].ToString();
                        pass = dr["PASS"].ToString();
                    }
                    con.Close();
                    this.Close();
                    Form ADMIN_DASH = new ADMIN_DASH(VALUE, f_n, l_n, mail, cnt1, pass);
                    ADMIN_DASH.Show();

                }
                else
                {
                    MessageBox.Show("WRONG USERNAME OR PASSWORD", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    dt.Clear();
                    dt.Dispose();
                    adp.Dispose();
                    con.Close();
                    UN_LOGIN.Focus();
                }
            }

            else
            {
                dt.Clear();
                dt.Dispose();
                adp.Dispose();
                con.Close();
                MessageBox.Show("USERNAME/PASSWORD NOT CORRECT", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.None);
                UN_LOGIN.Focus();
            }
        }
        

        //SIGNUP PART VALIDATION
        private void FN_BOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar))&& e.KeyChar!=8)
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
        //EMAIL VERIFICATION
        private void VERIFICATION_Click(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex RM = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (MAIL_BOX.Text.Length > 0)
            {
                if (!RM.IsMatch(MAIL_BOX.Text))
                {
                    MessageBox.Show("INVALID EMAIL ADDRESS" + "\n" + "PLEASE ENTER VALID EMAIL ADDRESS", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    MAIL_BOX.Focus();
                    MAIL_BOX.SelectAll();

                }
                else
                {
                    try
                    {
                        SmtpClient cd = new SmtpClient();
                        cd.Port = 587;
                        cd.Host = "smtp.gmail.com";
                        cd.EnableSsl = Enabled;
                        cd.DeliveryMethod = SmtpDeliveryMethod.Network;
                        cd.UseDefaultCredentials = false;
                        cd.Credentials = new NetworkCredential("vamazonservices@gmail.com", "Attahussain12");

                        MailMessage md = new MailMessage();
                        md.From = new MailAddress("vamazonservices@gmail.com");
                        md.To.Add(MAIL_BOX.Text.Trim());
                        md.Subject = "VERIFY YOUR EMAIL";
                        md.IsBodyHtml = Enabled;
                        md.Body = "YOUR VERIFICATION CODE IS 00000";

                        cd.Send(md);



                        int vc = Convert.ToInt32(Interaction.InputBox("Enter the code received in Email", "EMAIL VERIFICATION", "enter code...", 500, 300));
                        if (vc == 0000)
                        {
                            MessageBox.Show("EMAIL VERIFIED SUCCESSFULLY", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                            VERIFICATION.Text = "VERIFIED";
                            CNT_BOX.Focus();
                        }
                        else
                        {
                            MessageBox.Show("VERIFICATION FAILED", "Oooops!", MessageBoxButtons.OK, MessageBoxIcon.None);
                            VERIFICATION.Text = "VERIFIED";
                            MAIL_BOX.Focus();
                        }

                    }
                    catch 
                    {
                        MessageBox.Show("MAIL NOT SEND", "Oooops!", MessageBoxButtons.OK, MessageBoxIcon.None);
                        MAIL_BOX.Focus();
                        MAIL_BOX.SelectAll();
                    }
                    

                }
            }
            else 
            {
                MessageBox.Show("PLEASE ENTER EMAIL ADDRESS", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.None);
                MAIL_BOX.Focus();
                MAIL_BOX.SelectAll();

            }
        }
        //EMAIL VERIFICATION
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
                MessageBox.Show("CONTACT NO MUST CONTAIN 11 DIGITS", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void hidepass_CheckedChanged(object sender, EventArgs e)
        {
            if (hidepass.Checked)
            {
                PASS_BOX.UseSystemPasswordChar = true;
                CONPASS_BOX.UseSystemPasswordChar= true;
                hidepass.Text = "SHOW";
            }
            else 
            {
                PASS_BOX.UseSystemPasswordChar = false;
                CONPASS_BOX.UseSystemPasswordChar = false;
                hidepass.Text = "HIDE";
            }
        }
        private void SIGNUP_Click(object sender, EventArgs e)
        {

            f_n = Convert.ToString(FN_BOX.Text);
            l_n = Convert.ToString(LN_BOX.Text);
            mail = Convert.ToString(MAIL_BOX.Text);
            cnt = Convert.ToInt64(CNT_BOX.Text);
            u_n = Convert.ToString(USERNAME_BOX.Text);
            pass = Convert.ToString(PASS_BOX.Text);
            c_pass = Convert.ToString(CONPASS_BOX.Text);

            if (f_n != null && l_n != null && mail !=null && cnt != null && u_n != null && pass != null && VERIFICATION.Text == "VERIFIED")
            {
                if (c_pass != pass)
                {
                    MessageBox.Show("PLEASE CONFIRM THE PASSWORD", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PASS_BOX.Clear();
                    CONPASS_BOX.Clear();
                    PASS_BOX.Focus();
                }
                else
                {
                    con = new SqlConnection(STRING);
                    con.Open();
                    cmd = new SqlCommand("sp_admin_insert", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("u_n", u_n);
                    cmd.Parameters.AddWithValue("f_n", f_n);
                    cmd.Parameters.AddWithValue("l_n", l_n);
                    cmd.Parameters.AddWithValue("email", mail);
                    cmd.Parameters.AddWithValue("cnt", cnt);
                    cmd.Parameters.AddWithValue("pass", pass);
                  
                    int k = cmd.ExecuteNonQuery();
                    if (k != 0)
                    {
                        MessageBox.Show("SIGNUP SUCCESSFULL", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.None);
                        con.Close();
                        VALUE = u_n;


                        con = new SqlConnection(STRING);
                        con.Open();
                        cmd = new SqlCommand("SELECT FirstName,LastName,EMAIL,CONTACT,PASS from ADMIN where USERNAME='" + Convert.ToString(VALUE) + "'", con);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {

                            f_n = dr["FirstName"].ToString();
                            l_n = dr["LastName"].ToString();
                            mail = dr["EMAIL"].ToString();
                            cnt1 = dr["CONTACT"].ToString();
                            pass = dr["PASS"].ToString();
                        }
                        con.Close();
                        this.Close();
                        Form ADMIN_DASH = new ADMIN_DASH(VALUE, f_n, l_n, mail, cnt1, pass);
                        ADMIN_DASH.Show();

                    }
                    else 
                    {
                        MessageBox.Show("SIGNUP UNSUCCESSFULL", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.None);
                        con.Close();
                        this.Close();
                        Form ADMIN_DASH = new ADMIN_DASH(VALUE, f_n, l_n, mail, cnt1, pass);
                        ADMIN_DASH.Show();

                    }
                }
            }
            else 
            {
                MessageBox.Show("PLEASE FILL THE FORM CORRECTLY", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FN_BOX.Focus();

            }

        }

        private void ADMIN_LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
