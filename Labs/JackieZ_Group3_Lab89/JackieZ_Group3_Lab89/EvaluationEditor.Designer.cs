namespace JackieZ_Group3_Lab89
{
    partial class EvaluationEditor
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
            grp_AddEval = new GroupBox();
            txt_EvalGrade = new TextBox();
            lbl_EvalGrade = new Label();
            lbl_EvalName = new Label();
            txt_EvalName = new TextBox();
            cbx_GroupAssign = new CheckBox();
            lbl_QuizQuestions = new Label();
            txt_QuizQuestions = new TextBox();
            lbl_EvalType = new Label();
            cbx_EvalType = new ComboBox();
            lbl_Date = new Label();
            txt_Weight = new TextBox();
            txt_DueDate = new TextBox();
            lbl_Weight = new Label();
            btn_OK = new Button();
            btn_Cancel = new Button();
            grp_AddEval.SuspendLayout();
            SuspendLayout();
            // 
            // grp_AddEval
            // 
            grp_AddEval.Controls.Add(txt_EvalGrade);
            grp_AddEval.Controls.Add(lbl_EvalGrade);
            grp_AddEval.Controls.Add(lbl_EvalName);
            grp_AddEval.Controls.Add(txt_EvalName);
            grp_AddEval.Controls.Add(cbx_GroupAssign);
            grp_AddEval.Controls.Add(lbl_QuizQuestions);
            grp_AddEval.Controls.Add(txt_QuizQuestions);
            grp_AddEval.Controls.Add(lbl_EvalType);
            grp_AddEval.Controls.Add(cbx_EvalType);
            grp_AddEval.Controls.Add(lbl_Date);
            grp_AddEval.Controls.Add(txt_Weight);
            grp_AddEval.Controls.Add(txt_DueDate);
            grp_AddEval.Controls.Add(lbl_Weight);
            grp_AddEval.Location = new Point(79, 24);
            grp_AddEval.Name = "grp_AddEval";
            grp_AddEval.Size = new Size(280, 396);
            grp_AddEval.TabIndex = 30;
            grp_AddEval.TabStop = false;
            grp_AddEval.Text = "Create an Evaluation";
            // 
            // txt_EvalGrade
            // 
            txt_EvalGrade.Location = new Point(14, 272);
            txt_EvalGrade.Name = "txt_EvalGrade";
            txt_EvalGrade.Size = new Size(251, 27);
            txt_EvalGrade.TabIndex = 36;
            // 
            // lbl_EvalGrade
            // 
            lbl_EvalGrade.AutoSize = true;
            lbl_EvalGrade.Location = new Point(14, 251);
            lbl_EvalGrade.Name = "lbl_EvalGrade";
            lbl_EvalGrade.Size = new Size(102, 20);
            lbl_EvalGrade.TabIndex = 35;
            lbl_EvalGrade.Text = "Enter a Grade:";
            // 
            // lbl_EvalName
            // 
            lbl_EvalName.AutoSize = true;
            lbl_EvalName.Location = new Point(14, 83);
            lbl_EvalName.Name = "lbl_EvalName";
            lbl_EvalName.Size = new Size(102, 20);
            lbl_EvalName.TabIndex = 34;
            lbl_EvalName.Text = "Enter a Name:";
            // 
            // txt_EvalName
            // 
            txt_EvalName.Location = new Point(15, 106);
            txt_EvalName.Name = "txt_EvalName";
            txt_EvalName.Size = new Size(250, 27);
            txt_EvalName.TabIndex = 33;
            // 
            // cbx_GroupAssign
            // 
            cbx_GroupAssign.AutoSize = true;
            cbx_GroupAssign.Enabled = false;
            cbx_GroupAssign.Location = new Point(59, 362);
            cbx_GroupAssign.Name = "cbx_GroupAssign";
            cbx_GroupAssign.Size = new Size(160, 24);
            cbx_GroupAssign.TabIndex = 32;
            cbx_GroupAssign.Text = "Group Assignment?";
            cbx_GroupAssign.UseVisualStyleBackColor = true;
            // 
            // lbl_QuizQuestions
            // 
            lbl_QuizQuestions.AutoSize = true;
            lbl_QuizQuestions.Location = new Point(14, 305);
            lbl_QuizQuestions.Name = "lbl_QuizQuestions";
            lbl_QuizQuestions.Size = new Size(257, 20);
            lbl_QuizQuestions.TabIndex = 31;
            lbl_QuizQuestions.Text = "Enter the Number of Questions (Quiz)";
            // 
            // txt_QuizQuestions
            // 
            txt_QuizQuestions.Enabled = false;
            txt_QuizQuestions.Location = new Point(14, 328);
            txt_QuizQuestions.Name = "txt_QuizQuestions";
            txt_QuizQuestions.Size = new Size(251, 27);
            txt_QuizQuestions.TabIndex = 30;
            // 
            // lbl_EvalType
            // 
            lbl_EvalType.AutoSize = true;
            lbl_EvalType.Location = new Point(16, 27);
            lbl_EvalType.Name = "lbl_EvalType";
            lbl_EvalType.Size = new Size(116, 20);
            lbl_EvalType.TabIndex = 29;
            lbl_EvalType.Text = "Evaluation Type:";
            // 
            // cbx_EvalType
            // 
            cbx_EvalType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_EvalType.Enabled = false;
            cbx_EvalType.FormattingEnabled = true;
            cbx_EvalType.Items.AddRange(new object[] { "Assignment", "Test", "Quiz", "Discussion", "Project" });
            cbx_EvalType.Location = new Point(16, 50);
            cbx_EvalType.Name = "cbx_EvalType";
            cbx_EvalType.Size = new Size(250, 28);
            cbx_EvalType.TabIndex = 28;
            // 
            // lbl_Date
            // 
            lbl_Date.AutoSize = true;
            lbl_Date.Location = new Point(15, 138);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(125, 20);
            lbl_Date.TabIndex = 23;
            lbl_Date.Text = "Enter a Due Date:";
            // 
            // txt_Weight
            // 
            txt_Weight.Location = new Point(15, 218);
            txt_Weight.Name = "txt_Weight";
            txt_Weight.Size = new Size(250, 27);
            txt_Weight.TabIndex = 27;
            // 
            // txt_DueDate
            // 
            txt_DueDate.Location = new Point(15, 161);
            txt_DueDate.Name = "txt_DueDate";
            txt_DueDate.Size = new Size(250, 27);
            txt_DueDate.TabIndex = 26;
            // 
            // lbl_Weight
            // 
            lbl_Weight.AutoSize = true;
            lbl_Weight.Location = new Point(15, 194);
            lbl_Weight.Name = "lbl_Weight";
            lbl_Weight.Size = new Size(109, 20);
            lbl_Weight.TabIndex = 24;
            lbl_Weight.Text = "Enter a Weight:";
            // 
            // btn_OK
            // 
            btn_OK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_OK.Location = new Point(243, 460);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(94, 29);
            btn_OK.TabIndex = 31;
            btn_OK.Text = "OK";
            btn_OK.UseVisualStyleBackColor = true;
            btn_OK.Click += btn_OK_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Cancel.Location = new Point(348, 460);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(94, 29);
            btn_Cancel.TabIndex = 32;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // EvaluationEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 501);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_OK);
            Controls.Add(grp_AddEval);
            Name = "EvaluationEditor";
            Text = "EvaluationEditor";
            Load += EvaluationEditor_Load;
            grp_AddEval.ResumeLayout(false);
            grp_AddEval.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grp_AddEval;
        private TextBox txt_EvalGrade;
        private Label lbl_EvalGrade;
        private Label lbl_EvalName;
        private TextBox txt_EvalName;
        private CheckBox cbx_GroupAssign;
        private Label lbl_QuizQuestions;
        private TextBox txt_QuizQuestions;
        private Label lbl_EvalType;
        private ComboBox cbx_EvalType;
        private Label lbl_Date;
        private TextBox txt_Weight;
        private TextBox txt_DueDate;
        private Label lbl_Weight;
        private Button btn_OK;
        private Button btn_Cancel;
    }
}