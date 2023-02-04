using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Account_Registration.FrmRegistration;

namespace Account_Registration
{

    public partial class FrmConfirm : Form
    {
        DelegateText DelProgram;
        DelegateText DelLastName;
        DelegateText DelFirstName;
        DelegateText DelMiddleName;
        DelegateText DelAddress;


        DelegateNumber DelNumAge;
        DelegateNumber DelNumContactNo;
        DelegateNumber DelStudNo;


        public FrmConfirm()
        {

            InitializeComponent();

            DelStudNo = StudentInfoClass.GetStudentNo;
            DelProgram = StudentInfoClass.GetProgram;
            DelAddress = StudentInfoClass.GetAddress;
            DelMiddleName = StudentInfoClass.GetMiddleName;
            DelLastName = StudentInfoClass.GetLastName;
            DelFirstName = StudentInfoClass.GetFirstName;
            DelNumContactNo = StudentInfoClass.GetContactNo;
            DelNumAge = StudentInfoClass.GetAge;
        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            txtbox2_StudentNumber.Text = DelStudNo().ToString();
            txtbox2_Program.Text = DelProgram().ToString();
            txtbox2_MiddleName.Text = DelMiddleName().ToString();
            txtbox2_LastName.Text = DelLastName().ToString();
            txtbox2_FirstName.Text = DelFirstName().ToString();
            txtbox2_ContactNumber.Text = DelNumContactNo().ToString();
            txtbox2_Age.Text = DelNumAge().ToString();
            txtbox2_Address.Text = DelAddress().ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmConfirm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}























