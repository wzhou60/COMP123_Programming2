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
    public partial class PublishForm : Form
    {
        public PublishForm()
        {
            InitializeComponent();
        }
        private void btnSendNotification_Click(object sender, EventArgs e)
        {
            string message = txtMessege.Text.Trim();

            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Message cannot be empty!");
                return;
            }

            StringBuilder emailMessages = new StringBuilder();
            StringBuilder mobileMessages = new StringBuilder();

            foreach (string email in Form1.emailSubscribers)
            {
                emailMessages.AppendLine($"📧 Email sent to {email}: {message}");
            }

            foreach (string mobile in Form1.mobileSubscribers)
            {
                mobileMessages.AppendLine($"📱 SMS sent to {mobile}: {message}");
            }

            
            StringBuilder allMessages = new StringBuilder();
            allMessages.AppendLine(emailMessages.ToString());
            allMessages.AppendLine(mobileMessages.ToString());

            if (allMessages.Length > 0)
            {
                MessageBox.Show(allMessages.ToString(), "Notifications Sent");
            }
            else
            {
                MessageBox.Show("No subscribers found to send notifications.");
            }
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSendNotification_Click_1(object sender, EventArgs e)
        {

        }
    }
}
