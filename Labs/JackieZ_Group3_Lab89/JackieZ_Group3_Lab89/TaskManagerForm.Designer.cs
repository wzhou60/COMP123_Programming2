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
            grp_AddTask = new GroupBox();
            txt_DueDate = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pnl_Title = new Panel();
            label2 = new Label();
            lbx_MyDay = new ListBox();
            panel1 = new Panel();
            lbl_Title = new Label();
            label3 = new Label();
            grp_AddTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnl_Title.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbx_TaskList
            // 
            lbx_TaskList.FormattingEnabled = true;
            lbx_TaskList.HorizontalScrollbar = true;
            lbx_TaskList.Location = new Point(334, 214);
            lbx_TaskList.Name = "lbx_TaskList";
            lbx_TaskList.Size = new Size(501, 184);
            lbx_TaskList.TabIndex = 0;
            lbx_TaskList.SelectedIndexChanged += lbx_TaskList_SelectedIndexChanged;
            // 
            // btn_TaskAdd
            // 
            btn_TaskAdd.Location = new Point(88, 245);
            btn_TaskAdd.Name = "btn_TaskAdd";
            btn_TaskAdd.Size = new Size(94, 29);
            btn_TaskAdd.TabIndex = 1;
            btn_TaskAdd.Text = "Add Task";
            btn_TaskAdd.UseVisualStyleBackColor = true;
            btn_TaskAdd.Click += btn_TaskAdd_Click;
            // 
            // btn_TaskEdit
            // 
            btn_TaskEdit.Enabled = false;
            btn_TaskEdit.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_TaskEdit.Location = new Point(334, 410);
            btn_TaskEdit.Name = "btn_TaskEdit";
            btn_TaskEdit.Size = new Size(94, 29);
            btn_TaskEdit.TabIndex = 2;
            btn_TaskEdit.Text = "Edit Task";
            btn_TaskEdit.UseVisualStyleBackColor = true;
            btn_TaskEdit.Click += btn_TaskEdit_Click;
            // 
            // btn_TaskExit
            // 
            btn_TaskExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_TaskExit.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_TaskExit.Location = new Point(1081, 491);
            btn_TaskExit.Name = "btn_TaskExit";
            btn_TaskExit.Size = new Size(94, 29);
            btn_TaskExit.TabIndex = 4;
            btn_TaskExit.Text = "Exit";
            btn_TaskExit.UseVisualStyleBackColor = true;
            btn_TaskExit.Click += btn_TaskExit_Click;
            // 
            // txt_TaskDescription
            // 
            txt_TaskDescription.Location = new Point(18, 129);
            txt_TaskDescription.Multiline = true;
            txt_TaskDescription.Name = "txt_TaskDescription";
            txt_TaskDescription.PlaceholderText = "Enter the task description";
            txt_TaskDescription.Size = new Size(250, 65);
            txt_TaskDescription.TabIndex = 5;
            // 
            // chkbx_TaskDone
            // 
            chkbx_TaskDone.AutoSize = true;
            chkbx_TaskDone.Location = new Point(85, 201);
            chkbx_TaskDone.Name = "chkbx_TaskDone";
            chkbx_TaskDone.Size = new Size(103, 24);
            chkbx_TaskDone.TabIndex = 6;
            chkbx_TaskDone.Text = "Is Done?";
            chkbx_TaskDone.UseVisualStyleBackColor = true;
            // 
            // lbl_Date
            // 
            lbl_Date.AutoSize = true;
            lbl_Date.Location = new Point(18, 41);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(162, 20);
            lbl_Date.TabIndex = 7;
            lbl_Date.Text = "Enter a Due Date:";
            // 
            // lbl_TaskDescription
            // 
            lbl_TaskDescription.AutoSize = true;
            lbl_TaskDescription.Location = new Point(18, 106);
            lbl_TaskDescription.Name = "lbl_TaskDescription";
            lbl_TaskDescription.Size = new Size(234, 20);
            lbl_TaskDescription.TabIndex = 8;
            lbl_TaskDescription.Text = "Enter a Task Description:";
            // 
            // btn_DeleteTask
            // 
            btn_DeleteTask.Enabled = false;
            btn_DeleteTask.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_DeleteTask.Location = new Point(728, 410);
            btn_DeleteTask.Name = "btn_DeleteTask";
            btn_DeleteTask.Size = new Size(107, 29);
            btn_DeleteTask.TabIndex = 9;
            btn_DeleteTask.Text = "Delete Task";
            btn_DeleteTask.UseVisualStyleBackColor = true;
            btn_DeleteTask.Click += btn_DeleteTask_Click;
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
            grp_AddTask.Location = new Point(14, 167);
            grp_AddTask.Name = "grp_AddTask";
            grp_AddTask.Size = new Size(289, 289);
            grp_AddTask.TabIndex = 18;
            grp_AddTask.TabStop = false;
            grp_AddTask.Text = "Create a Task";
            // 
            // txt_DueDate
            // 
            txt_DueDate.Location = new Point(18, 72);
            txt_DueDate.Name = "txt_DueDate";
            txt_DueDate.Size = new Size(250, 27);
            txt_DueDate.TabIndex = 9;
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
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(373, 41);
            label1.Name = "label1";
            label1.Size = new Size(241, 46);
            label1.TabIndex = 20;
            label1.Text = "Task Manager";
            // 
            // pnl_Title
            // 
            pnl_Title.BackColor = Color.FromArgb(255, 255, 128);
            pnl_Title.Controls.Add(pictureBox1);
            pnl_Title.Controls.Add(label1);
            pnl_Title.Location = new Point(14, 16);
            pnl_Title.Margin = new Padding(3, 4, 3, 4);
            pnl_Title.Name = "pnl_Title";
            pnl_Title.Size = new Size(821, 133);
            pnl_Title.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(524, 167);
            label2.Name = "label2";
            label2.Size = new Size(137, 37);
            label2.TabIndex = 22;
            label2.Text = "Task Lists";
            // 
            // lbx_MyDay
            // 
            lbx_MyDay.FormattingEnabled = true;
            lbx_MyDay.HorizontalScrollbar = true;
            lbx_MyDay.Location = new Point(867, 214);
            lbx_MyDay.Name = "lbx_MyDay";
            lbx_MyDay.Size = new Size(289, 244);
            lbx_MyDay.TabIndex = 23;
            lbx_MyDay.SelectedIndexChanged += lbx_MyDay_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 128);
            panel1.Controls.Add(lbl_Title);
            panel1.Location = new Point(867, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 133);
            panel1.TabIndex = 24;
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.Location = new Point(81, 41);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(141, 46);
            lbl_Title.TabIndex = 20;
            lbl_Title.Text = "My Day";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(924, 167);
            label3.Name = "label3";
            label3.Size = new Size(190, 37);
            label3.TabIndex = 25;
            label3.Text = "Today's Tasks";
            // 
            // TaskManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1187, 532);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(lbx_MyDay);
            Controls.Add(label2);
            Controls.Add(pnl_Title);
            Controls.Add(btn_DeleteTask);
            Controls.Add(btn_TaskExit);
            Controls.Add(btn_TaskEdit);
            Controls.Add(lbx_TaskList);
            Controls.Add(grp_AddTask);
            Name = "TaskManagerForm";
            Text = "TaskManagerForm";
            grp_AddTask.ResumeLayout(false);
            grp_AddTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnl_Title.ResumeLayout(false);
            pnl_Title.PerformLayout();
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
        private GroupBox grp_AddTask;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel pnl_Title;
        private Label label2;
        private ListBox lbx_MyDay;
        private Panel panel1;
        private Label lbl_Title;
        private Label label3;
        private TextBox txt_DueDate;
    }
}