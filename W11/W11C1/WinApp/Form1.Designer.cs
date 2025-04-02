namespace WinApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            btnOK = new Button();
            lbl_Name = new Label();
            lbl_id = new Label();
            txt_Id = new TextBox();
            lbl_YoB = new Label();
            txtYob = new TextBox();
            grpStudent = new GroupBox();
            btnAdd = new Button();
            lbx_Students = new ListBox();
            txtCourseCode = new TextBox();
            groupBox1 = new GroupBox();
            btnCourseAdd = new Button();
            lblCourseCode = new Label();
            lblCourseName = new Label();
            txtCourseName = new TextBox();
            lbxCourse = new ListBox();
            lbxCourseStudents = new ListBox();
            label1 = new Label();
            btnAssign = new Button();
            btnStudentEdit = new Button();
            grpStudent.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(97, 91);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 0;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.Location = new Point(1027, 526);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
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
            // lbl_YoB
            // 
            lbl_YoB.AutoSize = true;
            lbl_YoB.Location = new Point(27, 134);
            lbl_YoB.Name = "lbl_YoB";
            lbl_YoB.Size = new Size(37, 20);
            lbl_YoB.TabIndex = 5;
            lbl_YoB.Text = "YoB:";
            // 
            // txtYob
            // 
            txtYob.Location = new Point(97, 128);
            txtYob.Name = "txtYob";
            txtYob.Size = new Size(125, 27);
            txtYob.TabIndex = 6;
            // 
            // grpStudent
            // 
            grpStudent.Controls.Add(btnStudentEdit);
            grpStudent.Controls.Add(lbl_Name);
            grpStudent.Controls.Add(txtYob);
            grpStudent.Controls.Add(txtName);
            grpStudent.Controls.Add(lbl_YoB);
            grpStudent.Controls.Add(lbl_id);
            grpStudent.Controls.Add(txt_Id);
            grpStudent.Location = new Point(12, 12);
            grpStudent.Name = "grpStudent";
            grpStudent.Size = new Size(251, 239);
            grpStudent.TabIndex = 7;
            grpStudent.TabStop = false;
            grpStudent.Text = "Student";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.Location = new Point(294, 236);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "AddStudent";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lbx_Students
            // 
            lbx_Students.FormattingEnabled = true;
            lbx_Students.Location = new Point(294, 12);
            lbx_Students.Name = "lbx_Students";
            lbx_Students.Size = new Size(344, 204);
            lbx_Students.TabIndex = 8;
            lbx_Students.SelectedIndexChanged += lbx_Students_SelectedIndexChanged;
            // 
            // txtCourseCode
            // 
            txtCourseCode.Location = new Point(109, 49);
            txtCourseCode.Name = "txtCourseCode";
            txtCourseCode.Size = new Size(125, 27);
            txtCourseCode.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCourseAdd);
            groupBox1.Controls.Add(lblCourseCode);
            groupBox1.Controls.Add(lblCourseName);
            groupBox1.Controls.Add(txtCourseName);
            groupBox1.Controls.Add(txtCourseCode);
            groupBox1.Location = new Point(12, 266);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(251, 229);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Course";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnCourseAdd
            // 
            btnCourseAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCourseAdd.Location = new Point(141, 179);
            btnCourseAdd.Name = "btnCourseAdd";
            btnCourseAdd.Size = new Size(94, 29);
            btnCourseAdd.TabIndex = 12;
            btnCourseAdd.Text = "Add";
            btnCourseAdd.UseVisualStyleBackColor = true;
            btnCourseAdd.Click += btnCourseAdd_Click;
            // 
            // lblCourseCode
            // 
            lblCourseCode.AutoSize = true;
            lblCourseCode.Location = new Point(6, 49);
            lblCourseCode.Name = "lblCourseCode";
            lblCourseCode.Size = new Size(94, 20);
            lblCourseCode.TabIndex = 11;
            lblCourseCode.Text = "Course code:";
            // 
            // lblCourseName
            // 
            lblCourseName.AutoSize = true;
            lblCourseName.Location = new Point(6, 121);
            lblCourseName.Name = "lblCourseName";
            lblCourseName.Size = new Size(98, 20);
            lblCourseName.TabIndex = 8;
            lblCourseName.Text = "Course name:";
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(109, 114);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(125, 27);
            txtCourseName.TabIndex = 10;
            // 
            // lbxCourse
            // 
            lbxCourse.FormattingEnabled = true;
            lbxCourse.Location = new Point(294, 310);
            lbxCourse.Name = "lbxCourse";
            lbxCourse.Size = new Size(302, 164);
            lbxCourse.TabIndex = 11;
            lbxCourse.SelectedIndexChanged += lbxCourse_SelectedIndexChanged;
            // 
            // lbxCourseStudents
            // 
            lbxCourseStudents.FormattingEnabled = true;
            lbxCourseStudents.Location = new Point(762, 57);
            lbxCourseStudents.Name = "lbxCourseStudents";
            lbxCourseStudents.Size = new Size(262, 184);
            lbxCourseStudents.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(762, 22);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 13;
            label1.Text = "Students in the Course";
            // 
            // btnAssign
            // 
            btnAssign.Location = new Point(656, 137);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(94, 29);
            btnAssign.TabIndex = 14;
            btnAssign.Text = ">";
            btnAssign.UseVisualStyleBackColor = true;
            btnAssign.Click += btnAssign_Click;
            // 
            // btnStudentEdit
            // 
            btnStudentEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnStudentEdit.Enabled = false;
            btnStudentEdit.Location = new Point(140, 200);
            btnStudentEdit.Name = "btnStudentEdit";
            btnStudentEdit.Size = new Size(94, 29);
            btnStudentEdit.TabIndex = 7;
            btnStudentEdit.Text = "Edit";
            btnStudentEdit.UseVisualStyleBackColor = true;
            btnStudentEdit.Click += btnStudentEdit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 567);
            Controls.Add(btnAdd);
            Controls.Add(btnAssign);
            Controls.Add(label1);
            Controls.Add(lbxCourseStudents);
            Controls.Add(lbxCourse);
            Controls.Add(groupBox1);
            Controls.Add(lbx_Students);
            Controls.Add(grpStudent);
            Controls.Add(btnOK);
            Name = "Form1";
            Text = "FirstWindow";
            grpStudent.ResumeLayout(false);
            grpStudent.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Button btnOK;
        private Label lbl_Name;
        private Label lbl_id;
        private TextBox txt_Id;
        private Label lbl_YoB;
        private TextBox txtYob;
        private GroupBox grpStudent;
        private Button btnAdd;
        private ListBox lbx_Students;
        private TextBox txtCourseCode;
        private GroupBox groupBox1;
        private Button btnCourseAdd;
        private Label lblCourseCode;
        private Label lblCourseName;
        private TextBox txtCourseName;
        private ListBox lbxCourse;
        private ListBox lbxCourseStudents;
        private Label label1;
        private Button btnAssign;
        private Button btnStudentEdit;
    }
}
