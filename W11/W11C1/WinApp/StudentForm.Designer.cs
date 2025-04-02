namespace WinApp
{
    partial class StudentForm
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
            grpStudent2 = new GroupBox();
            lbl_Name = new Label();
            txtYob = new TextBox();
            txtName = new TextBox();
            lbl_YoB = new Label();
            lbl_id = new Label();
            txt_Id = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            grpStudent2.SuspendLayout();
            SuspendLayout();
            // 
            // grpStudent2
            // 
            grpStudent2.Controls.Add(btnAdd);
            grpStudent2.Controls.Add(lbl_Name);
            grpStudent2.Controls.Add(txtYob);
            grpStudent2.Controls.Add(txtName);
            grpStudent2.Controls.Add(lbl_YoB);
            grpStudent2.Controls.Add(lbl_id);
            grpStudent2.Controls.Add(txt_Id);
            grpStudent2.Location = new Point(12, 27);
            grpStudent2.Name = "grpStudent2";
            grpStudent2.Size = new Size(251, 239);
            grpStudent2.TabIndex = 8;
            grpStudent2.TabStop = false;
            grpStudent2.Text = "Students";
           
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Location = new Point(25, 94);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(52, 20);
            lbl_Name.TabIndex = 2;
            lbl_Name.Text = "Name:";
            // 
            // txtYob
            // 
            txtYob.Location = new Point(97, 128);
            txtYob.Name = "txtYob";
            txtYob.Size = new Size(125, 27);
            txtYob.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(97, 91);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 0;
            // 
            // lbl_YoB
            // 
            lbl_YoB.AutoSize = true;
            lbl_YoB.Location = new Point(27, 134);
            lbl_YoB.Name = "lbl_YoB";
            lbl_YoB.Size = new Size(37, 20);
            lbl_YoB.TabIndex = 5;
            lbl_YoB.Text = "YoB:";
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(26, 51);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(25, 20);
            lbl_id.TabIndex = 3;
            lbl_id.Text = "Id:";
            // 
            // txt_Id
            // 
            txt_Id.Location = new Point(97, 51);
            txt_Id.Name = "txt_Id";
            txt_Id.Size = new Size(125, 27);
            txt_Id.TabIndex = 4;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.Location = new Point(196, 317);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 9;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(96, 317);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 358);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(grpStudent2);
            Name = "StudentForm";
            Text = "StudentForm";
            Load += StudentForm_Load;
            grpStudent2.ResumeLayout(false);
            grpStudent2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpStudent2;
        private Button btnAdd;
        private Label lbl_Name;
        private TextBox txtYob;
        private TextBox txtName;
        private Label lbl_YoB;
        private Label lbl_id;
        private TextBox txt_Id;
        private Button btnOK;
        private Button btnCancel;
    }
}