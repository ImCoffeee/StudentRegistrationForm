using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationForm
{
    public partial class frmStudentRegistrationForm : Form
    {
        public frmStudentRegistrationForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
            {
                DayComboBox.Items.Add(i);
            }


            string[] months = new string[12];
            months[0] = "January";
            months[1] = "February";
            months[2] = "March";
            months[3] = "April";
            months[4] = "May";
            months[5] = "June";
            months[6] = "July";
            months[7] = "August";
            months[8] = "September";
            months[9] = "October";
            months[10] = "November";
            months[11] = "December";
            foreach(string month in months)
            {
                MonthComboBox.Items.Add(month);
            }

            int currentYear = DateTime.Now.Year;
            for (int i = 1900; i <= currentYear; i++)
            {
                YearComboBox.Items.Add(i);
            }

            ArrayList programs = new ArrayList();
            programs.Add("Bachelor of Science in Computer Science");
            programs.Add("Bachelor of Science in Information Technology");
            programs.Add("Bachelor of Science in Information Systems");
            programs.Add("Bachelor of Science in Computer Engineering");
            foreach(string name in programs)
            {
                ProgramComboBox.Items.Add(name); 
            }

        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string middleName = txtMiddleName.Text;

            string gender = "";
            if (rdbMale.Checked)
            {
                gender = "Male";
            }
            else if (rdbFemale.Checked)
            {
                gender = "Female";
            }

            string day = DayComboBox.SelectedItem.ToString();
            string month = MonthComboBox.SelectedItem.ToString();
            string year = YearComboBox.SelectedItem.ToString();
            string program = ProgramComboBox.SelectedItem.ToString();

            string message = $"Student name: {firstName} {middleName} {lastName}\n" +
               $"Gender: {gender}\n" +
               $"Date of birth: {day}/{month}/{year}\n" +
            $"Programs: {program}";
            MessageBox.Show(message);

        }
    }
}
