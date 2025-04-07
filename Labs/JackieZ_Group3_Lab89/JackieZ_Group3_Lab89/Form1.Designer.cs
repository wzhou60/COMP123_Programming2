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
            btn_Evaluation = new Button();
            btn_TaskJSONExport = new Button();
            btn_TaskJSONImport = new Button();
            btn_CoursesJSONImport = new Button();
            btn_CoursesJSONExport = new Button();
            btn_EvalJSONImport = new Button();
            btn_EvalJSONExport = new Button();
            lbl_TaskIOStatus = new Label();
            lbl_Title = new Label();
            SuspendLayout();
            // 
            // btn_Tasks
            // 
            btn_Tasks.Location = new Point(131, 149);
            btn_Tasks.Name = "btn_Tasks";
            btn_Tasks.Size = new Size(175, 58);
            btn_Tasks.TabIndex = 0;
            btn_Tasks.Text = "Tasks";
            btn_Tasks.UseVisualStyleBackColor = true;
            btn_Tasks.Click += btn_Tasks_Click;
            // 
            // btn_Course
            // 
            btn_Course.Location = new Point(431, 149);
            btn_Course.Name = "btn_Course";
            btn_Course.Size = new Size(175, 58);
            btn_Course.TabIndex = 1;
            btn_Course.Text = "Courses";
            btn_Course.UseVisualStyleBackColor = true;
            btn_Course.Click += btn_Course_Click;
            // 
            // btn_Evaluation
            // 
            btn_Evaluation.Location = new Point(731, 149);
            btn_Evaluation.Name = "btn_Evaluation";
            btn_Evaluation.Size = new Size(175, 58);
            btn_Evaluation.TabIndex = 2;
            btn_Evaluation.Text = "Evaluations";
            btn_Evaluation.UseVisualStyleBackColor = true;
            // 
            // btn_TaskJSONExport
            // 
            btn_TaskJSONExport.Location = new Point(168, 240);
            btn_TaskJSONExport.Name = "btn_TaskJSONExport";
            btn_TaskJSONExport.Size = new Size(100, 35);
            btn_TaskJSONExport.TabIndex = 3;
            btn_TaskJSONExport.Text = "Export";
            btn_TaskJSONExport.UseVisualStyleBackColor = true;
            btn_TaskJSONExport.Click += btn_TaskJSONExport_Click;
            // 
            // btn_TaskJSONImport
            // 
            btn_TaskJSONImport.Location = new Point(168, 290);
            btn_TaskJSONImport.Name = "btn_TaskJSONImport";
            btn_TaskJSONImport.Size = new Size(100, 35);
            btn_TaskJSONImport.TabIndex = 4;
            btn_TaskJSONImport.Text = "Import";
            btn_TaskJSONImport.UseVisualStyleBackColor = true;
            btn_TaskJSONImport.Click += btn_TaskJSONImport_Click;
            // 
            // btn_CoursesJSONImport
            // 
            btn_CoursesJSONImport.Location = new Point(472, 290);
            btn_CoursesJSONImport.Name = "btn_CoursesJSONImport";
            btn_CoursesJSONImport.Size = new Size(100, 35);
            btn_CoursesJSONImport.TabIndex = 6;
            btn_CoursesJSONImport.Text = "Import";
            btn_CoursesJSONImport.UseVisualStyleBackColor = true;
            // 
            // btn_CoursesJSONExport
            // 
            btn_CoursesJSONExport.Location = new Point(472, 240);
            btn_CoursesJSONExport.Name = "btn_CoursesJSONExport";
            btn_CoursesJSONExport.Size = new Size(100, 35);
            btn_CoursesJSONExport.TabIndex = 5;
            btn_CoursesJSONExport.Text = "Export";
            btn_CoursesJSONExport.UseVisualStyleBackColor = true;
            // 
            // btn_EvalJSONImport
            // 
            btn_EvalJSONImport.Location = new Point(772, 290);
            btn_EvalJSONImport.Name = "btn_EvalJSONImport";
            btn_EvalJSONImport.Size = new Size(100, 35);
            btn_EvalJSONImport.TabIndex = 8;
            btn_EvalJSONImport.Text = "Import";
            btn_EvalJSONImport.UseVisualStyleBackColor = true;
            // 
            // btn_EvalJSONExport
            // 
            btn_EvalJSONExport.Location = new Point(772, 240);
            btn_EvalJSONExport.Name = "btn_EvalJSONExport";
            btn_EvalJSONExport.Size = new Size(100, 35);
            btn_EvalJSONExport.TabIndex = 7;
            btn_EvalJSONExport.Text = "Export";
            btn_EvalJSONExport.UseVisualStyleBackColor = true;
            // 
            // lbl_TaskIOStatus
            // 
            lbl_TaskIOStatus.AutoSize = true;
            lbl_TaskIOStatus.Location = new Point(157, 338);
            lbl_TaskIOStatus.Name = "lbl_TaskIOStatus";
            lbl_TaskIOStatus.Size = new Size(125, 20);
            lbl_TaskIOStatus.TabIndex = 9;
            lbl_TaskIOStatus.Text = "Import Successful";
            lbl_TaskIOStatus.TextAlign = ContentAlignment.MiddleCenter;
            lbl_TaskIOStatus.Visible = false;
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.Location = new Point(262, 57);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(544, 31);
            lbl_Title.TabIndex = 10;
            lbl_Title.Text = "Welcome to the School Task Management System";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 567);
            Controls.Add(lbl_Title);
            Controls.Add(lbl_TaskIOStatus);
            Controls.Add(btn_EvalJSONImport);
            Controls.Add(btn_EvalJSONExport);
            Controls.Add(btn_CoursesJSONImport);
            Controls.Add(btn_CoursesJSONExport);
            Controls.Add(btn_TaskJSONImport);
            Controls.Add(btn_TaskJSONExport);
            Controls.Add(btn_Evaluation);
            Controls.Add(btn_Course);
            Controls.Add(btn_Tasks);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Tasks;
        private Button btn_Course;
        private Button btn_Evaluation;
        private Button btn_TaskJSONExport;
        private Button btn_TaskJSONImport;
        private Button btn_CoursesJSONImport;
        private Button btn_CoursesJSONExport;
        private Button btn_EvalJSONImport;
        private Button btn_EvalJSONExport;
        private Label lbl_TaskIOStatus;
        private Label lbl_Title;
    }
}
