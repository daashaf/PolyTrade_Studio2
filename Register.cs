using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PolyTrade_WebApp
{
    public partial class Register : Form
    {
        // Path to existing text file
        private string filePath = @"C:\Users\daash\OneDrive - Otago Polytechnic\Studio2\Sprint1\PolyTrade_Studio2\RegisterData.txt";

        public Register()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e) // Register button
        {
            // Get values from the form
            string fullName = textBox1.Text.Trim();
            string username = textBox2.Text.Trim();
            string studentId = textBox3.Text.Trim();
            string email = textBox4.Text.Trim();
            string password = textBox5.Text.Trim();
            string confirmPassword = textBox6.Text.Trim();

            // === Validation ===
            if (string.IsNullOrEmpty(fullName) ||
                string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(studentId) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required!", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (username.Contains(" "))
            {
                MessageBox.Show("Username cannot contain spaces!", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(studentId, @"^[0-9]+$"))
            {
                MessageBox.Show("Student ID must contain only numbers!", "Invalid Student ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@(gmail|microsoft)\.com$"))
            {
                MessageBox.Show("Email must end with @gmail.com or @microsoft.com!", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // === Save user in one line ===
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"{username}|{password}|{fullName}|{studentId}|{email}");
                }

                MessageBox.Show("Registration successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Redirect to Login form
                Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🔹 Added empty event handlers to match Designer wiring
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void Form2_Load(object sender, EventArgs e) { }
    }
}
