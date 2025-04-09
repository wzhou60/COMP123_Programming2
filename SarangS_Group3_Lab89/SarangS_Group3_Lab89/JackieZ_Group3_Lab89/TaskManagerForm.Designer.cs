namespace JackieZ_Group3_Lab89
{
    partial class TaskManagerForm
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
            lbx_TaskList = new ListBox();
            btn_TaskAdd = new Button();
            btn_TaskEdit = new Button();
            dtp_TaskDate = new DateTimePicker();
            btn_TaskExit = new Button();
            txt_TaskDescription = new TextBox();
            chkbx_TaskDone = new CheckBox();
            lbl_Date = new Label();
            label1 = new Label();
            btn_DeleteTask = new Button();
            SuspendLayout();
            // 
            // lbx_TaskList
            // 
            lbx_TaskList.FormattingEnabled = true;
            lbx_TaskList.ItemHeight = 25;
            lbx_TaskList.Location = new Point(482, 99);
            lbx_TaskList.Margin = new Padding(4, 4, 4, 4);
            lbx_TaskList.Name = "lbx_TaskList";
            lbx_TaskList.Size = new Size(463, 154);
            lbx_TaskList.TabIndex = 0;
            lbx_TaskList.SelectedIndexChanged += lbx_TaskList_SelectedIndexChanged;
            // 
            // btn_TaskAdd
            // 
            btn_TaskAdd.Location = new Point(149, 325);
            btn_TaskAdd.Margin = new Padding(4, 4, 4, 4);
            btn_TaskAdd.Name = "btn_TaskAdd";
            btn_TaskAdd.Size = new Size(118, 38);
            btn_TaskAdd.TabIndex = 1;
            btn_TaskAdd.Text = "Add Task";
            btn_TaskAdd.UseVisualStyleBackColor = true;
            btn_TaskAdd.Click += btn_TaskAdd_Click;
            // 
            // btn_TaskEdit
            // 
            btn_TaskEdit.Location = new Point(482, 268);
            btn_TaskEdit.Margin = new Padding(4, 4, 4, 4);
            btn_TaskEdit.Name = "btn_TaskEdit";
            btn_TaskEdit.Size = new Size(118, 36);
            btn_TaskEdit.TabIndex = 2;
            btn_TaskEdit.Text = "Edit Task";
            btn_TaskEdit.UseVisualStyleBackColor = true;
            btn_TaskEdit.Click += btn_TaskEdit_Click;
            // 
            // dtp_TaskDate
            // 
            dtp_TaskDate.CustomFormat = " ";
            dtp_TaskDate.Format = DateTimePickerFormat.Custom;
            dtp_TaskDate.Location = new Point(66, 99);
            dtp_TaskDate.Margin = new Padding(4, 4, 4, 4);
            dtp_TaskDate.Name = "dtp_TaskDate";
            dtp_TaskDate.Size = new Size(312, 31);
            dtp_TaskDate.TabIndex = 3;
            dtp_TaskDate.Value = new DateTime(2025, 4, 3, 13, 37, 59, 0);
            // 
            // btn_TaskExit
            // 
            btn_TaskExit.Location = new Point(868, 511);
            btn_TaskExit.Margin = new Padding(4, 4, 4, 4);
            btn_TaskExit.Name = "btn_TaskExit";
            btn_TaskExit.Size = new Size(118, 36);
            btn_TaskExit.TabIndex = 4;
            btn_TaskExit.Text = "Exit";
            btn_TaskExit.UseVisualStyleBackColor = true;
            btn_TaskExit.Click += btn_TaskExit_Click;
            // 
            // txt_TaskDescription
            // 
            txt_TaskDescription.Location = new Point(66, 180);
            txt_TaskDescription.Margin = new Padding(4, 4, 4, 4);
            txt_TaskDescription.Multiline = true;
            txt_TaskDescription.Name = "txt_TaskDescription";
            txt_TaskDescription.PlaceholderText = "Enter the task description";
            txt_TaskDescription.Size = new Size(312, 80);
            txt_TaskDescription.TabIndex = 5;
            // 
            // chkbx_TaskDone
            // 
            chkbx_TaskDone.AutoSize = true;
            chkbx_TaskDone.Location = new Point(150, 268);
            chkbx_TaskDone.Margin = new Padding(4, 4, 4, 4);
            chkbx_TaskDone.Name = "chkbx_TaskDone";
            chkbx_TaskDone.Size = new Size(107, 29);
            chkbx_TaskDone.TabIndex = 6;
            chkbx_TaskDone.Text = "Is Done?";
            chkbx_TaskDone.UseVisualStyleBackColor = true;
            // 
            // lbl_Date
            // 
            lbl_Date.AutoSize = true;
            lbl_Date.Location = new Point(66, 70);
            lbl_Date.Margin = new Padding(4, 0, 4, 0);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(149, 25);
            lbl_Date.TabIndex = 7;
            lbl_Date.Text = "Enter a Due Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 151);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(203, 25);
            label1.TabIndex = 8;
            label1.Text = "Enter a Task Description:";
            // 
            // btn_DeleteTask
            // 
            btn_DeleteTask.Location = new Point(829, 268);
            btn_DeleteTask.Margin = new Padding(4, 4, 4, 4);
            btn_DeleteTask.Name = "btn_DeleteTask";
            btn_DeleteTask.Size = new Size(118, 36);
            btn_DeleteTask.TabIndex = 9;
            btn_DeleteTask.Text = "Delete Task";
            btn_DeleteTask.UseVisualStyleBackColor = true;
            btn_DeleteTask.Click += btn_DeleteTask_Click;
            // 
            // TaskManagerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btn_DeleteTask);
            Controls.Add(label1);
            Controls.Add(lbl_Date);
            Controls.Add(chkbx_TaskDone);
            Controls.Add(txt_TaskDescription);
            Controls.Add(btn_TaskExit);
            Controls.Add(dtp_TaskDate);
            Controls.Add(btn_TaskEdit);
            Controls.Add(btn_TaskAdd);
            Controls.Add(lbx_TaskList);
            Margin = new Padding(4, 4, 4, 4);
            Name = "TaskManagerForm";
            Text = "TaskManagerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbx_TaskList;
        private Button btn_TaskAdd;
        private Button btn_TaskEdit;
        private DateTimePicker dtp_TaskDate;
        private Button btn_TaskExit;
        private TextBox txt_TaskDescription;
        private CheckBox chkbx_TaskDone;
        private Label lbl_Date;
        private Label label1;
        private Button btn_DeleteTask;
    }
}