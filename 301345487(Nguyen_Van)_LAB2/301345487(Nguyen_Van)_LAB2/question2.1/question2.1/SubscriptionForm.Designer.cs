namespace question_2
{
    partial class SubscriptionForm
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
            lblEmail = new Label();
            lblMobile = new Label();
            txtMobile = new TextBox();
            txtEmail = new TextBox();
            btnSubscribe = new Button();
            btnUnsubscribe = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 20F);
            lblEmail.Location = new Point(115, 108);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(99, 37);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-mail:";
            lblEmail.Click += lblEmail_Click;
            // 
            // lblMobile
            // 
            lblMobile.AutoSize = true;
            lblMobile.Font = new Font("Segoe UI", 20F);
            lblMobile.Location = new Point(12, 27);
            lblMobile.Name = "lblMobile";
            lblMobile.Size = new Size(202, 37);
            lblMobile.TabIndex = 2;
            lblMobile.Text = "Phone Number:";
            // 
            // txtMobile
            // 
            txtMobile.Font = new Font("Segoe UI", 20F);
            txtMobile.Location = new Point(218, 27);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(433, 43);
            txtMobile.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 20F);
            txtEmail.Location = new Point(220, 105);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(433, 43);
            txtEmail.TabIndex = 4;
            // 
            // btnSubscribe
            // 
            btnSubscribe.Location = new Point(220, 197);
            btnSubscribe.Name = "btnSubscribe";
            btnSubscribe.Size = new Size(164, 92);
            btnSubscribe.TabIndex = 5;
            btnSubscribe.Text = "Subscribe";
            btnSubscribe.UseVisualStyleBackColor = true;
            btnSubscribe.Click += btnSubscribe_Click;
            // 
            // btnUnsubscribe
            // 
            btnUnsubscribe.Location = new Point(478, 197);
            btnUnsubscribe.Name = "btnUnsubscribe";
            btnUnsubscribe.Size = new Size(164, 92);
            btnUnsubscribe.TabIndex = 6;
            btnUnsubscribe.Text = "Unsubscribe";
            btnUnsubscribe.UseVisualStyleBackColor = true;
            btnUnsubscribe.Click += btnUnsubscribe_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 386);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(124, 52);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // SubscriptionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnUnsubscribe);
            Controls.Add(btnSubscribe);
            Controls.Add(txtEmail);
            Controls.Add(txtMobile);
            Controls.Add(lblMobile);
            Controls.Add(lblEmail);
            Name = "SubscriptionForm";
            Text = "SubscriptionForm";
            Load += SubscriptionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblEmail;
        private Label lblMobile;
        private TextBox txtMobile;
        private TextBox txtEmail;
        private Button btnSubscribe;
        private Button btnUnsubscribe;
        private Button btnCancel;
    }
}