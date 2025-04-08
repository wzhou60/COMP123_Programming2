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
            btn_TaskExit = new Button();
            txt_TaskDescription = new TextBox();
            chkbx_TaskDone = new CheckBox();
            lbl_Date = new Label();
            lbl_TaskDescription = new Label();
            btn_DeleteTask = new Button();
            txt_DueDate = new TextBox();
            grp_AddTask = new GroupBox();
            grp_AddTask.SuspendLayout();
            SuspendLayout();
            // 
            // lbx_TaskList
            // 
            lbx_TaskList.FormattingEnabled = true;
            lbx_TaskList.HorizontalScrollbar = true;
            lbx_TaskList.Location = new Point(325, 79);
            lbx_TaskList.Name = "lbx_TaskList";
            lbx_TaskList.Size = new Size(444, 124);
            lbx_TaskList.TabIndex = 0;
            lbx_TaskList.SelectedIndexChanged += lbx_TaskList_SelectedIndexChanged;
            // 
            // btn_TaskAdd
            // 
            btn_TaskAdd.Location = new Point(84, 252);
            btn_TaskAdd.Name = "btn_TaskAdd";
            btn_TaskAdd.Size = new Size(94, 30);
            btn_TaskAdd.TabIndex = 1;
            btn_TaskAdd.Text = "Add Task";
            btn_TaskAdd.UseVisualStyleBackColor = true;
            btn_TaskAdd.Click += btn_TaskAdd_Click;
            // 
            // btn_TaskEdit
            // 
            btn_TaskEdit.Enabled = false;
            btn_TaskEdit.Location = new Point(325, 214);
            btn_TaskEdit.Name = "btn_TaskEdit";
            btn_TaskEdit.Size = new Size(94, 29);
            btn_TaskEdit.TabIndex = 2;
            btn_TaskEdit.Text = "Edit Task";
            btn_TaskEdit.UseVisualStyleBackColor = true;
            btn_TaskEdit.Click += btn_TaskEdit_Click;
            // 
            // btn_TaskExit
            // 
            btn_TaskExit.Location = new Point(694, 409);
            btn_TaskExit.Name = "btn_TaskExit";
            btn_TaskExit.Size = new Size(94, 29);
            btn_TaskExit.TabIndex = 4;
            btn_TaskExit.Text = "Exit";
            btn_TaskExit.UseVisualStyleBackColor = true;
            btn_TaskExit.Click += btn_TaskExit_Click;
            // 
            // txt_TaskDescription
            // 
            txt_TaskDescription.Location = new Point(18, 136);
            txt_TaskDescription.Multiline = true;
            txt_TaskDescription.Name = "txt_TaskDescription";
            txt_TaskDescription.PlaceholderText = "Enter the task description";
            txt_TaskDescription.Size = new Size(250, 65);
            txt_TaskDescription.TabIndex = 5;
            // 
            // chkbx_TaskDone
            // 
            chkbx_TaskDone.AutoSize = true;
            chkbx_TaskDone.Location = new Point(85, 206);
            chkbx_TaskDone.Name = "chkbx_TaskDone";
            chkbx_TaskDone.Size = new Size(88, 24);
            chkbx_TaskDone.TabIndex = 6;
            chkbx_TaskDone.Text = "Is Done?";
            chkbx_TaskDone.UseVisualStyleBackColor = true;
            // 
            // lbl_Date
            // 
            lbl_Date.AutoSize = true;
            lbl_Date.Location = new Point(18, 48);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(125, 20);
            lbl_Date.TabIndex = 7;
            lbl_Date.Text = "Enter a Due Date:";
            // 
            // lbl_TaskDescription
            // 
            lbl_TaskDescription.AutoSize = true;
            lbl_TaskDescription.Location = new Point(18, 113);
            lbl_TaskDescription.Name = "lbl_TaskDescription";
            lbl_TaskDescription.Size = new Size(169, 20);
            lbl_TaskDescription.TabIndex = 8;
            lbl_TaskDescription.Text = "Enter a Task Description:";
            // 
            // btn_DeleteTask
            // 
            btn_DeleteTask.Location = new Point(675, 211);
            btn_DeleteTask.Name = "btn_DeleteTask";
            btn_DeleteTask.Size = new Size(94, 29);
            btn_DeleteTask.TabIndex = 9;
            btn_DeleteTask.Text = "Delete Task";
            btn_DeleteTask.UseVisualStyleBackColor = true;
            btn_DeleteTask.Click += btn_DeleteTask_Click;
            // 
            // txt_DueDate
            // 
            txt_DueDate.Location = new Point(18, 71);
            txt_DueDate.Name = "txt_DueDate";
            txt_DueDate.Size = new Size(250, 27);
            txt_DueDate.TabIndex = 17;
            // 
            // grp_AddTask
            // 
            grp_AddTask.Controls.Add(txt_DueDate);
            grp_AddTask.Controls.Add(lbl_Date);
            grp_AddTask.Controls.Add(btn_TaskAdd);
            grp_AddTask.Controls.Add(lbl_TaskDescription);
            grp_AddTask.Controls.Add(txt_TaskDescription);
            grp_AddTask.Controls.Add(chkbx_TaskDone);
            grp_AddTask.Location = new Point(19, 39);
            grp_AddTask.Name = "grp_AddTask";
            grp_AddTask.Size = new Size(289, 307);
            grp_AddTask.TabIndex = 18;
            grp_AddTask.TabStop = false;
            grp_AddTask.Text = "Create a Task";
            // 
            // TaskManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_DeleteTask);
            Controls.Add(btn_TaskExit);
            Controls.Add(btn_TaskEdit);
            Controls.Add(lbx_TaskList);
            Controls.Add(grp_AddTask);
            Name = "TaskManagerForm";
            Text = "TaskManagerForm";
            grp_AddTask.ResumeLayout(false);
            grp_AddTask.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbx_TaskList;
        private Button btn_TaskAdd;
        private Button btn_TaskEdit;
        private Button btn_TaskExit;
        private TextBox txt_TaskDescription;
        private CheckBox chkbx_TaskDone;
        private Label lbl_Date;
        private Label lbl_TaskDescription;
        private Button btn_DeleteTask;
        private TextBox txt_DueDate;
        private GroupBox grp_AddTask;
    }
}