namespace question_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPublishNotification = new Button();
            btnManageSubscription = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnPublishNotification
            // 
            btnPublishNotification.Location = new Point(460, 47);
            btnPublishNotification.Name = "btnPublishNotification";
            btnPublishNotification.Size = new Size(217, 86);
            btnPublishNotification.TabIndex = 0;
            btnPublishNotification.Text = "Publish Notification";
            btnPublishNotification.UseVisualStyleBackColor = true;
            btnPublishNotification.Click += btnPublishNotification_Click;
            // 
            // btnManageSubscription
            // 
            btnManageSubscription.Location = new Point(99, 47);
            btnManageSubscription.Name = "btnManageSubscription";
            btnManageSubscription.Size = new Size(214, 86);
            btnManageSubscription.TabIndex = 1;
            btnManageSubscription.Text = "Manage Subscription";
            btnManageSubscription.UseVisualStyleBackColor = true;
            btnManageSubscription.Click += btnManageSubscription_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(646, 214);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(142, 41);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 267);
            Controls.Add(btnExit);
            Controls.Add(btnManageSubscription);
            Controls.Add(btnPublishNotification);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        public Button btnPublishNotification;
        public Button btnManageSubscription;
        private Button btnExit;
    }
}