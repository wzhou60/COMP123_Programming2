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
            dtp_TaskDate = new DateTimePicker();
            btn_EditedTask = new Button();
            btn_Cancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(48, 142);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(203, 25);
            label1.TabIndex = 14;
            label1.Text = "Enter a Task Description:";
            // 
            // lbl_Date
            // 
            lbl_Date.Anchor = AnchorStyles.Bottom;
            lbl_Date.AutoSize = true;
            lbl_Date.Location = new Point(48, 61);
            lbl_Date.Margin = new Padding(4, 0, 4, 0);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(149, 25);
            lbl_Date.TabIndex = 13;
            lbl_Date.Text = "Enter a Due Date:";
            // 
            // chkbx_TaskDone
            // 
            chkbx_TaskDone.Anchor = AnchorStyles.Bottom;
            chkbx_TaskDone.AutoSize = true;
            chkbx_TaskDone.Location = new Point(131, 260);
            chkbx_TaskDone.Margin = new Padding(4);
            chkbx_TaskDone.Name = "chkbx_TaskDone";
            chkbx_TaskDone.Size = new Size(107, 29);
            chkbx_TaskDone.TabIndex = 12;
            chkbx_TaskDone.Text = "Is Done?";
            chkbx_TaskDone.UseVisualStyleBackColor = true;
            // 
            // txt_TaskDescription
            // 
            txt_TaskDescription.Anchor = AnchorStyles.Bottom;
            txt_TaskDescription.Location = new Point(48, 171);
            txt_TaskDescription.Margin = new Padding(4);
            txt_TaskDescription.Multiline = true;
            txt_TaskDescription.Name = "txt_TaskDescription";
            txt_TaskDescription.PlaceholderText = "Enter the task description";
            txt_TaskDescription.Size = new Size(312, 80);
            txt_TaskDescription.TabIndex = 11;
            // 
            // dtp_TaskDate
            // 
            dtp_TaskDate.Anchor = AnchorStyles.Bottom;
            dtp_TaskDate.CustomFormat = " ";
            dtp_TaskDate.Format = DateTimePickerFormat.Custom;
            dtp_TaskDate.Location = new Point(48, 90);
            dtp_TaskDate.Margin = new Padding(4);
            dtp_TaskDate.Name = "dtp_TaskDate";
            dtp_TaskDate.Size = new Size(312, 31);
            dtp_TaskDate.TabIndex = 10;
            dtp_TaskDate.Value = new DateTime(2025, 4, 3, 13, 37, 59, 0);
            dtp_TaskDate.ValueChanged += dtp_TaskDate_ValueChanged;
            // 
            // btn_EditedTask
            // 
            btn_EditedTask.Anchor = AnchorStyles.Bottom;
            btn_EditedTask.Location = new Point(149, 386);
            btn_EditedTask.Margin = new Padding(4);
            btn_EditedTask.Name = "btn_EditedTask";
            btn_EditedTask.Size = new Size(118, 38);
            btn_EditedTask.TabIndex = 9;
            btn_EditedTask.Text = "OK";
            btn_EditedTask.UseVisualStyleBackColor = true;
            btn_EditedTask.Click += btn_EditedTask_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Anchor = AnchorStyles.Bottom;
            btn_Cancel.Location = new Point(274, 388);
            btn_Cancel.Margin = new Padding(4);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(118, 36);
            btn_Cancel.TabIndex = 15;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // TaskEditor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 439);
            Controls.Add(btn_Cancel);
            Controls.Add(label1);
            Controls.Add(lbl_Date);
            Controls.Add(chkbx_TaskDone);
            Controls.Add(txt_TaskDescription);
            Controls.Add(dtp_TaskDate);
            Controls.Add(btn_EditedTask);
            Margin = new Padding(4);
            Name = "TaskEditor";
            Text = "TaskEditor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_Date;
        private CheckBox chkbx_TaskDone;
        private TextBox txt_TaskDescription;
        private DateTimePicker dtp_TaskDate;
        private Button btn_EditedTask;
        private Button btn_Cancel;
    }
}