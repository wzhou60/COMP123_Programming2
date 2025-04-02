using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace question_2
{
    public partial class SubscriptionForm : Form
    {
        public SubscriptionForm()
        {
            InitializeComponent();
        }
        private void SubscriptionForm_Load(object sender, EventArgs e)
        {

        }
        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        public void btnSubscribe_Click(object sender, EventArgs e)
        {


            string email = txtEmail.Text.Trim();
            string mobile = txtMobile.Text.Trim();

            if (!string.IsNullOrEmpty(email) && !Form1.emailSubscribers.Contains(email))
            {
                Form1.emailSubscribers.Add(email);
                MessageBox.Show("Email Subscribed!");
            }

            if (!string.IsNullOrEmpty(mobile) && !Form1.mobileSubscribers.Contains(mobile))
            {
                Form1.mobileSubscribers.Add(mobile);
                MessageBox.Show("Mobile Subscribed!");
            }


    ((Form1)Application.OpenForms["Form1"]). btnPublishNotification.Enabled = true;
        }


        private void btnUnsubscribe_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string mobile = txtMobile.Text.Trim();

            if (Form1.emailSubscribers.Contains(email))
            {
                Form1.emailSubscribers.Remove(email);
                MessageBox.Show("Email Unsubscribed!");
            }
            if (Form1.mobileSubscribers.Contains(mobile))
            {
                Form1.mobileSubscribers.Remove(mobile);
                MessageBox.Show("Mobile Unsubscribed!");
            }
        }
    }
}
