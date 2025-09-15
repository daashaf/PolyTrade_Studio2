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
        public Register()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Form load logic (if needed)
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

            // Username validation
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username is required!", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }
            if (username.Contains(" "))
            {
                MessageBox.Show("Username cannot contain spaces!", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                return;
            }

            // Student ID validation
            if (!Regex.IsMatch(studentId, @"^[0-9]+$"))
            {
                MessageBox.Show("Student ID must contain only numbers!", "Invalid Student ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
                return;
            }

            // Email validation
            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@(gmail|microsoft)\.com$"))
            {
                MessageBox.Show("Email must end with @gmail.com or @microsoft.com", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Focus();
                return;
            }

            // Password validation
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
                // Example: Save registration data to a file
                string filePath = "RegisterData.txt";
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine($"{fullName},{username},{studentId},{email},{password}");
                }

                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }
        private void button3_Click(object sender, EventArgs e) { }
        private void button7_Click(object sender, EventArgs e) { }
        private void button4_Click(object sender, EventArgs e) { }
        private void button5_Click(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}
