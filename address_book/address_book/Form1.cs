using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace address_book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            string username = nameInput.Text;
            string email = emailInput.Text;
            string phone = phoneInput.Text;
            if(username.Length==0 || email.Length==0 || phone.Length==0)
            {
                MessageBox.Show("Please fill all input is required");
                return;
            }
            MessageBox.Show("Details Saved Successfully");
        }
    }
}
