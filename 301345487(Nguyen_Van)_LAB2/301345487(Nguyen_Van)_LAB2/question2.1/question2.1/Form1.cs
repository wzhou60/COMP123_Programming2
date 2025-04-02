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
    public partial class Form1 : Form
    {
        public static List<string> emailSubscribers = new List<string>();
        public static List<string> mobileSubscribers = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnManageSubscription_Click(object sender, EventArgs e)
        {
            SubscriptionForm subscriptionForm = new SubscriptionForm();
            this.Hide(); 
            subscriptionForm.ShowDialog(); 
            this.Show(); 
        }

        private void btnPublishNotification_Click(object sender, EventArgs e)
        {
            PublishForm publishForm = new PublishForm();
            this.Hide(); 
            publishForm.ShowDialog(); 
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
