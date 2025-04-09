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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            grp_AddTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbx_TaskList
            // 
            lbx_TaskList.FormattingEnabled = true;
            lbx_TaskList.HorizontalScrollbar = true;
            lbx_TaskList.ItemHeight = 15;
            lbx_TaskList.Location = new Point(300, 187);
            lbx_TaskList.Margin = new Padding(3, 2, 3, 2);
            lbx_TaskList.Name = "lbx_TaskList";
            lbx_TaskList.Size = new Size(439, 139);
            lbx_TaskList.TabIndex = 0;
            lbx_TaskList.SelectedIndexChanged += lbx_TaskList_SelectedIndexChanged;
            // 
            // btn_TaskAdd
            // 
            btn_TaskAdd.Location = new Point(74, 189);
            btn_TaskAdd.Margin = new Padding(3, 2, 3, 2);
            btn_TaskAdd.Name = "btn_TaskAdd";
            btn_TaskAdd.Size = new Size(82, 22);
            btn_TaskAdd.TabIndex = 1;
            btn_TaskAdd.Text = "Add Task";
            btn_TaskAdd.UseVisualStyleBackColor = true;
            btn_TaskAdd.Click += btn_TaskAdd_Click;
            // 
            // btn_TaskEdit
            // 
            btn_TaskEdit.Enabled = false;
            btn_TaskEdit.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_TaskEdit.Location = new Point(300, 340);
            btn_TaskEdit.Margin = new Padding(3, 2, 3, 2);
            btn_TaskEdit.Name = "btn_TaskEdit";
            btn_TaskEdit.Size = new Size(82, 22);
            btn_TaskEdit.TabIndex = 2;
            btn_TaskEdit.Text = "Edit Task";
            btn_TaskEdit.UseVisualStyleBackColor = true;
            btn_TaskEdit.Click += btn_TaskEdit_Click;
            // 
            // btn_TaskExit
            // 
            btn_TaskExit.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_TaskExit.Location = new Point(667, 346);
            btn_TaskExit.Margin = new Padding(3, 2, 3, 2);
            btn_TaskExit.Name = "btn_TaskExit";
            btn_TaskExit.Size = new Size(82, 22);
            btn_TaskExit.TabIndex = 4;
            btn_TaskExit.Text = "Exit";
            btn_TaskExit.UseVisualStyleBackColor = true;
            btn_TaskExit.Click += btn_TaskExit_Click;
            // 
            // txt_TaskDescription
            // 
            txt_TaskDescription.Location = new Point(16, 102);
            txt_TaskDescription.Margin = new Padding(3, 2, 3, 2);
            txt_TaskDescription.Multiline = true;
            txt_TaskDescription.Name = "txt_TaskDescription";
            txt_TaskDescription.PlaceholderText = "Enter the task description";
            txt_TaskDescription.Size = new Size(219, 50);
            txt_TaskDescription.TabIndex = 5;
            // 
            // chkbx_TaskDone
            // 
            chkbx_TaskDone.AutoSize = true;
            chkbx_TaskDone.Location = new Point(74, 154);
            chkbx_TaskDone.Margin = new Padding(3, 2, 3, 2);
            chkbx_TaskDone.Name = "chkbx_TaskDone";
            chkbx_TaskDone.Size = new Size(82, 19);
            chkbx_TaskDone.TabIndex = 6;
            chkbx_TaskDone.Text = "Is Done?";
            chkbx_TaskDone.UseVisualStyleBackColor = true;
            // 
            // lbl_Date
            // 
            lbl_Date.AutoSize = true;
            lbl_Date.Location = new Point(16, 36);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(126, 15);
            lbl_Date.TabIndex = 7;
            lbl_Date.Text = "Enter a Due Date:";
            // 
            // lbl_TaskDescription
            // 
            lbl_TaskDescription.AutoSize = true;
            lbl_TaskDescription.Location = new Point(16, 85);
            lbl_TaskDescription.Name = "lbl_TaskDescription";
            lbl_TaskDescription.Size = new Size(182, 15);
            lbl_TaskDescription.TabIndex = 8;
            lbl_TaskDescription.Text = "Enter a Task Description:";
            // 
            // btn_DeleteTask
            // 
            btn_DeleteTask.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_DeleteTask.Location = new Point(398, 340);
            btn_DeleteTask.Margin = new Padding(3, 2, 3, 2);
            btn_DeleteTask.Name = "btn_DeleteTask";
            btn_DeleteTask.Size = new Size(94, 22);
            btn_DeleteTask.TabIndex = 9;
            btn_DeleteTask.Text = "Delete Task";
            btn_DeleteTask.UseVisualStyleBackColor = true;
            btn_DeleteTask.Click += btn_DeleteTask_Click;
            // 
            // txt_DueDate
            // 
            txt_DueDate.Location = new Point(16, 53);
            txt_DueDate.Margin = new Padding(3, 2, 3, 2);
            txt_DueDate.Name = "txt_DueDate";
            txt_DueDate.Size = new Size(219, 23);
            txt_DueDate.TabIndex = 17;
            // 
            // grp_AddTask
            // 
            grp_AddTask.BackColor = SystemColors.GradientActiveCaption;
            grp_AddTask.Controls.Add(txt_DueDate);
            grp_AddTask.Controls.Add(lbl_Date);
            grp_AddTask.Controls.Add(btn_TaskAdd);
            grp_AddTask.Controls.Add(lbl_TaskDescription);
            grp_AddTask.Controls.Add(txt_TaskDescription);
            grp_AddTask.Controls.Add(chkbx_TaskDone);
            grp_AddTask.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grp_AddTask.Location = new Point(25, 151);
            grp_AddTask.Margin = new Padding(3, 2, 3, 2);
            grp_AddTask.Name = "grp_AddTask";
            grp_AddTask.Padding = new Padding(3, 2, 3, 2);
            grp_AddTask.Size = new Size(253, 217);
            grp_AddTask.TabIndex = 18;
            grp_AddTask.TabStop = false;
            grp_AddTask.Text = "Create a Task";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cc_logo;
            pictureBox1.Location = new Point(29, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(326, 31);
            label1.Name = "label1";
            label1.Size = new Size(195, 37);
            label1.TabIndex = 20;
            label1.Text = "Task Manager";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 128);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(718, 100);
            panel1.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(466, 151);
            label2.Name = "label2";
            label2.Size = new Size(104, 30);
            label2.TabIndex = 22;
            label2.Text = "Task Lists";
            // 
            // TaskManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(761, 379);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btn_DeleteTask);
            Controls.Add(btn_TaskExit);
            Controls.Add(btn_TaskEdit);
            Controls.Add(lbx_TaskList);
            Controls.Add(grp_AddTask);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TaskManagerForm";
            Text = "TaskManagerForm";
            grp_AddTask.ResumeLayout(false);
            grp_AddTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Label label2;
    }
}