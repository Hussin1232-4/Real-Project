using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsBusinessLayer;
using System.Windows.Forms;

namespace RealProjectWinFormCoures19
{
    public partial class PeopleScreen : Form
    {
        public PeopleScreen()
        {
            InitializeComponent();
        }
        private void RefreshPersonsInfo()
        {

            if (CBFilterBy.SelectedIndex == 0)
                DGVManagePeople.DataSource = clsPersons.AllPersonsInfo();
            else if (CBFilterBy.SelectedIndex == 1)
                DGVManagePeople.DataSource = clsPersons.AllPersonsInfoBy("PersonID");
            else if (CBFilterBy.SelectedIndex == 2)
                DGVManagePeople.DataSource = clsPersons.AllPersonsInfoBy("NationalNo");
            else if (CBFilterBy.SelectedIndex == 3)
                DGVManagePeople.DataSource = clsPersons.AllPersonsInfoBy("FirstName");
            else if (CBFilterBy.SelectedIndex == 4)
                DGVManagePeople.DataSource = clsPersons.AllPersonsInfoBy("SecondName");
            else if (CBFilterBy.SelectedIndex == 5)
                DGVManagePeople.DataSource = clsPersons.AllPersonsInfoBy("ThirdName");
            else if (CBFilterBy.SelectedIndex == 6)
                DGVManagePeople.DataSource = clsPersons.AllPersonsInfoBy("LastName");
            else if (CBFilterBy.SelectedIndex == 7)
                DGVManagePeople.DataSource = clsPersons.AllPersonsInfoBy("NationalityCountryID");
            else if (CBFilterBy.SelectedIndex == 8)
                DGVManagePeople.DataSource = clsPersons.AllPersonsInfoBy("Gendor");
            else if (CBFilterBy.SelectedIndex == 9)
                DGVManagePeople.DataSource = clsPersons.AllPersonsInfoBy("Phone");
            else if (CBFilterBy.SelectedIndex == 10)
                DGVManagePeople.DataSource = clsPersons.AllPersonsInfoBy("Email");
            



        }
        private void PeopleScreen_Load(object sender, EventArgs e)
        {
            CBFilterBy.SelectedIndex = 0;
            RefreshPersonsInfo();
            LNumberOfPeople.Text=clsPersons.GetNumberOfPersons().ToString();
        }

        private void BExPeopleScreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshPersonsInfo();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AddNewPersonScreen frmAddNewPersonScreen= new AddNewPersonScreen();
            frmAddNewPersonScreen.ShowDialog();
        }

        private void TBSearch_TextChanged(object sender, EventArgs e)
        {
            if(TBSearch.Text=="")
            {
                RefreshPersonsInfo();

            }else
            {
               
DGVManagePeople.DataSource=clsPersons.FindPersonByPersonID(int.Parse(TBSearch.Text));


            }
        }

        private void PAddNewPerson_MouseEnter(object sender, EventArgs e)
        {
            PAddNewPerson.BackColor = Color.LightSkyBlue;
        }

        private void PAddNewPerson_MouseLeave(object sender, EventArgs e)
        {
            PAddNewPerson.BackColor = Color.MidnightBlue;
        }

        private void BTRefrash_Click(object sender, EventArgs e)
        {
            RefreshPersonsInfo();
        }

        private void cmsShowDetails_Click(object sender, EventArgs e)
        {
            PersonDetails frmPersonDetails = new PersonDetails();
            frmPersonDetails.ShowDialog();
        }

        private void cmsAddNewPerson_Click(object sender, EventArgs e)
        {
            AddNewPersonScreen frmAddNewPersonScreen = new AddNewPersonScreen();
            frmAddNewPersonScreen.ShowDialog();
        }

        private void cmsDelete_Click(object sender, EventArgs e)
        {
            DeleteScreen frmDeleteScreen = new DeleteScreen();
            frmDeleteScreen.ShowDialog();
        }

        private void cmsUpdate_Click(object sender, EventArgs e)
        {
            UpdateScreen frmUpdateScreen = new UpdateScreen();
            frmUpdateScreen.ShowDialog();
        }
    }
}
