namespace JackieZ_Group3_Lab89
{
    partial class s
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
            MyDayTasks = new Label();
            TodaysTasks = new ListBox();
            date = new Label();
            MarkTaskCompleteted = new CheckedListBox();
            CompletedTasks = new CheckedListBox();
            AddTasks = new Button();
            Export = new Button();
            Import = new Button();
            Evaluations = new ListBox();
            Courses = new ListBox();
            SuspendLayout();
            // 
            // MyDayTasks
            // 
            MyDayTasks.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            MyDayTasks.AutoSize = true;
            MyDayTasks.Location = new Point(292, 158);
            MyDayTasks.Margin = new Padding(2, 0, 2, 0);
            MyDayTasks.Name = "MyDayTasks";
            MyDayTasks.Size = new Size(96, 20);
            MyDayTasks.TabIndex = 0;
            MyDayTasks.Text = "My Day Tasks";
            // 
            // TodaysTasks
            // 
            TodaysTasks.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TodaysTasks.FormattingEnabled = true;
            TodaysTasks.Location = new Point(44, 241);
            TodaysTasks.Margin = new Padding(2);
            TodaysTasks.Name = "TodaysTasks";
            TodaysTasks.Size = new Size(208, 164);
            TodaysTasks.TabIndex = 1;
            TodaysTasks.SelectedIndexChanged += TodaysTasks_SelectedIndexChanged;
            // 
            // date
            // 
            date.AutoSize = true;
            date.Dock = DockStyle.Left;
            date.Location = new Point(0, 0);
            date.Margin = new Padding(2, 0, 2, 0);
            date.Name = "date";
            date.Size = new Size(44, 20);
            date.TabIndex = 4;
            date.Text = "Date:";
            date.Click += date_Click;
            // 
            // MarkTaskCompleteted
            // 
            MarkTaskCompleteted.FormattingEnabled = true;
            MarkTaskCompleteted.Location = new Point(55, 534);
            MarkTaskCompleteted.Name = "MarkTaskCompleteted";
            MarkTaskCompleteted.Size = new Size(256, 200);
            MarkTaskCompleteted.TabIndex = 6;
            MarkTaskCompleteted.SelectedIndexChanged += MarkTaskCompleteted_SelectedIndexChanged;
            // 
            // CompletedTasks
            // 
            CompletedTasks.FormattingEnabled = true;
            CompletedTasks.Location = new Point(44, 426);
            CompletedTasks.Margin = new Padding(2);
            CompletedTasks.Name = "CompletedTasks";
            CompletedTasks.Size = new Size(206, 180);
            CompletedTasks.TabIndex = 5;
            CompletedTasks.SelectedIndexChanged += CompletedTasks_SelectedIndexChanged;
            // 
            // AddTasks
            // 
            AddTasks.Location = new Point(44, 209);
            AddTasks.Margin = new Padding(2);
            AddTasks.Name = "AddTasks";
            AddTasks.Size = new Size(90, 27);
            AddTasks.TabIndex = 6;
            AddTasks.Text = "Add Tasks";
            AddTasks.UseVisualStyleBackColor = true;
            AddTasks.Click += AddTasks_Click;
            // 
            // Export
            // 
            Export.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Export.Location = new Point(422, 209);
            Export.Margin = new Padding(2);
            Export.Name = "Export";
            Export.Size = new Size(90, 27);
            Export.TabIndex = 9;
            Export.Text = "Export";
            Export.UseVisualStyleBackColor = true;
            Export.Click += Export_Click;
            // 
            // Import
            // 
            Import.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Import.Location = new Point(539, 209);
            Import.Margin = new Padding(2);
            Import.Name = "Import";
            Import.Size = new Size(90, 27);
            Import.TabIndex = 10;
            Import.Text = "Import";
            Import.UseVisualStyleBackColor = true;
            Import.Click += Import_Click;
            // 
            // Evaluations
            // 
            Evaluations.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Evaluations.FormattingEnabled = true;
            Evaluations.Location = new Point(422, 426);
            Evaluations.Margin = new Padding(2);
            Evaluations.Name = "Evaluations";
            Evaluations.Size = new Size(208, 164);
            Evaluations.TabIndex = 8;
            Evaluations.SelectedIndexChanged += Evaluations_SelectedIndexChanged;
            // 
            // Courses
            // 
            Courses.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Courses.FormattingEnabled = true;
            Courses.Location = new Point(422, 241);
            Courses.Margin = new Padding(2);
            Courses.Name = "Courses";
            Courses.Size = new Size(208, 164);
            Courses.TabIndex = 7;
            Courses.SelectedIndexChanged += Courses_SelectedIndexChanged;
            // 
            // s
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 701);
            Controls.Add(Import);
            Controls.Add(Export);
            Controls.Add(Evaluations);
            Controls.Add(Courses);
            Controls.Add(AddTasks);
            Controls.Add(CompletedTasks);
            Controls.Add(date);
            Controls.Add(TodaysTasks);
            Controls.Add(MyDayTasks);
            Margin = new Padding(2);
            Name = "s";
            Text = "MyDay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MyDayTasks;
        private ListBox TodaysTasks;
        private Label date;
        private CheckedListBox MarkTaskCompleteted;
        private CheckedListBox CompletedTasks;
        private Button AddTasks;
        private Button Export;
        private Button Import;
        private ListBox Evaluations;
        private ListBox Courses;
    }
}