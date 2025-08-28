using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyTrade_WebApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int total = 0;
            listBox1.Items.Add("T-shirt                $10");
            total+= 10;
            listBox1.Items.Add("Charger               $6");
            total += 6;
            listBox1.Items.Add("Fries                   $3");
            total += 3;
            listBox1.Items.Add("Book                   $2");
            total += 2;

            textBox2.Text = "$" + total.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           // pictureBox1.Image = Properties.Resources.;
           // pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
          "Are you sure you want to remove all items?",
          "Confirm Remove",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Clear all items from ListBox
                listBox1.Items.Clear();

                // Reset total TextBox
                textBox2.Text = "$0.00";
            }
            // If user clicks "No", nothing happens
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                // If there are items in the list, confirm the order
                MessageBox.Show(
                    "Your order has been confirmed!",
                    "Order Confirmed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                // If no items, ask the user to select items
                MessageBox.Show(
                    "Please select items before checkout.",
                    "No Items Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
