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
            txt_EvalGrade = new TextBox();
            lbl_EvalGrade = new Label();
            lbl_EvalName = new Label();
            txt_EvalName = new TextBox();
            cbx_GroupAssign = new CheckBox();
            lbl_QuizQuestions = new Label();
            txt_QuizQuestions = new TextBox();
            lbl_EvalType = new Label();
            pnl_Title = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btn_TaskExit = new Button();
            grp_AddEval.SuspendLayout();
            pnl_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_DueDate
            // 
            txt_DueDate.Location = new Point(15, 161);
            txt_DueDate.Name = "txt_DueDate";
            txt_DueDate.Size = new Size(287, 24);
            txt_DueDate.TabIndex = 26;
            // 
            // btn_EvalTask
            // 
            btn_EvalTask.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_EvalTask.Location = new Point(832, 624);
            btn_EvalTask.Name = "btn_EvalTask";
            btn_EvalTask.Size = new Size(159, 29);
            btn_EvalTask.TabIndex = 25;
            btn_EvalTask.Text = "Delete Evaluation";
            btn_EvalTask.UseVisualStyleBackColor = true;
            btn_EvalTask.Click += btn_DeleteEval_Click;
            // 
            // lbl_Weight
            // 
            lbl_Weight.AutoSize = true;
            lbl_Weight.Location = new Point(15, 195);
            lbl_Weight.Name = "lbl_Weight";
            lbl_Weight.Size = new Size(128, 17);
            lbl_Weight.TabIndex = 24;
            lbl_Weight.Text = "Enter a Weight:";
            // 
            // lbl_Date
            // 
            lbl_Date.AutoSize = true;
            lbl_Date.Location = new Point(15, 139);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(144, 17);
            lbl_Date.TabIndex = 23;
            lbl_Date.Text = "Enter a Due Date:";
            // 
            // btn_EvalEdit
            // 
            btn_EvalEdit.Enabled = false;
            btn_EvalEdit.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_EvalEdit.Location = new Point(359, 624);
            btn_EvalEdit.Name = "btn_EvalEdit";
            btn_EvalEdit.Size = new Size(166, 29);
            btn_EvalEdit.TabIndex = 20;
            btn_EvalEdit.Text = "Edit Evaluation";
            btn_EvalEdit.UseVisualStyleBackColor = true;
            btn_EvalEdit.Click += btn_EvalEdit_Click;
            // 
            // btn_EvalAdd
            // 
            btn_EvalAdd.Anchor = AnchorStyles.Bottom;
            btn_EvalAdd.Location = new Point(95, 396);
            btn_EvalAdd.Name = "btn_EvalAdd";
            btn_EvalAdd.Size = new Size(137, 29);
            btn_EvalAdd.TabIndex = 19;
            btn_EvalAdd.Text = "Add Evaluation";
            btn_EvalAdd.UseVisualStyleBackColor = true;
            btn_EvalAdd.Click += btn_EvalAdd_Click;
            // 
            // lbx_EvalList
            // 
            lbx_EvalList.FormattingEnabled = true;
            lbx_EvalList.HorizontalScrollbar = true;
            lbx_EvalList.Location = new Point(359, 249);
            lbx_EvalList.Name = "lbx_EvalList";
            lbx_EvalList.Size = new Size(631, 364);
            lbx_EvalList.TabIndex = 18;
            lbx_EvalList.SelectedIndexChanged += lbx_EvalList_SelectedIndexChanged;
            // 
            // txt_Weight
            // 
            txt_Weight.Location = new Point(15, 219);
            txt_Weight.Name = "txt_Weight";
            txt_Weight.Size = new Size(287, 24);
            txt_Weight.TabIndex = 27;
            // 
            // cbx_EvalType
            // 
            cbx_EvalType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_EvalType.FormattingEnabled = true;
            cbx_EvalType.Items.AddRange(new object[] { "Assignment", "Test", "Quiz", "Discussion", "Project" });
            cbx_EvalType.Location = new Point(16, 51);
            cbx_EvalType.Name = "cbx_EvalType";
            cbx_EvalType.Size = new Size(286, 25);
            cbx_EvalType.TabIndex = 28;
            cbx_EvalType.SelectedIndexChanged += cbx_EvalType_SelectedIndexChanged;
            // 
            // grp_AddEval
            // 
            grp_AddEval.BackColor = SystemColors.GradientActiveCaption;
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
            grp_AddEval.Controls.Add(btn_EvalAdd);
            grp_AddEval.Controls.Add(txt_DueDate);
            grp_AddEval.Controls.Add(lbl_Weight);
            grp_AddEval.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grp_AddEval.Location = new Point(14, 219);
            grp_AddEval.Name = "grp_AddEval";
            grp_AddEval.Size = new Size(318, 435);
            grp_AddEval.TabIndex = 29;
            grp_AddEval.TabStop = false;
            grp_AddEval.Text = "Create an Evaluation";
            // 
            // txt_EvalGrade
            // 
            txt_EvalGrade.Location = new Point(14, 272);
            txt_EvalGrade.Name = "txt_EvalGrade";
            txt_EvalGrade.Size = new Size(289, 24);
            txt_EvalGrade.TabIndex = 36;
            // 
            // lbl_EvalGrade
            // 
            lbl_EvalGrade.AutoSize = true;
            lbl_EvalGrade.Location = new Point(14, 251);
            lbl_EvalGrade.Name = "lbl_EvalGrade";
            lbl_EvalGrade.Size = new Size(120, 17);
            lbl_EvalGrade.TabIndex = 35;
            lbl_EvalGrade.Text = "Enter a Grade:";
            // 
            // lbl_EvalName
            // 
            lbl_EvalName.AutoSize = true;
            lbl_EvalName.Location = new Point(14, 83);
            lbl_EvalName.Name = "lbl_EvalName";
            lbl_EvalName.Size = new Size(112, 17);
            lbl_EvalName.TabIndex = 34;
            lbl_EvalName.Text = "Enter a Name:";
            // 
            // txt_EvalName
            // 
            txt_EvalName.Location = new Point(15, 107);
            txt_EvalName.Name = "txt_EvalName";
            txt_EvalName.Size = new Size(287, 24);
            txt_EvalName.TabIndex = 33;
            // 
            // cbx_GroupAssign
            // 
            cbx_GroupAssign.AutoSize = true;
            cbx_GroupAssign.Enabled = false;
            cbx_GroupAssign.Location = new Point(75, 367);
            cbx_GroupAssign.Name = "cbx_GroupAssign";
            cbx_GroupAssign.Size = new Size(166, 21);
            cbx_GroupAssign.TabIndex = 32;
            cbx_GroupAssign.Text = "Group Assignment?";
            cbx_GroupAssign.UseVisualStyleBackColor = true;
            // 
            // lbl_QuizQuestions
            // 
            lbl_QuizQuestions.AutoSize = true;
            lbl_QuizQuestions.Location = new Point(14, 305);
            lbl_QuizQuestions.Name = "lbl_QuizQuestions";
            lbl_QuizQuestions.Size = new Size(296, 17);
            lbl_QuizQuestions.TabIndex = 31;
            lbl_QuizQuestions.Text = "Enter the Number of Questions (Quiz)";
            // 
            // txt_QuizQuestions
            // 
            txt_QuizQuestions.Enabled = false;
            txt_QuizQuestions.Location = new Point(14, 328);
            txt_QuizQuestions.Name = "txt_QuizQuestions";
            txt_QuizQuestions.Size = new Size(289, 24);
            txt_QuizQuestions.TabIndex = 30;
            // 
            // lbl_EvalType
            // 
            lbl_EvalType.AutoSize = true;
            lbl_EvalType.Location = new Point(16, 27);
            lbl_EvalType.Name = "lbl_EvalType";
            lbl_EvalType.Size = new Size(216, 17);
            lbl_EvalType.TabIndex = 29;
            lbl_EvalType.Text = "Select an Evaluation Type:";
            // 
            // pnl_Title
            // 
            pnl_Title.BackColor = Color.FromArgb(255, 255, 128);
            pnl_Title.Controls.Add(pictureBox1);
            pnl_Title.Controls.Add(label1);
            pnl_Title.Location = new Point(27, 29);
            pnl_Title.Margin = new Padding(3, 4, 3, 4);
            pnl_Title.Name = "pnl_Title";
            pnl_Title.Size = new Size(963, 133);
            pnl_Title.TabIndex = 30;
           
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(442, 36);
            label1.Name = "label1";
            label1.Size = new Size(340, 54);
            label1.TabIndex = 20;
            label1.Text = "View Evaluations";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(577, 192);
            label2.Name = "label2";
            label2.Size = new Size(216, 37);
            label2.TabIndex = 23;
            label2.Text = "Evaluations List";
            // 
            // btn_TaskExit
            // 
            btn_TaskExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_TaskExit.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_TaskExit.Location = new Point(916, 689);
            btn_TaskExit.Name = "btn_TaskExit";
            btn_TaskExit.Size = new Size(94, 29);
            btn_TaskExit.TabIndex = 31;
            btn_TaskExit.Text = "Exit";
            btn_TaskExit.UseVisualStyleBackColor = true;
            btn_TaskExit.Click += btn_TaskExit_Click;
            // 
            // ViewEvaluationsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1022, 730);
            Controls.Add(btn_TaskExit);
            Controls.Add(label2);
            Controls.Add(pnl_Title);
            Controls.Add(btn_EvalTask);
            Controls.Add(btn_EvalEdit);
            Controls.Add(lbx_EvalList);
            Controls.Add(grp_AddEval);
            Name = "ViewEvaluationsForm";
            Text = "ViewEvaluationsForm";
            grp_AddEval.ResumeLayout(false);
            grp_AddEval.PerformLayout();
            pnl_Title.ResumeLayout(false);
            pnl_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label lbl_EvalName;
        private TextBox txt_EvalName;
        private TextBox txt_EvalGrade;
        private Label lbl_EvalGrade;
        private Panel pnl_Title;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button btn_TaskExit;
    }
}