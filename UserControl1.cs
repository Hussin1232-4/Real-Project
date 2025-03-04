using ContactsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RealProjectWinFormCoures19
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        private void _FillAllCountys()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {

                CBCountry.Items.Add(row["CountryName"]);

            }
            CBCountry.SelectedIndex = 90;
        }
        private void _Load()
        {
            _FillAllCountys();

            DTPDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
           


        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            _Load();
        }

        private void LLSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(OFDPPerson.ShowDialog()==DialogResult.OK)
            {


                PPerson.ImageLocation = OFDPPerson.FileName;
                LLRemove.Visible = true;
            }
        }
        private bool isCoractOrWong()
        {
            bool isAllOk = true;
            if (string.IsNullOrWhiteSpace(TBNationalNo.Text))
            {

                errorProvider1.SetError(TBNationalNo, "National No is Null Or White Space");
                isAllOk = false;
            }
            else if (clsPersons.isNationalNoExist(TBNationalNo.Text))
            {

                errorProvider1.SetError(TBNationalNo, "NationalNo is Exist");
                isAllOk = false;
            }
            else
            {

                errorProvider1.SetError(TBNationalNo, "");
                
            }
            if (string.IsNullOrWhiteSpace(TBFirstName.Text))
            {

                errorProvider1.SetError(TBFirstName, "First Name is Null Or White Space");
                isAllOk = false;
            }
            else
            {

                errorProvider1.SetError(TBFirstName, "");
               
            }
            if (string.IsNullOrWhiteSpace(TBSecondName.Text))
            {

                errorProvider1.SetError(TBSecondName, "Second Name is Null Or White Space");
                isAllOk = false;
            }
            else
            {

                errorProvider1.SetError(TBSecondName, "");
               
            }
            if (string.IsNullOrWhiteSpace(TBLastName.Text))
            {

                errorProvider1.SetError(TBLastName, "Therd Name is Null Or White Space");
                isAllOk = false;
            }
            else
            {

                errorProvider1.SetError(TBLastName, "");
               
            }


            if (string.IsNullOrWhiteSpace(TBAdress.Text))
            {

                errorProvider1.SetError(TBAdress, "Adress is Null Or White Space");
                isAllOk = false;
            }
            else
            {

                errorProvider1.SetError(TBAdress, "");
                
            }
            if (string.IsNullOrWhiteSpace(TBPhoneNumber.Text))
            {

                errorProvider1.SetError(TBPhoneNumber, "PhoneNumber is Null Or White Space");
                isAllOk = false;
            }
            else
            {

                errorProvider1.SetError(TBPhoneNumber, "");
                
            }

            return isAllOk;
        }
        private void LLRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PPerson.ImageLocation = "C:\\Users\\Hussin\\Downloads\\PeopleScreenIcons\\famous.png";
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }
        public bool KnawWhatIsTheGendor()
        {
            if (RBGendorMale.Checked)
            {
                return false;
            }
            else if (RBGendorFemale.Checked)
            {
                return true;
            }
            
                return false;
            
        }
        private bool isPicureExist()
        {
            if (PPerson.ImageLocation == "C:\\Users\\Hussin\\Downloads\\PeopleScreenIcons\\famous.png")
            {
                return false;
            }
            return true;
        }
        private void BSave_Click(object sender, EventArgs e)
        {

            bool Gendor = KnawWhatIsTheGendor();

            if(isCoractOrWong()==false)
            {
                return;

            }
            if (MessageBox.Show("Are You Sure To Save", "Save", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }
            string ImagePath = null;
            if (isPicureExist())
            {
                ImagePath=PPerson.ImageLocation;
            }
            if (clsPersons.SavePeopleInfo(TBNationalNo.Text, TBFirstName.Text, TBSecondName.Text,
            TBThirdName.Text, tbLastNameUser.Text, DTPDateOfBirth.Value, Gendor, TBAdress.Text, TBPhoneNumber.Text, 
            TBEmail.Text, CBCountry.SelectedIndex, ImagePath))
            {

                MessageBox.Show("Save Success");
                this.FindForm().Close();

            }
            else
            {

                MessageBox.Show("Save Faild");

            }
        }
        private void TBNationalNo_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void TBNationalNo_Validating(object sender, CancelEventArgs e)
        {
            
        }
    }
}
