using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyTrade_WebApp
{
    public partial class Register : Form
    {
        // Path to existing text file
        string filePath = @"C:\Users\vrajp\source\repos\PolyTrade_WebApp\RegisterData.txt";
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Get values from the form
            string fullName = textBox1.Text.Trim();
            string username = textBox2.Text.Trim();
            string studentId = textBox3.Text.Trim();
            string email = textBox4.Text.Trim();
            string password = textBox5.Text.Trim();
            string confirmPassword = textBox6.Text.Trim();

            // === Validate required fields ===
            if (string.IsNullOrEmpty(fullName))
            {
                MessageBox.Show("Full Name is required!", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            // No space on username
            if (username.Contains(" "))
            {
                MessageBox.Show("Username cannot contain spaces!", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                return;
            }

            if (!Regex.IsMatch(studentId, @"^[0-9]+$"))
            {
                MessageBox.Show("Student ID must contain only numbers!", "Invalid Student ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
                return;
            }

            // === Email Validation: Must end with @gmail.com or @microsoft.com ===
            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@(gmail|microsoft)\.com$"))
            {
                MessageBox.Show("Email must be have @gmail.com!", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Focus();
                return;
            }
           
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password is required!", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox5.Focus();
                return;
            }

            if (string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Confirm Password is required!", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox6.Focus();
                return;
            }

            // Check if password and confirm password match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox5.Clear();
                textBox6.Clear();
                textBox5.Focus();
                return;
            }

            try
            {
                // === Save the data using StreamWriter ===
                using (StreamWriter writer = new StreamWriter(filePath, true)) // true = append mode
                {
                    writer.WriteLine("Full Name: " + fullName);
                    writer.WriteLine("Username: " + username);
                    writer.WriteLine("Student ID: " + studentId);
                    writer.WriteLine("Email ID: " + email);
                    writer.WriteLine("Password: " + password);
                    writer.WriteLine("--------------------------------------");
                }

                // === Read the file back to confirm ===
                using (StreamReader reader = new StreamReader(filePath))
                {
                    Console.WriteLine(reader.ReadToEnd()); // Optional, just for checking in debug console
                }
                // Show success message
                MessageBox.Show("Registration successful! Data saved to file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear all fields after successful registration
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
