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
            SuspendLayout();
            // 
            // btn_Tasks
            // 
            btn_Tasks.Location = new Point(135, 261);
            btn_Tasks.Name = "btn_Tasks";
            btn_Tasks.Size = new Size(175, 63);
            btn_Tasks.TabIndex = 0;
            btn_Tasks.Text = "Tasks";
            btn_Tasks.UseVisualStyleBackColor = true;
            btn_Tasks.Click += btn_Tasks_Click;
            // 
            // btn_Course
            // 
            btn_Course.Location = new Point(435, 261);
            btn_Course.Name = "btn_Course";
            btn_Course.Size = new Size(175, 63);
            btn_Course.TabIndex = 1;
            btn_Course.Text = "Courses";
            btn_Course.UseVisualStyleBackColor = true;
            // 
            // btn_Evaluation
            // 
            btn_Evaluation.Location = new Point(735, 261);
            btn_Evaluation.Name = "btn_Evaluation";
            btn_Evaluation.Size = new Size(175, 63);
            btn_Evaluation.TabIndex = 2;
            btn_Evaluation.Text = "Evaluations";
            btn_Evaluation.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 567);
            Controls.Add(btn_Evaluation);
            Controls.Add(btn_Course);
            Controls.Add(btn_Tasks);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Tasks;
        private Button btn_Course;
        private Button btn_Evaluation;
    }
}
