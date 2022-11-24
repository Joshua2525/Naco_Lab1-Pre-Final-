using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naco_Prefi1
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string getStudentNo = txtStudentNo.Text;
            string getLastName = txtLastName.Text;
            string getAge = txtAge.Text;
            string getBirthday = txtBirthday.Text;
            string getProgram = txtProgram.Text;
            string getFirstName = txtFirstName.Text;
            string getMi = txtMi.Text; 
            string getGender = txtGender.Text;
            string getContact = txtContactNo.Text;


            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, getStudentNo + ".txt" )))
            {

                outputFile.WriteLine("Student No: " + getStudentNo);
                outputFile.WriteLine("Full Name: " + getLastName + ", " + getFirstName + ", " +  getMi);
                outputFile.WriteLine("Program: " + getProgram);
                outputFile.WriteLine("Gender: " + getGender);
                outputFile.WriteLine("Age: " + getAge);
                outputFile.WriteLine("Birtday" + getBirthday);
                outputFile.WriteLine("Contact No: " + getContact);


                Console.WriteLine(getStudentNo);

            }
            this.Close();

        }
    }
}
