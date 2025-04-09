using JackieZ_Group3_Lab89Library;

namespace JackieZ_Group3_Lab89
{
    public partial class CourseManagerForm : Form
    {
        //Code by JackieZ - 301465524

        private CourseManager courseManager;

        private Course currentlySelectedCourse;

        public CourseManagerForm(CourseManager courseManager)
        {
            this.courseManager = courseManager;
            InitializeComponent();
            RefreshCourseList();
        }

        private void RefreshCourseList()
        {
            lbx_CourseList.Items.Clear();
            foreach (Course course in courseManager.Courses)
            {
                lbx_CourseList.Items.Add(course);
            }
        }

        private void btn_CourseAdd_Click(object sender, EventArgs e)
        {
            //Course newCourse;

            try
            {
                // courseCode = txt_CourseCode.Text;
                Course newCourse = new Course(Convert.ToUInt32(txt_CourseID.Text), txt_CourseCode.Text)
                { Name = txt_CourseName.Text };

                if (newCourse != null)
                {
                    courseManager.AddCourse(newCourse);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshCourseList();

            txt_CourseID.Text = "";
            txt_CourseCode.Text = "";
            txt_CourseName.Text = "";
        }

        private void lbx_CourseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentlySelectedCourse = lbx_CourseList.SelectedItem as Course;

            if (currentlySelectedCourse != null)
            {
                btn_CourseEdit.Enabled = true;
                btn_ViewEvals.Enabled = true;
            }
            else
            {
                btn_CourseEdit.Enabled = false;
                btn_ViewEvals.Enabled = false;
            }
        }

        private void btn_CourseEdit_Click(object sender, EventArgs e)
        {
            CourseEditor courseEditor = new CourseEditor(currentlySelectedCourse);
            if (courseEditor.ShowDialog() == DialogResult.OK)
            {
                RefreshCourseList();
            }
        }

        private void btn_ViewEvals_Click(object sender, EventArgs e)
        {
            new ViewEvaluationsForm(currentlySelectedCourse).Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}