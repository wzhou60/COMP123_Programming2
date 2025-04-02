namespace question_2
{
    partial class PublishForm
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
            lblmessege = new Label();
            txtMessege = new RichTextBox();
            btnSendNotification = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblmessege
            // 
            lblmessege.AutoSize = true;
            lblmessege.Font = new Font("Segoe UI", 20F);
            lblmessege.Location = new Point(44, 20);
            lblmessege.Name = "lblmessege";
            lblmessege.Size = new Size(231, 37);
            lblmessege.TabIndex = 2;
            lblmessege.Text = "Enter Notification:";
            // 
            // txtMessege
            // 
            txtMessege.Location = new Point(46, 60);
            txtMessege.Name = "txtMessege";
            txtMessege.Size = new Size(706, 306);
            txtMessege.TabIndex = 3;
            txtMessege.Text = "";
            // 
            // btnSendNotification
            // 
            btnSendNotification.Location = new Point(44, 372);
            btnSendNotification.Name = "btnSendNotification";
            btnSendNotification.Size = new Size(112, 54);
            btnSendNotification.TabIndex = 5;
            btnSendNotification.Text = "Send Notification";
            btnSendNotification.UseVisualStyleBackColor = true;
            btnSendNotification.Click += btnSendNotification_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(640, 372);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 54);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // PublishForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSendNotification);
            Controls.Add(txtMessege);
            Controls.Add(lblmessege);
            Name = "PublishForm";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblmessege;
        private RichTextBox txtMessege;
        private Button btnSendNotification;
        private Button btnCancel;
    }
}