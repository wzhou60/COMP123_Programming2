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
            SuspendLayout();
            // 
            // txt_CourseID
            // 
            txt_CourseID.Location = new Point(42, 131);
            txt_CourseID.Name = "txt_CourseID";
            txt_CourseID.Size = new Size(250, 27);
            txt_CourseID.TabIndex = 26;
            // 
            // btn_DeleteCourse
            // 
            btn_DeleteCourse.Location = new Point(651, 209);
            btn_DeleteCourse.Name = "btn_DeleteCourse";
            btn_DeleteCourse.Size = new Size(110, 29);
            btn_DeleteCourse.TabIndex = 25;
            btn_DeleteCourse.Text = "Delete Course";
            btn_DeleteCourse.UseVisualStyleBackColor = true;
            // 
            // lbl_CourseCode
            // 
            lbl_CourseCode.AutoSize = true;
            lbl_CourseCode.Location = new Point(42, 173);
            lbl_CourseCode.Name = "lbl_CourseCode";
            lbl_CourseCode.Size = new Size(146, 20);
            lbl_CourseCode.TabIndex = 24;
            lbl_CourseCode.Text = "Enter a Course Code:";
            // 
            // lbl_CourseID
            // 
            lbl_CourseID.AutoSize = true;
            lbl_CourseID.Location = new Point(42, 108);
            lbl_CourseID.Name = "lbl_CourseID";
            lbl_CourseID.Size = new Size(126, 20);
            lbl_CourseID.TabIndex = 23;
            lbl_CourseID.Text = "Enter a Course ID:";
            // 
            // txt_CourseCode
            // 
            txt_CourseCode.Location = new Point(42, 196);
            txt_CourseCode.Multiline = true;
            txt_CourseCode.Name = "txt_CourseCode";
            txt_CourseCode.Size = new Size(250, 29);
            txt_CourseCode.TabIndex = 21;
            // 
            // btn_CourseEdit
            // 
            btn_CourseEdit.Enabled = false;
            btn_CourseEdit.Location = new Point(541, 209);
            btn_CourseEdit.Name = "btn_CourseEdit";
            btn_CourseEdit.Size = new Size(94, 29);
            btn_CourseEdit.TabIndex = 20;
            btn_CourseEdit.Text = "Edit Course";
            btn_CourseEdit.UseVisualStyleBackColor = true;
            btn_CourseEdit.Click += btn_CourseEdit_Click;
            // 
            // btn_CourseAdd
            // 
            btn_CourseAdd.Location = new Point(120, 243);
            btn_CourseAdd.Name = "btn_CourseAdd";
            btn_CourseAdd.Size = new Size(94, 30);
            btn_CourseAdd.TabIndex = 19;
            btn_CourseAdd.Text = "Add Course";
            btn_CourseAdd.UseVisualStyleBackColor = true;
            btn_CourseAdd.Click += btn_CourseAdd_Click;
            // 
            // lbx_CourseList
            // 
            lbx_CourseList.FormattingEnabled = true;
            lbx_CourseList.HorizontalScrollbar = true;
            lbx_CourseList.Location = new Point(317, 74);
            lbx_CourseList.Name = "lbx_CourseList";
            lbx_CourseList.Size = new Size(444, 124);
            lbx_CourseList.TabIndex = 18;
            lbx_CourseList.SelectedIndexChanged += lbx_CourseList_SelectedIndexChanged;
            // 
            // txt_CourseName
            // 
            txt_CourseName.Location = new Point(42, 74);
            txt_CourseName.Name = "txt_CourseName";
            txt_CourseName.Size = new Size(250, 27);
            txt_CourseName.TabIndex = 28;
            // 
            // lbl_CourseName
            // 
            lbl_CourseName.AutoSize = true;
            lbl_CourseName.Location = new Point(42, 51);
            lbl_CourseName.Name = "lbl_CourseName";
            lbl_CourseName.Size = new Size(151, 20);
            lbl_CourseName.TabIndex = 27;
            lbl_CourseName.Text = "Enter a Course Name:";
            // 
            // btn_ViewEvals
            // 
            btn_ViewEvals.Enabled = false;
            btn_ViewEvals.Location = new Point(317, 209);
            btn_ViewEvals.Name = "btn_ViewEvals";
            btn_ViewEvals.Size = new Size(128, 29);
            btn_ViewEvals.TabIndex = 29;
            btn_ViewEvals.Text = "View Evaluations";
            btn_ViewEvals.UseVisualStyleBackColor = true;
            btn_ViewEvals.Click += btn_ViewEvals_Click;
            // 
            // CourseManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_ViewEvals);
            Controls.Add(txt_CourseName);
            Controls.Add(lbl_CourseName);
            Controls.Add(txt_CourseID);
            Controls.Add(btn_DeleteCourse);
            Controls.Add(lbl_CourseCode);
            Controls.Add(lbl_CourseID);
            Controls.Add(txt_CourseCode);
            Controls.Add(btn_CourseEdit);
            Controls.Add(btn_CourseAdd);
            Controls.Add(lbx_CourseList);
            Name = "CourseManagerForm";
            Text = "CourseManagerForm";
            Load += CourseManagerForm_Load;
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
    }
}