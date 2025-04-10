namespace JackieZ_Group3_Lab89
{
    partial class CourseManagerForm
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
            txt_CourseID = new TextBox();
            btn_DeleteCourse = new Button();
            lbl_CourseCode = new Label();
            lbl_CourseID = new Label();
            txt_CourseCode = new TextBox();
            btn_CourseEdit = new Button();
            btn_CourseAdd = new Button();
            lbx_CourseList = new ListBox();
            txt_CourseName = new TextBox();
            lbl_CourseName = new Label();
            btn_ViewEvals = new Button();
            grp_AddCourse = new GroupBox();
            txt_CourseSem = new TextBox();
            lblCourseSem = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lbl_Title = new Label();
            lbl_Header = new Label();
            btn_Exit = new Button();
            grp_AddCourse.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_CourseID
            // 
            txt_CourseID.Location = new Point(15, 111);
            txt_CourseID.Name = "txt_CourseID";
            txt_CourseID.Size = new Size(277, 27);
            txt_CourseID.TabIndex = 26;
            // 
            // btn_DeleteCourse
            // 
            btn_DeleteCourse.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_DeleteCourse.Location = new Point(755, 409);
            btn_DeleteCourse.Name = "btn_DeleteCourse";
            btn_DeleteCourse.Size = new Size(137, 29);
            btn_DeleteCourse.TabIndex = 25;
            btn_DeleteCourse.Text = "Delete Course";
            btn_DeleteCourse.UseVisualStyleBackColor = true;
            // 
            // lbl_CourseCode
            // 
            lbl_CourseCode.AutoSize = true;
            lbl_CourseCode.Location = new Point(15, 147);
            lbl_CourseCode.Name = "lbl_CourseCode";
            lbl_CourseCode.Size = new Size(207, 20);
            lbl_CourseCode.TabIndex = 24;
            lbl_CourseCode.Text = "Course Code (ABCD###):";
            // 
            // lbl_CourseID
            // 
            lbl_CourseID.AutoSize = true;
            lbl_CourseID.Location = new Point(15, 88);
            lbl_CourseID.Name = "lbl_CourseID";
            lbl_CourseID.Size = new Size(207, 20);
            lbl_CourseID.TabIndex = 23;
            lbl_CourseID.Text = "Course ID (#########):";
            // 
            // txt_CourseCode
            // 
            txt_CourseCode.Location = new Point(15, 169);
            txt_CourseCode.Multiline = true;
            txt_CourseCode.Name = "txt_CourseCode";
            txt_CourseCode.Size = new Size(277, 29);
            txt_CourseCode.TabIndex = 21;
            // 
            // btn_CourseEdit
            // 
            btn_CourseEdit.Enabled = false;
            btn_CourseEdit.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CourseEdit.Location = new Point(630, 409);
            btn_CourseEdit.Name = "btn_CourseEdit";
            btn_CourseEdit.Size = new Size(119, 29);
            btn_CourseEdit.TabIndex = 20;
            btn_CourseEdit.Text = "Edit Course";
            btn_CourseEdit.UseVisualStyleBackColor = true;
            btn_CourseEdit.Click += btn_CourseEdit_Click;
            // 
            // btn_CourseAdd
            // 
            btn_CourseAdd.Anchor = AnchorStyles.Bottom;
            btn_CourseAdd.Location = new Point(103, 271);
            btn_CourseAdd.Name = "btn_CourseAdd";
            btn_CourseAdd.Size = new Size(112, 29);
            btn_CourseAdd.TabIndex = 19;
            btn_CourseAdd.Text = "Add Course";
            btn_CourseAdd.UseVisualStyleBackColor = true;
            btn_CourseAdd.Click += btn_CourseAdd_Click;
            // 
            // lbx_CourseList
            // 
            lbx_CourseList.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbx_CourseList.FormattingEnabled = true;
            lbx_CourseList.HorizontalScrollbar = true;
            lbx_CourseList.ItemHeight = 18;
            lbx_CourseList.Location = new Point(346, 212);
            lbx_CourseList.Name = "lbx_CourseList";
            lbx_CourseList.Size = new Size(546, 184);
            lbx_CourseList.TabIndex = 18;
            lbx_CourseList.SelectedIndexChanged += lbx_CourseList_SelectedIndexChanged;
            // 
            // txt_CourseName
            // 
            txt_CourseName.Location = new Point(15, 52);
            txt_CourseName.Name = "txt_CourseName";
            txt_CourseName.Size = new Size(277, 27);
            txt_CourseName.TabIndex = 28;
            // 
            // lbl_CourseName
            // 
            lbl_CourseName.AutoSize = true;
            lbl_CourseName.Location = new Point(15, 29);
            lbl_CourseName.Name = "lbl_CourseName";
            lbl_CourseName.Size = new Size(117, 20);
            lbl_CourseName.TabIndex = 27;
            lbl_CourseName.Text = "Course Name:";
            // 
            // btn_ViewEvals
            // 
            btn_ViewEvals.Enabled = false;
            btn_ViewEvals.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ViewEvals.ForeColor = Color.Black;
            btn_ViewEvals.Location = new Point(346, 411);
            btn_ViewEvals.Name = "btn_ViewEvals";
            btn_ViewEvals.Size = new Size(163, 29);
            btn_ViewEvals.TabIndex = 29;
            btn_ViewEvals.Text = "View Evaluations";
            btn_ViewEvals.UseVisualStyleBackColor = true;
            btn_ViewEvals.Click += btn_ViewEvals_Click;
            // 
            // grp_AddCourse
            // 
            grp_AddCourse.BackColor = SystemColors.GradientActiveCaption;
            grp_AddCourse.Controls.Add(txt_CourseSem);
            grp_AddCourse.Controls.Add(lblCourseSem);
            grp_AddCourse.Controls.Add(lbl_CourseName);
            grp_AddCourse.Controls.Add(txt_CourseName);
            grp_AddCourse.Controls.Add(btn_CourseAdd);
            grp_AddCourse.Controls.Add(txt_CourseCode);
            grp_AddCourse.Controls.Add(txt_CourseID);
            grp_AddCourse.Controls.Add(lbl_CourseID);
            grp_AddCourse.Controls.Add(lbl_CourseCode);
            grp_AddCourse.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grp_AddCourse.Location = new Point(14, 172);
            grp_AddCourse.Name = "grp_AddCourse";
            grp_AddCourse.Size = new Size(306, 316);
            grp_AddCourse.TabIndex = 30;
            grp_AddCourse.TabStop = false;
            grp_AddCourse.Text = "Create a Course";
            // 
            // txt_CourseSem
            // 
            txt_CourseSem.Location = new Point(15, 228);
            txt_CourseSem.Name = "txt_CourseSem";
            txt_CourseSem.Size = new Size(277, 27);
            txt_CourseSem.TabIndex = 30;
            // 
            // lblCourseSem
            // 
            lblCourseSem.AutoSize = true;
            lblCourseSem.Location = new Point(15, 205);
            lblCourseSem.Name = "lblCourseSem";
            lblCourseSem.Size = new Size(90, 20);
            lblCourseSem.TabIndex = 29;
            lblCourseSem.Text = "Semester:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 128);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbl_Title);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(879, 133);
            panel1.TabIndex = 31;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cc_logo;
            pictureBox1.Location = new Point(33, 21);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.Location = new Point(373, 41);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(282, 46);
            lbl_Title.TabIndex = 20;
            lbl_Title.Text = "Course Manager";
            // 
            // lbl_Header
            // 
            lbl_Header.AutoSize = true;
            lbl_Header.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Header.Location = new Point(523, 161);
            lbl_Header.Name = "lbl_Header";
            lbl_Header.Size = new Size(157, 37);
            lbl_Header.TabIndex = 32;
            lbl_Header.Text = "Course List";
            // 
            // btn_Exit
            // 
            btn_Exit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Exit.Font = new Font("Consolas", 9.75F);
            btn_Exit.Location = new Point(811, 492);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(94, 29);
            btn_Exit.TabIndex = 33;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // CourseManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(918, 532);
            Controls.Add(btn_Exit);
            Controls.Add(lbl_Header);
            Controls.Add(panel1);
            Controls.Add(btn_ViewEvals);
            Controls.Add(btn_DeleteCourse);
            Controls.Add(btn_CourseEdit);
            Controls.Add(lbx_CourseList);
            Controls.Add(grp_AddCourse);
            Name = "CourseManagerForm";
            Text = "Course Manager";
            grp_AddCourse.ResumeLayout(false);
            grp_AddCourse.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_CourseID;
        private Button btn_DeleteCourse;
        private Label lbl_CourseCode;
        private Label lbl_CourseID;
        private TextBox txt_CourseCode;
        private Button btn_CourseEdit;
        private Button btn_CourseAdd;
        private ListBox lbx_CourseList;
        private TextBox txt_CourseName;
        private Label lbl_CourseName;
        private Button btn_ViewEvals;
        private GroupBox grp_AddCourse;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lbl_Title;
        private Label lbl_Header;
        private Button btn_Exit;
        private TextBox txt_CourseSem;
        private Label lblCourseSem;
    }
}