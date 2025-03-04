using ContactsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealProjectWinFormCoures19
{
    public partial class frmLoginForm : Form
    {
        public frmLoginForm()
        {
            InitializeComponent();
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            if (clsPersons.LoginSciner(tUserName.Text.ToString(),tPassword.Text.ToString()))
            {
                
                frmMainForm frmMainForm = new frmMainForm();
            frmMainForm.ShowDialog();
                this.Close();
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
