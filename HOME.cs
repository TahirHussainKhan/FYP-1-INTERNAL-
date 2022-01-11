using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DASPP
{
    public partial class HOME : Form
    {
       
        public HOME()
        {
            InitializeComponent();
            
          
        }

        private void ADMIN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form ADMINLOGIN = new ADMIN_LOGIN();
            ADMINLOGIN.Show();
        }

        private void USER_Click(object sender, EventArgs e)
        {
        
            this.Hide();
            Form USERLOGIN = new USER_LOGIN();
            USERLOGIN.Show();

        }

        private void ABOUT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form ABOUT = new ABOUT();
             ABOUT.Show();

        }

        private void CONTACT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form CONTACT = new CONTACT();
            CONTACT.Show();

        }

        private void END_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HOME_Load(object sender, EventArgs e)
        {

        }

     
    }
}
