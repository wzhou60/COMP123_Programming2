namespace JackieZ_Group3_Lab89
{
    partial class ViewEvaluationsForm
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
            txt_DueDate = new TextBox();
            btn_EvalTask = new Button();
            lbl_Weight = new Label();
            lbl_Date = new Label();
            btn_EvalEdit = new Button();
            btn_EvalAdd = new Button();
            lbx_EvalList = new ListBox();
            txt_Weight = new TextBox();
            cbx_EvalType = new ComboBox();
            grp_AddEval = new GroupBox();
            cbx_GroupAssign = new CheckBox();
            lbl_QuizQuestions = new Label();
            txt_QuizQuestions = new TextBox();
            lbl_EvalType = new Label();
            grp_AddEval.SuspendLayout();
            SuspendLayout();
            // 
            // txt_DueDate
            // 
            txt_DueDate.Anchor = AnchorStyles.Top;
            txt_DueDate.Location = new Point(15, 121);
            txt_DueDate.Name = "txt_DueDate";
            txt_DueDate.Size = new Size(250, 27);
            txt_DueDate.TabIndex = 26;
            // 
            // btn_EvalTask
            // 
            btn_EvalTask.Location = new Point(627, 251);
            btn_EvalTask.Name = "btn_EvalTask";
            btn_EvalTask.Size = new Size(134, 29);
            btn_EvalTask.TabIndex = 25;
            btn_EvalTask.Text = "Delete Evaluation";
            btn_EvalTask.UseVisualStyleBackColor = true;
            btn_EvalTask.Click += btn_DeleteTask_Click;
            // 
            // lbl_Weight
            // 
            lbl_Weight.Anchor = AnchorStyles.Top;
            lbl_Weight.AutoSize = true;
            lbl_Weight.Location = new Point(15, 161);
            lbl_Weight.Name = "lbl_Weight";
            lbl_Weight.Size = new Size(109, 20);
            lbl_Weight.TabIndex = 24;
            lbl_Weight.Text = "Enter a Weight:";
            // 
            // lbl_Date
            // 
            lbl_Date.Anchor = AnchorStyles.Top;
            lbl_Date.AutoSize = true;
            lbl_Date.Location = new Point(15, 98);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(125, 20);
            lbl_Date.TabIndex = 23;
            lbl_Date.Text = "Enter a Due Date:";
            // 
            // btn_EvalEdit
            // 
            btn_EvalEdit.Enabled = false;
            btn_EvalEdit.Location = new Point(317, 254);
            btn_EvalEdit.Name = "btn_EvalEdit";
            btn_EvalEdit.Size = new Size(117, 29);
            btn_EvalEdit.TabIndex = 20;
            btn_EvalEdit.Text = "Edit Evaluation";
            btn_EvalEdit.UseVisualStyleBackColor = true;
            // 
            // btn_EvalAdd
            // 
            btn_EvalAdd.Anchor = AnchorStyles.Bottom;
            btn_EvalAdd.Location = new Point(76, 353);
            btn_EvalAdd.Name = "btn_EvalAdd";
            btn_EvalAdd.Size = new Size(123, 30);
            btn_EvalAdd.TabIndex = 19;
            btn_EvalAdd.Text = "Add Evaluation";
            btn_EvalAdd.UseVisualStyleBackColor = true;
            btn_EvalAdd.Click += btn_EvalAdd_Click;
            // 
            // lbx_EvalList
            // 
            lbx_EvalList.FormattingEnabled = true;
            lbx_EvalList.HorizontalScrollbar = true;
            lbx_EvalList.Location = new Point(317, 119);
            lbx_EvalList.Name = "lbx_EvalList";
            lbx_EvalList.Size = new Size(444, 124);
            lbx_EvalList.TabIndex = 18;
            // 
            // txt_Weight
            // 
            txt_Weight.Anchor = AnchorStyles.Top;
            txt_Weight.Location = new Point(15, 185);
            txt_Weight.Name = "txt_Weight";
            txt_Weight.Size = new Size(250, 27);
            txt_Weight.TabIndex = 27;
            // 
            // cbx_EvalType
            // 
            cbx_EvalType.Anchor = AnchorStyles.Top;
            cbx_EvalType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_EvalType.FormattingEnabled = true;
            cbx_EvalType.Items.AddRange(new object[] { "Assignment", "Test", "Quiz", "Discussion", "Project" });
            cbx_EvalType.Location = new Point(15, 62);
            cbx_EvalType.Name = "cbx_EvalType";
            cbx_EvalType.Size = new Size(250, 28);
            cbx_EvalType.TabIndex = 28;
            // 
            // grp_AddEval
            // 
            grp_AddEval.Controls.Add(cbx_GroupAssign);
            grp_AddEval.Controls.Add(lbl_QuizQuestions);
            grp_AddEval.Controls.Add(txt_QuizQuestions);
            grp_AddEval.Controls.Add(lbl_EvalType);
            grp_AddEval.Controls.Add(cbx_EvalType);
            grp_AddEval.Controls.Add(lbl_Date);
            grp_AddEval.Controls.Add(txt_Weight);
            grp_AddEval.Controls.Add(btn_EvalAdd);
            grp_AddEval.Controls.Add(txt_DueDate);
            grp_AddEval.Controls.Add(lbl_Weight);
            grp_AddEval.Location = new Point(19, 26);
            grp_AddEval.Name = "grp_AddEval";
            grp_AddEval.Size = new Size(280, 412);
            grp_AddEval.TabIndex = 29;
            grp_AddEval.TabStop = false;
            grp_AddEval.Text = "Create an Evaluation";
            // 
            // cbx_GroupAssign
            // 
            cbx_GroupAssign.AutoSize = true;
            cbx_GroupAssign.Location = new Point(59, 295);
            cbx_GroupAssign.Name = "cbx_GroupAssign";
            cbx_GroupAssign.Size = new Size(160, 24);
            cbx_GroupAssign.TabIndex = 32;
            cbx_GroupAssign.Text = "Group Assignment?";
            cbx_GroupAssign.UseVisualStyleBackColor = true;
            // 
            // lbl_QuizQuestions
            // 
            lbl_QuizQuestions.AutoSize = true;
            lbl_QuizQuestions.Location = new Point(14, 225);
            lbl_QuizQuestions.Name = "lbl_QuizQuestions";
            lbl_QuizQuestions.Size = new Size(257, 20);
            lbl_QuizQuestions.TabIndex = 31;
            lbl_QuizQuestions.Text = "Enter the Number of Questions (Quiz)";
            // 
            // txt_QuizQuestions
            // 
            txt_QuizQuestions.Location = new Point(15, 248);
            txt_QuizQuestions.Name = "txt_QuizQuestions";
            txt_QuizQuestions.Size = new Size(250, 27);
            txt_QuizQuestions.TabIndex = 30;
            // 
            // lbl_EvalType
            // 
            lbl_EvalType.Anchor = AnchorStyles.Top;
            lbl_EvalType.AutoSize = true;
            lbl_EvalType.Location = new Point(15, 39);
            lbl_EvalType.Name = "lbl_EvalType";
            lbl_EvalType.Size = new Size(180, 20);
            lbl_EvalType.TabIndex = 29;
            lbl_EvalType.Text = "Select an Evaluation Type:";
            // 
            // ViewEvaluationsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_EvalTask);
            Controls.Add(btn_EvalEdit);
            Controls.Add(lbx_EvalList);
            Controls.Add(grp_AddEval);
            Name = "ViewEvaluationsForm";
            Text = "ViewEvaluationsForm";
            grp_AddEval.ResumeLayout(false);
            grp_AddEval.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_DueDate;
        private Button btn_EvalTask;
        private Label lbl_Weight;
        private Label lbl_Date;
        private Button btn_EvalEdit;
        private Button btn_EvalAdd;
        private ListBox lbx_EvalList;
        private TextBox txt_Weight;
        private ComboBox cbx_EvalType;
        private GroupBox grp_AddEval;
        private Label lbl_EvalType;
        private Label lbl_QuizQuestions;
        private TextBox txt_QuizQuestions;
        private CheckBox cbx_GroupAssign;
    }
}