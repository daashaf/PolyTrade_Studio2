using System;
using System.Linq;
using System.Windows.Forms;

namespace PolyTrade_WebApp
{
    public partial class Dashbaord : Form   // ✅ spelling fixed
    {
        public Dashbaord()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        // Clothing
        private void button1_Click(object sender, EventArgs e)
        {
            Clothing category1 = new Clothing();
            category1.Show();
        }

        // Stationary
        private void button2_Click(object sender, EventArgs e)
        {
            Stationary category2 = new Stationary();
            category2.Show();
        }

        // Footwear
        private void button3_Click(object sender, EventArgs e)
        {
            footwear category3 = new footwear();
            category3.Show();
        }

        // Snacks
        private void button4_Click(object sender, EventArgs e)
        {
            snacks category4 = new snacks();
            category4.Show();
        }

        // Logout
        private void button5_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Log out and return to the Login page?",
                "Log Out",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (confirm != DialogResult.Yes) return;

            // Find an existing Login form, or create one
            var login = Application.OpenForms.OfType<Login>().FirstOrDefault();
            if (login == null || login.IsDisposed)
                login = new Login();            // Ensure your Login class is public and in the same namespace

            login.StartPosition = FormStartPosition.CenterScreen;

            // When Login closes, close this Dashboard too (clean exit)
            login.FormClosed += (s, args) => this.Close();

            login.Show();
            this.Hide(); // Hide Dashboard so the app doesn't exit if it's the main form
        }


        private void Dashbaord_Load(object sender, EventArgs e)
        {
        }
    }
}
