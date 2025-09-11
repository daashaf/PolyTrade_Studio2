using System;
using System.Windows.Forms;

namespace PolyTrade_WebApp
{
    public partial class Login : Form
    {
        private StoreData store;

        public Login()
        {
            InitializeComponent();
            store = new StoreData();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string Username = textBox1.Text.Trim();
            string Password = textBox2.Text.Trim();

            if (store.ValidateUser(Username, Password))
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ✅ Open Dashboard after login
                Dashbaord dashboardForm = new Dashbaord();
                dashboardForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }
    }
}
