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
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            PVisble.BackColor = Color.CornflowerBlue;
            label1.Visible=true;
            label2.Visible=true;
            label3.Visible=true;
            labl4.Visible=true;
            label6.Visible=true;
            PArrowL.Visible=true;
        }

        private void PArrowL_Click(object sender, EventArgs e)
        {
            PVisble.BackColor = Color.MidnightBlue;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            labl4.Visible = false;
            label6.Visible = false;
            PArrowL.Visible = false;
        }

        private void PApplications_DragEnter(object sender, DragEventArgs e)
        {
           
        }

        private void PPeople_DragEnter(object sender, DragEventArgs e)
        {
           
        }

        private void PDrivers_DragEnter(object sender, DragEventArgs e)
        {
           
        }

        private void PUseres_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void PAccountSettings_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void PPeople_Click(object sender, EventArgs e)
        {
            PeopleScreen fromPeopleScreen = new PeopleScreen();
            fromPeopleScreen.ShowDialog();
        }

        private void PApplications_Click(object sender, EventArgs e)
        {
            ApplicationsScreen fromApplicationsScreen = new ApplicationsScreen();
            fromApplicationsScreen.ShowDialog();
        }

        private void PDrivers_Click(object sender, EventArgs e)
        {
DriversScreen fromDriversScreen = new DriversScreen();
            fromDriversScreen.ShowDialog();
        }

        private void PUseres_Click(object sender, EventArgs e)
        {
            UsersScreen fromUsersScreen = new UsersScreen();
            fromUsersScreen.ShowDialog();
        }

        private void PAccountSettings_Click(object sender, EventArgs e)
        {
            AccountSettingsScreen fromAccountsScreen = new AccountSettingsScreen();
            fromAccountsScreen.ShowDialog();
        }

        

        private void PPeople_MouseEnter(object sender, EventArgs e)
        {
            PPeople.BackColor = Color.LightSkyBlue;
        }

        private void PDrivers_MouseEnter(object sender, EventArgs e)
        {
            PDrivers.BackColor = Color.LightSkyBlue;
        }

        private void PUseres_MouseEnter(object sender, EventArgs e)
        {
            PUseres.BackColor = Color.LightSkyBlue;
        }

        private void PAccountSettings_MouseEnter(object sender, EventArgs e)
        {
            PAccountSettings.BackColor = Color.LightSkyBlue;
        }

        private void PApplications_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void PPeople_MouseLeave(object sender, EventArgs e)
        {
            PPeople.BackColor = Color.CornflowerBlue;
        }

        private void PDrivers_MouseLeave(object sender, EventArgs e)
        {
            PDrivers.BackColor = Color.CornflowerBlue;
        }

        private void PUseres_MouseLeave(object sender, EventArgs e)
        {
            PUseres.BackColor = Color.CornflowerBlue;
        }

        private void PAccountSettings_MouseLeave(object sender, EventArgs e)
        {
            PAccountSettings.BackColor = Color.CornflowerBlue;
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {

        }

        private void PApplications_MouseEnter_1(object sender, EventArgs e)
        {
            PApplications.BackColor = Color.LightSkyBlue;
        }

        private void PApplications_MouseLeave(object sender, EventArgs e)
        {
            PApplications.BackColor = Color.CornflowerBlue;
        }

        private void PArrowR_MouseEnter(object sender, EventArgs e)
        {
            PArrowR.BackColor = Color.LightSkyBlue;
        }

        private void PArrowR_MouseLeave(object sender, EventArgs e)
        {
            PArrowR.BackColor = Color.CornflowerBlue;
        }

        private void PArrowL_MouseEnter(object sender, EventArgs e)
        {
            PArrowL.BackColor = Color.LightSkyBlue;
        }

        private void PArrowL_MouseLeave(object sender, EventArgs e)
        {
            PArrowL.BackColor = Color.CornflowerBlue;
        }
    }
}
