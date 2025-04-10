using System.Windows.Forms;

namespace JackieZ_Group3_Lab89
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
            btn_Tasks = new Button();
            btn_Course = new Button();
            btn_TaskJSONExport = new Button();
            btn_TaskJSONImport = new Button();
            btn_CoursesJSONImport = new Button();
            btn_CoursesJSONExport = new Button();
            lbl_TaskIOStatus = new Label();
            lbl_Title = new Label();
            lbl_IOCourseStatus = new Label();
            pic_Logo = new PictureBox();
            pnl_Title = new Panel();
            pnl_Tasks = new Panel();
            label2 = new Label();
            lbl_TaskDesc = new Label();
            pictureBox2 = new PictureBox();
            pnl_Courses = new Panel();
            lbl_CourseDesc = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_Logo).BeginInit();
            pnl_Title.SuspendLayout();
            pnl_Tasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnl_Courses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btn_Tasks
            // 
            btn_Tasks.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Tasks.ForeColor = SystemColors.ControlText;
            btn_Tasks.Location = new Point(102, 29);
            btn_Tasks.Name = "btn_Tasks";
            btn_Tasks.Size = new Size(203, 91);
            btn_Tasks.TabIndex = 0;
            btn_Tasks.Text = "Tasks";
            btn_Tasks.UseVisualStyleBackColor = true;
            btn_Tasks.Click += btn_Tasks_Click;
            // 
            // btn_Course
            // 
            btn_Course.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Course.Location = new Point(104, 29);
            btn_Course.Name = "btn_Course";
            btn_Course.Size = new Size(203, 91);
            btn_Course.TabIndex = 1;
            btn_Course.Text = "Courses";
            btn_Course.UseVisualStyleBackColor = true;
            btn_Course.Click += btn_Course_Click;
            // 
            // btn_TaskJSONExport
            // 
            btn_TaskJSONExport.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_TaskJSONExport.Location = new Point(281, 313);
            btn_TaskJSONExport.Name = "btn_TaskJSONExport";
            btn_TaskJSONExport.Size = new Size(101, 35);
            btn_TaskJSONExport.TabIndex = 3;
            btn_TaskJSONExport.Text = "Export";
            btn_TaskJSONExport.UseVisualStyleBackColor = true;
            btn_TaskJSONExport.Click += btn_TaskJSONExport_Click;
            // 
            // btn_TaskJSONImport
            // 
            btn_TaskJSONImport.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_TaskJSONImport.Location = new Point(14, 313);
            btn_TaskJSONImport.Name = "btn_TaskJSONImport";
            btn_TaskJSONImport.Size = new Size(101, 35);
            btn_TaskJSONImport.TabIndex = 4;
            btn_TaskJSONImport.Text = "Import";
            btn_TaskJSONImport.UseVisualStyleBackColor = true;
            btn_TaskJSONImport.Click += btn_TaskJSONImport_Click;
            // 
            // btn_CoursesJSONImport
            // 
            btn_CoursesJSONImport.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CoursesJSONImport.Location = new Point(14, 313);
            btn_CoursesJSONImport.Name = "btn_CoursesJSONImport";
            btn_CoursesJSONImport.Size = new Size(101, 35);
            btn_CoursesJSONImport.TabIndex = 6;
            btn_CoursesJSONImport.Text = "Import";
            btn_CoursesJSONImport.UseVisualStyleBackColor = true;
            btn_CoursesJSONImport.Click += btn_CoursesJSONImport_Click;
            // 
            // btn_CoursesJSONExport
            // 
            btn_CoursesJSONExport.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CoursesJSONExport.Location = new Point(283, 313);
            btn_CoursesJSONExport.Name = "btn_CoursesJSONExport";
            btn_CoursesJSONExport.Size = new Size(101, 35);
            btn_CoursesJSONExport.TabIndex = 5;
            btn_CoursesJSONExport.Text = "Export";
            btn_CoursesJSONExport.UseVisualStyleBackColor = true;
            btn_CoursesJSONExport.Click += btn_CoursesJSONExport_Click;
            // 
            // lbl_TaskIOStatus
            // 
            lbl_TaskIOStatus.AutoSize = true;
            lbl_TaskIOStatus.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_TaskIOStatus.ForeColor = SystemColors.Control;
            lbl_TaskIOStatus.Location = new Point(114, 320);
            lbl_TaskIOStatus.Name = "lbl_TaskIOStatus";
            lbl_TaskIOStatus.Size = new Size(162, 20);
            lbl_TaskIOStatus.TabIndex = 9;
            lbl_TaskIOStatus.Text = "Import Successful";
            lbl_TaskIOStatus.TextAlign = ContentAlignment.MiddleCenter;
            lbl_TaskIOStatus.Visible = false;
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.Location = new Point(287, 49);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(713, 41);
            lbl_Title.TabIndex = 10;
            lbl_Title.Text = "Welcome to the School Task Management System";
            // 
            // lbl_IOCourseStatus
            // 
            lbl_IOCourseStatus.AutoSize = true;
            lbl_IOCourseStatus.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_IOCourseStatus.Location = new Point(118, 321);
            lbl_IOCourseStatus.Name = "lbl_IOCourseStatus";
            lbl_IOCourseStatus.Size = new Size(162, 20);
            lbl_IOCourseStatus.TabIndex = 11;
            lbl_IOCourseStatus.Text = "Import Successful";
            lbl_IOCourseStatus.Visible = false;
            // 
            // pic_Logo
            // 
            pic_Logo.Image = Properties.Resources.cc_logo;
            pic_Logo.Location = new Point(49, 28);
            pic_Logo.Margin = new Padding(3, 4, 3, 4);
            pic_Logo.Name = "pic_Logo";
            pic_Logo.Size = new Size(206, 84);
            pic_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Logo.TabIndex = 12;
            pic_Logo.TabStop = false;
            // 
            // pnl_Title
            // 
            pnl_Title.BackColor = Color.FromArgb(255, 255, 128);
            pnl_Title.Controls.Add(pic_Logo);
            pnl_Title.Controls.Add(lbl_Title);
            pnl_Title.Location = new Point(14, 9);
            pnl_Title.Margin = new Padding(3, 4, 3, 4);
            pnl_Title.Name = "pnl_Title";
            pnl_Title.Size = new Size(1024, 133);
            pnl_Title.TabIndex = 13;
            // 
            // pnl_Tasks
            // 
            pnl_Tasks.BackColor = Color.Teal;
            pnl_Tasks.Controls.Add(label2);
            pnl_Tasks.Controls.Add(lbl_TaskDesc);
            pnl_Tasks.Controls.Add(pictureBox2);
            pnl_Tasks.Controls.Add(btn_Tasks);
            pnl_Tasks.Controls.Add(btn_TaskJSONExport);
            pnl_Tasks.Controls.Add(lbl_TaskIOStatus);
            pnl_Tasks.Controls.Add(btn_TaskJSONImport);
            pnl_Tasks.Location = new Point(79, 169);
            pnl_Tasks.Margin = new Padding(3, 4, 3, 4);
            pnl_Tasks.Name = "pnl_Tasks";
            pnl_Tasks.Size = new Size(399, 364);
            pnl_Tasks.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(96, 191);
            label2.Name = "label2";
            label2.Size = new Size(228, 23);
            label2.TabIndex = 14;
            label2.Text = "Keep Track of your To do List";
            // 
            // lbl_TaskDesc
            // 
            lbl_TaskDesc.AutoSize = true;
            lbl_TaskDesc.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_TaskDesc.ForeColor = SystemColors.Control;
            lbl_TaskDesc.Location = new Point(66, 137);
            lbl_TaskDesc.Name = "lbl_TaskDesc";
            lbl_TaskDesc.Size = new Size(289, 37);
            lbl_TaskDesc.TabIndex = 13;
            lbl_TaskDesc.Text = "Manage and Add Tasks";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cc_logo;
            pictureBox2.Location = new Point(49, 28);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(0, 0);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pnl_Courses
            // 
            pnl_Courses.BackColor = Color.PaleTurquoise;
            pnl_Courses.Controls.Add(lbl_CourseDesc);
            pnl_Courses.Controls.Add(pictureBox3);
            pnl_Courses.Controls.Add(btn_Course);
            pnl_Courses.Controls.Add(btn_CoursesJSONExport);
            pnl_Courses.Controls.Add(lbl_IOCourseStatus);
            pnl_Courses.Controls.Add(btn_CoursesJSONImport);
            pnl_Courses.Location = new Point(561, 169);
            pnl_Courses.Margin = new Padding(3, 4, 3, 4);
            pnl_Courses.Name = "pnl_Courses";
            pnl_Courses.Size = new Size(399, 364);
            pnl_Courses.TabIndex = 15;
            // 
            // lbl_CourseDesc
            // 
            lbl_CourseDesc.AutoSize = true;
            lbl_CourseDesc.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CourseDesc.Location = new Point(25, 162);
            lbl_CourseDesc.Name = "lbl_CourseDesc";
            lbl_CourseDesc.Size = new Size(352, 31);
            lbl_CourseDesc.TabIndex = 13;
            lbl_CourseDesc.Text = "Create and Manage your Courses";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.cc_logo;
            pictureBox3.Location = new Point(49, 28);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(0, 0);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1051, 567);
            Controls.Add(pnl_Courses);
            Controls.Add(pnl_Tasks);
            Controls.Add(pnl_Title);
            Name = "Form1";
            Text = "School Task Management System";
            ((System.ComponentModel.ISupportInitialize)pic_Logo).EndInit();
            pnl_Title.ResumeLayout(false);
            pnl_Title.PerformLayout();
            pnl_Tasks.ResumeLayout(false);
            pnl_Tasks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnl_Courses.ResumeLayout(false);
            pnl_Courses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Tasks;
        private Button btn_Course;
        private Button btn_TaskJSONExport;
        private Button btn_TaskJSONImport;
        private Button btn_CoursesJSONImport;
        private Button btn_CoursesJSONExport;
        private Label lbl_TaskIOStatus;
        private Label lbl_Title;
        private Label lbl_IOCourseStatus;
        private PictureBox pic_Logo;
        private Panel pnl_Title;
        private Panel pnl_Tasks;
        private PictureBox pictureBox2;
        private Panel pnl_Courses;
        private PictureBox pictureBox3;
        private Label lbl_TaskDesc;
        private Label label2;
        private Label lbl_CourseDesc;
    }
}
