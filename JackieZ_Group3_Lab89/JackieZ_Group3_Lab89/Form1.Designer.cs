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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btn_Tasks
            // 
            btn_Tasks.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Tasks.ForeColor = SystemColors.ControlText;
            btn_Tasks.Location = new Point(84, 11);
            btn_Tasks.Margin = new Padding(3, 2, 3, 2);
            btn_Tasks.Name = "btn_Tasks";
            btn_Tasks.Size = new Size(178, 68);
            btn_Tasks.TabIndex = 0;
            btn_Tasks.Text = "Tasks";
            btn_Tasks.UseVisualStyleBackColor = true;
            btn_Tasks.Click += btn_Tasks_Click;
            // 
            // btn_Course
            // 
            btn_Course.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Course.Location = new Point(82, 11);
            btn_Course.Margin = new Padding(3, 2, 3, 2);
            btn_Course.Name = "btn_Course";
            btn_Course.Size = new Size(178, 68);
            btn_Course.TabIndex = 1;
            btn_Course.Text = "Courses";
            btn_Course.UseVisualStyleBackColor = true;
            btn_Course.Click += btn_Course_Click;
            // 
            // btn_TaskJSONExport
            // 
            btn_TaskJSONExport.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_TaskJSONExport.Location = new Point(246, 230);
            btn_TaskJSONExport.Margin = new Padding(3, 2, 3, 2);
            btn_TaskJSONExport.Name = "btn_TaskJSONExport";
            btn_TaskJSONExport.Size = new Size(88, 26);
            btn_TaskJSONExport.TabIndex = 3;
            btn_TaskJSONExport.Text = "Export";
            btn_TaskJSONExport.UseVisualStyleBackColor = true;
            btn_TaskJSONExport.Click += btn_TaskJSONExport_Click;
            // 
            // btn_TaskJSONImport
            // 
            btn_TaskJSONImport.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_TaskJSONImport.Location = new Point(12, 230);
            btn_TaskJSONImport.Margin = new Padding(3, 2, 3, 2);
            btn_TaskJSONImport.Name = "btn_TaskJSONImport";
            btn_TaskJSONImport.Size = new Size(88, 26);
            btn_TaskJSONImport.TabIndex = 4;
            btn_TaskJSONImport.Text = "Import";
            btn_TaskJSONImport.UseVisualStyleBackColor = true;
            btn_TaskJSONImport.Click += btn_TaskJSONImport_Click;
            // 
            // btn_CoursesJSONImport
            // 
            btn_CoursesJSONImport.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CoursesJSONImport.Location = new Point(12, 235);
            btn_CoursesJSONImport.Margin = new Padding(3, 2, 3, 2);
            btn_CoursesJSONImport.Name = "btn_CoursesJSONImport";
            btn_CoursesJSONImport.Size = new Size(88, 26);
            btn_CoursesJSONImport.TabIndex = 6;
            btn_CoursesJSONImport.Text = "Import";
            btn_CoursesJSONImport.UseVisualStyleBackColor = true;
            btn_CoursesJSONImport.Click += btn_CoursesJSONImport_Click;
            // 
            // btn_CoursesJSONExport
            // 
            btn_CoursesJSONExport.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CoursesJSONExport.Location = new Point(248, 235);
            btn_CoursesJSONExport.Margin = new Padding(3, 2, 3, 2);
            btn_CoursesJSONExport.Name = "btn_CoursesJSONExport";
            btn_CoursesJSONExport.Size = new Size(88, 26);
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
            lbl_TaskIOStatus.Location = new Point(106, 236);
            lbl_TaskIOStatus.Name = "lbl_TaskIOStatus";
            lbl_TaskIOStatus.Size = new Size(126, 15);
            lbl_TaskIOStatus.TabIndex = 9;
            lbl_TaskIOStatus.Text = "Import Successful";
            lbl_TaskIOStatus.TextAlign = ContentAlignment.MiddleCenter;
            lbl_TaskIOStatus.Visible = false;
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.Location = new Point(251, 37);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(577, 32);
            lbl_Title.TabIndex = 10;
            lbl_Title.Text = "Welcome to the School Task Management System";
            // 
            // lbl_IOCourseStatus
            // 
            lbl_IOCourseStatus.AutoSize = true;
            lbl_IOCourseStatus.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_IOCourseStatus.Location = new Point(116, 241);
            lbl_IOCourseStatus.Name = "lbl_IOCourseStatus";
            lbl_IOCourseStatus.Size = new Size(126, 15);
            lbl_IOCourseStatus.TabIndex = 11;
            lbl_IOCourseStatus.Text = "Import Successful";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cc_logo;
            pictureBox1.Location = new Point(43, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 128);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbl_Title);
            panel1.Location = new Point(12, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 100);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btn_Tasks);
            panel2.Controls.Add(btn_TaskJSONExport);
            panel2.Controls.Add(lbl_TaskIOStatus);
            panel2.Controls.Add(btn_TaskJSONImport);
            panel2.Location = new Point(69, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(349, 273);
            panel2.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(84, 136);
            label2.Name = "label2";
            label2.Size = new Size(179, 17);
            label2.TabIndex = 14;
            label2.Text = "Keep Track of your To do List";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(58, 95);
            label1.Name = "label1";
            label1.Size = new Size(228, 30);
            label1.TabIndex = 13;
            label1.Text = "Add Tasks to a Course. ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cc_logo;
            pictureBox2.Location = new Point(43, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(0, 0);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PaleTurquoise;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(btn_Course);
            panel3.Controls.Add(btn_CoursesJSONExport);
            panel3.Controls.Add(lbl_IOCourseStatus);
            panel3.Controls.Add(btn_CoursesJSONImport);
            panel3.Location = new Point(491, 127);
            panel3.Name = "panel3";
            panel3.Size = new Size(349, 273);
            panel3.TabIndex = 15;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.cc_logo;
            pictureBox3.Location = new Point(43, 21);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(0, 0);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 113);
            label3.Name = "label3";
            label3.Size = new Size(319, 30);
            label3.TabIndex = 13;
            label3.Text = "Create Your Courses to add Tasks";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(920, 425);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "School Task Management System";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
