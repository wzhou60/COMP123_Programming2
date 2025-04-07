namespace JackieZ_Group3_Lab89
{
    partial class CourseEditor
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
            txt_CourseName = new TextBox();
            lbl_CourseName = new Label();
            lbl_CourseCode = new Label();
            txt_CourseCode = new TextBox();
            btn_OK = new Button();
            btn_Cancel = new Button();
            SuspendLayout();
            // 
            // txt_CourseName
            // 
            txt_CourseName.Location = new Point(50, 76);
            txt_CourseName.Name = "txt_CourseName";
            txt_CourseName.Size = new Size(250, 27);
            txt_CourseName.TabIndex = 35;
            // 
            // lbl_CourseName
            // 
            lbl_CourseName.AutoSize = true;
            lbl_CourseName.Location = new Point(50, 53);
            lbl_CourseName.Name = "lbl_CourseName";
            lbl_CourseName.Size = new Size(151, 20);
            lbl_CourseName.TabIndex = 34;
            lbl_CourseName.Text = "Enter a Course Name:";
            // 
            // lbl_CourseCode
            // 
            lbl_CourseCode.AutoSize = true;
            lbl_CourseCode.Location = new Point(50, 132);
            lbl_CourseCode.Name = "lbl_CourseCode";
            lbl_CourseCode.Size = new Size(146, 20);
            lbl_CourseCode.TabIndex = 32;
            lbl_CourseCode.Text = "Enter a Course Code:";
            // 
            // txt_CourseCode
            // 
            txt_CourseCode.Location = new Point(50, 155);
            txt_CourseCode.Multiline = true;
            txt_CourseCode.Name = "txt_CourseCode";
            txt_CourseCode.Size = new Size(250, 29);
            txt_CourseCode.TabIndex = 30;
            // 
            // btn_OK
            // 
            btn_OK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_OK.Location = new Point(141, 279);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(94, 30);
            btn_OK.TabIndex = 29;
            btn_OK.Text = "OK";
            btn_OK.UseVisualStyleBackColor = true;
            btn_OK.Click += btn_OK_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Cancel.Location = new Point(243, 279);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(94, 30);
            btn_Cancel.TabIndex = 36;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // CourseEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 321);
            Controls.Add(btn_Cancel);
            Controls.Add(txt_CourseName);
            Controls.Add(lbl_CourseName);
            Controls.Add(lbl_CourseCode);
            Controls.Add(txt_CourseCode);
            Controls.Add(btn_OK);
            Name = "CourseEditor";
            Text = "Edit Course";
            Load += CourseEditor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_CourseName;
        private Label lbl_CourseName;
        private Label lbl_CourseCode;
        private TextBox txt_CourseCode;
        private Button btn_OK;
        private Button btn_Cancel;
    }
}