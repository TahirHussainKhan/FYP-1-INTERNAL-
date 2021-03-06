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
    public partial class ADMIN_PROFILE : Form
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

        public ADMIN_PROFILE(string value, string fn, string ln, string email, string cnt, string pass)
        {
            InitializeComponent();
            this.value = value;
            this.fn = fn;
            this.ln = ln;
            this.email = email;
            this.cnt = cnt;
            this.pass = pass;

            un.Text = value.ToString();
            label12.Text = ToString();

            FN_BOX.Text = value;
            FN_BOX.Text = fn;
            LN_BOX.Text = ln;
            MAIL_BOX.Text = email;
            CNT_BOX.Text = cnt;


        }

        private void ADMIN_PROFILE_Load(object sender, EventArgs e)
        {
            
           

        }

        private void USR_PROFILE_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form AD_P = new ADMIN_PROFILE(value, fn, ln, email, cnt, pass);
            AD_P.Show();
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

        private void HIST_AN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form AD_CMP = new AD_HISTORICAL_ANALYSIS(value, fn, ln, email, cnt, pass);
            AD_CMP.Show();
        }

        private void PREDICT_AN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form AD_kse = new AD_PREDICTIVE_ANALYSIS(value, fn, ln, email, cnt, pass);
            AD_kse.Show();
        }

        private void SIGNUP_Click(object sender, EventArgs e)
        {
            string ff_n = Convert.ToString(FN_BOX.Text);
            string ll_n = Convert.ToString(LN_BOX.Text);
            string mmail = Convert.ToString(MAIL_BOX.Text);
            Int64 ccnt = Convert.ToInt64(CNT_BOX.Text);
            string ppass = Convert.ToString(PASS_BOX.Text);
            string cc_pass = Convert.ToString(CONPASS_BOX.Text);

            if (ff_n != null && ll_n != null && mmail != null && ccnt != null &&  ppass != null && VERIFICATION.Text == "VERIFIED")
            {
                if (cc_pass != ppass)
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
                    cmd = new SqlCommand("update_admin", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("u_n", Convert.ToString(value));
                    cmd.Parameters.AddWithValue("f_n", ff_n);
                    cmd.Parameters.AddWithValue("l_n", ll_n);
                    cmd.Parameters.AddWithValue("email", mmail);
                    cmd.Parameters.AddWithValue("cnt", ccnt);
                    cmd.Parameters.AddWithValue("pass", ppass);

                    int k = cmd.ExecuteNonQuery();
                    if (k != 0)
                    {
                        MessageBox.Show("SUCCESSFULY UPDATED", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.None);
                        con.Close();
                   
                    }
                    else
                    {
                        MessageBox.Show("UPDATION UNSUCCESSFULL", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.None);
                        con.Close();

                    }
                }
            }
            else
            {
                MessageBox.Show("PLEASE FILL THE FORM CORRECTLY", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FN_BOX.Focus();

            }

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
                MessageBox.Show("CONTACT NO MUST CONTAIN 11 DIGITS", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CNT_BOX.Focus();
                CNT_BOX.SelectAll();
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

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(STRING);
            con.Open();
            cmd = new SqlCommand("delete  from  ADMIN where USERNAME ='" + Convert.ToString(un.Text) + "'", con);
            adp = new SqlDataAdapter();
            dt = new DataTable();
            adp.SelectCommand = cmd;
            dt.Clear();
            dt.Dispose();
            adp.Dispose();
            con.Close();
            this.Hide();
            Form HM = new HOME();
            HM.Show();
        }
    }
}
