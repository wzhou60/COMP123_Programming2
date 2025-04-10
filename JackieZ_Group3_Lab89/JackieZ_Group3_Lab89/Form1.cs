using JackieZ_Group3_Lab89Library;

namespace JackieZ_Group3_Lab89
{
    public partial class Form1 : Form
    {
        public TaskManager taskManager = new TaskManager();
        public CourseManager courseManager = new CourseManager();
        public MyDay myDay = MyDay.NewDay();

        public Form1()
        {
            InitializeComponent();
        }

        //Code by JackieZ - 301465524
        private void btn_Tasks_Click(object sender, EventArgs e)
        {
            new TaskManagerForm(taskManager, myDay).Show();
        }

        private void btn_Course_Click(object sender, EventArgs e)
        {
            new CourseManagerForm(courseManager).Show();
        }

        private void btn_TaskJSONExport_Click(object sender, EventArgs e)
        {
            try
            {
                taskManager.Save("Tasks.json");
                lbl_TaskIOStatus.Text = "Export Successful!";
                lbl_TaskIOStatus.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_TaskJSONImport_Click(object sender, EventArgs e)
        {
            try
            {
                taskManager.Load("Tasks.json");
                lbl_TaskIOStatus.Text = "Import Successful!";
                lbl_TaskIOStatus.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_CoursesJSONExport_Click(object sender, EventArgs e)
        {
            try
            {
                courseManager.Save("Courses.json");
                lbl_IOCourseStatus.Text = "Export Successful!";
                lbl_IOCourseStatus.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_CoursesJSONImport_Click(object sender, EventArgs e)
        {
            try
            {
                courseManager.Load("Courses.json");
                lbl_IOCourseStatus.Text = "Import Successful!";
                lbl_IOCourseStatus.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}