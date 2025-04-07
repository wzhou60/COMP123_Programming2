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
            components = new System.ComponentModel.Container();
            txt_DueDate = new TextBox();
            btn_DeleteTask = new Button();
            lbl_Weight = new Label();
            lbl_Date = new Label();
            btn_TaskEdit = new Button();
            btn_EvalAdd = new Button();
            lbx_EvalList = new ListBox();
            txt_Weight = new TextBox();
            bindingSource1 = new BindingSource(components);
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // txt_DueDate
            // 
            txt_DueDate.Location = new Point(42, 131);
            txt_DueDate.Name = "txt_DueDate";
            txt_DueDate.Size = new Size(250, 27);
            txt_DueDate.TabIndex = 26;
            // 
            // btn_DeleteTask
            // 
            btn_DeleteTask.Location = new Point(624, 263);
            btn_DeleteTask.Name = "btn_DeleteTask";
            btn_DeleteTask.Size = new Size(134, 29);
            btn_DeleteTask.TabIndex = 25;
            btn_DeleteTask.Text = "Delete Evaluation";
            btn_DeleteTask.UseVisualStyleBackColor = true;
            // 
            // lbl_Weight
            // 
            lbl_Weight.AutoSize = true;
            lbl_Weight.Location = new Point(42, 173);
            lbl_Weight.Name = "lbl_Weight";
            lbl_Weight.Size = new Size(109, 20);
            lbl_Weight.TabIndex = 24;
            lbl_Weight.Text = "Enter a Weight:";
            // 
            // lbl_Date
            // 
            lbl_Date.AutoSize = true;
            lbl_Date.Location = new Point(42, 108);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(125, 20);
            lbl_Date.TabIndex = 23;
            lbl_Date.Text = "Enter a Due Date:";
            // 
            // btn_TaskEdit
            // 
            btn_TaskEdit.Enabled = false;
            btn_TaskEdit.Location = new Point(314, 266);
            btn_TaskEdit.Name = "btn_TaskEdit";
            btn_TaskEdit.Size = new Size(117, 29);
            btn_TaskEdit.TabIndex = 20;
            btn_TaskEdit.Text = "Edit Evaluation";
            btn_TaskEdit.UseVisualStyleBackColor = true;
            // 
            // btn_EvalAdd
            // 
            btn_EvalAdd.Location = new Point(97, 266);
            btn_EvalAdd.Name = "btn_EvalAdd";
            btn_EvalAdd.Size = new Size(123, 30);
            btn_EvalAdd.TabIndex = 19;
            btn_EvalAdd.Text = "Add Evaluation";
            btn_EvalAdd.UseVisualStyleBackColor = true;
            // 
            // lbx_EvalList
            // 
            lbx_EvalList.FormattingEnabled = true;
            lbx_EvalList.Location = new Point(314, 131);
            lbx_EvalList.Name = "lbx_EvalList";
            lbx_EvalList.Size = new Size(444, 124);
            lbx_EvalList.TabIndex = 18;
            // 
            // txt_Weight
            // 
            txt_Weight.Location = new Point(42, 197);
            txt_Weight.Name = "txt_Weight";
            txt_Weight.Size = new Size(250, 27);
            txt_Weight.TabIndex = 27;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(42, 77);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 28);
            comboBox1.TabIndex = 28;
            // 
            // ViewEvaluationsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(txt_Weight);
            Controls.Add(txt_DueDate);
            Controls.Add(btn_DeleteTask);
            Controls.Add(lbl_Weight);
            Controls.Add(lbl_Date);
            Controls.Add(btn_TaskEdit);
            Controls.Add(btn_EvalAdd);
            Controls.Add(lbx_EvalList);
            Name = "ViewEvaluationsForm";
            Text = "ViewEvaluationsForm";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_DueDate;
        private Button btn_DeleteTask;
        private Label lbl_Weight;
        private Label lbl_Date;
        private Button btn_TaskEdit;
        private Button btn_EvalAdd;
        private ListBox lbx_EvalList;
        private TextBox txt_Weight;
        private BindingSource bindingSource1;
        private ComboBox comboBox1;
    }
}