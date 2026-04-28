using System;
using System.Windows.Forms;

namespace HomeAffairsDigitalIdentityProcessor
{
    public partial class Form1 : Form
    {
        CitizenProfile? currentProfile;

        public Form1()
        {
            InitializeComponent();
        }

        // 🔹 VALIDATE BUTTON (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            currentProfile = new CitizenProfile(
                txtName.Text,
                txtID.Text,
                cmbCitizenship.Text
            );

            string result = currentProfile.ValidateID();

            lblResults.Text = result;
        }

        // 🔹 GENERATE PROFILE BUTTON (button2)
        private void button2_Click(object sender, EventArgs e)
        {
            if (currentProfile == null)
            {
                MessageBox.Show("Please validate ID first.");
                return;
            }

            string summary =
                "==== DIGITAL CITIZEN SUMMARY ====\r\n" +
                "Name: " + currentProfile.FullName + "\r\n" +
                "ID Number: " + currentProfile.IDNumber + "\r\n" +
                "Age: " + currentProfile.Age + "\r\n" +
                "Citizenship: " + currentProfile.CitizenshipStatus + "\r\n" +
                "Validation: " + currentProfile.ValidateID() + "\r\n" +
                "Processed at: Home Affairs Digital Desk\r\n" +
                "Timestamp: " + DateTime.Now;

            txtResult.Text = summary;
        }

        // 🔹 EMPTY METHODS (to remove your errors)
        private void txtID_TextChanged(object sender, EventArgs e) { }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (currentProfile == null)
            {
                MessageBox.Show("Please validate ID first.");
                return;
            }

            string summary =
                "==== DIGITAL CITIZEN SUMMARY ====\r\n" +
                "Name: " + currentProfile.FullName + "\r\n" +
                "ID Number: " + currentProfile.IDNumber + "\r\n" +
                "Age: " + currentProfile.Age + "\r\n" +
                "Citizenship: " + currentProfile.CitizenshipStatus + "\r\n" +
                "Validation: " + currentProfile.ValidateID() + "\r\n" +
                "Processed at: Home Affairs Digital Desk\r\n" +
                "Timestamp: " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            txtResult.Text = summary;
        }
    }
}