namespace JackieZ_Group3_Lab89
{
    partial class TaskEditor
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
            label1 = new Label();
            lbl_Date = new Label();
            chkbx_TaskDone = new CheckBox();
            txt_TaskDescription = new TextBox();
            btn_OK = new Button();
            btn_Cancel = new Button();
            txt_DueDate = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(38, 114);
            label1.Name = "label1";
            label1.Size = new Size(169, 20);
            label1.TabIndex = 14;
            label1.Text = "Enter a Task Description:";
            // 
            // lbl_Date
            // 
            lbl_Date.Anchor = AnchorStyles.Bottom;
            lbl_Date.AutoSize = true;
            lbl_Date.Location = new Point(38, 49);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(125, 20);
            lbl_Date.TabIndex = 13;
            lbl_Date.Text = "Enter a Due Date:";
            // 
            // chkbx_TaskDone
            // 
            chkbx_TaskDone.Anchor = AnchorStyles.Bottom;
            chkbx_TaskDone.AutoSize = true;
            chkbx_TaskDone.Location = new Point(105, 207);
            chkbx_TaskDone.Name = "chkbx_TaskDone";
            chkbx_TaskDone.Size = new Size(88, 24);
            chkbx_TaskDone.TabIndex = 12;
            chkbx_TaskDone.Text = "Is Done?";
            chkbx_TaskDone.UseVisualStyleBackColor = true;
            // 
            // txt_TaskDescription
            // 
            txt_TaskDescription.Anchor = AnchorStyles.Bottom;
            txt_TaskDescription.Location = new Point(38, 137);
            txt_TaskDescription.Multiline = true;
            txt_TaskDescription.Name = "txt_TaskDescription";
            txt_TaskDescription.PlaceholderText = "Enter the task description";
            txt_TaskDescription.Size = new Size(250, 65);
            txt_TaskDescription.TabIndex = 11;
            // 
            // btn_OK
            // 
            btn_OK.Anchor = AnchorStyles.Bottom;
            btn_OK.Location = new Point(119, 309);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(94, 30);
            btn_OK.TabIndex = 9;
            btn_OK.Text = "OK";
            btn_OK.UseVisualStyleBackColor = true;
            btn_OK.Click += btn_OK_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Anchor = AnchorStyles.Bottom;
            btn_Cancel.Location = new Point(219, 310);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(94, 29);
            btn_Cancel.TabIndex = 15;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // txt_DueDate
            // 
            txt_DueDate.Location = new Point(38, 72);
            txt_DueDate.Name = "txt_DueDate";
            txt_DueDate.Size = new Size(250, 27);
            txt_DueDate.TabIndex = 16;
            // 
            // TaskEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 351);
            Controls.Add(txt_DueDate);
            Controls.Add(btn_Cancel);
            Controls.Add(label1);
            Controls.Add(lbl_Date);
            Controls.Add(chkbx_TaskDone);
            Controls.Add(txt_TaskDescription);
            Controls.Add(btn_OK);
            Name = "TaskEditor";
            Text = "Edit Task";
            Load += TaskEditor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_Date;
        private CheckBox chkbx_TaskDone;
        private TextBox txt_TaskDescription;
        private Button btn_OK;
        private Button btn_Cancel;
        private TextBox txt_DueDate;
    }
}