using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{ 
    public partial class FrmRegistration : Form
    {
        public delegate long DelegateNumber();
        public delegate string DelegateText();
        public static class StudentInfoClass
        {
           
            //For strings
            public static string FirstName = "";
            public static string LastName = "";
            public static string MiddleName = "";
            public static string Address = "";
            public static string Program = "";

            //For long
            public static long Age = 0;
            public static long ContactNo = 0;
            public static long StudentNo = 0;
            



            //static methods with return types
            public static String GetFirstName()
            {
                return FirstName;
            }
            public static String GetLastName()
            {
                return LastName;
            }
            public static String GetMiddleName()
            {
                return MiddleName;
            }
            public static String GetAddress()
            {
                return Address;
            }
            public static String GetProgram()
            {
                return Program;
            }
            public static long GetAge()
            {
                return Age;
            }
            public static long GetContactNo()
            {
                return ContactNo;
            }
            public static long GetStudentNo()
            {
                return StudentNo;
            }

            
        }
        public FrmRegistration()
        {

            InitializeComponent();
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Program_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            StudentInfoClass.Address = Convert.ToString(txtbox_Address.Text.ToString());
            StudentInfoClass.StudentNo = Convert.ToInt32(txtbox_StudentNumber.Text.ToString());
            StudentInfoClass.MiddleName = Convert.ToString(txtbox_MiddleName.Text.ToString());
            StudentInfoClass.LastName = Convert.ToString(txtbox_LastName.Text.ToString());
            StudentInfoClass.Program = Convert.ToString(ComboBox_Program.Text.ToString());
            StudentInfoClass.FirstName = Convert.ToString(txtbox_FirstName.Text.ToString());
            StudentInfoClass.Age = Convert.ToInt32(txtbox_Age.Text.ToString());
            StudentInfoClass.ContactNo = Convert.ToInt64(txtbox_ContactNumber.Text.ToString());
            FrmConfirm frmconfirm = new FrmConfirm();
            frmconfirm.ShowDialog();


        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txtbox_Address.Clear();
            txtbox_Age.Clear();
            txtbox_ContactNumber.Clear();
            txtbox_FirstName.Clear();
            txtbox_LastName.Clear();
            txtbox_MiddleName.Clear();
            txtbox_StudentNumber.Clear();
            ComboBox_Program.ResetText();



        }
    }
}

