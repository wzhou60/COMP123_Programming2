using SchoolLib;

namespace WinApp
{
    public partial class Form1 : Form
    {
        private List<Course> courses = new List<Course>();
        private List<Student> students = new List<Student>();
        private Student currentlySelectedStudent;
        private Course currentlySelectedCourse;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("You must enter a name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //lblHello.Text = $"Hello, {txtName.Text}";
                txtName.Text = "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();

            //try
            //{
            //    aStudent = new Student()
            //    {
            //        Name = txtName.Text,
            //        Id = Convert.ToInt32(txt_Id.Text),
            //        YOB = Convert.ToInt32(txtYob.Text)
            //    };
            //    lbx_Students.Items.Add(aStudent);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            StudentForm studentForm = new StudentForm(aStudent);
            DialogResult result = studentForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                students.Add(aStudent);
                lbx_Students.Items.Clear();
                foreach (Student student in students)
                {
                    lbx_Students.Items.Add(student);
                }
            }

            txtName.Text = "";
            txt_Id.Text = "";
            txtYob.Text = "";
        }

        private void lbx_Students_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Student aStudent = lbx_Students.SelectedItem as Student;
            currentlySelectedStudent = lbx_Students.SelectedItem as Student;

            if (currentlySelectedStudent != null)
            {
                txt_Id.Text = currentlySelectedStudent.Id.ToString();
                txtName.Text = currentlySelectedStudent.Name;
                txtYob.Text = currentlySelectedStudent.YOB.ToString();
                btnStudentEdit.Enabled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void btnCourseAdd_Click(object sender, EventArgs e)
        {
            Course course = null;

            try
            {
                course = new Course()
                {
                    Name = txtCourseName.Text,
                    Code = txtCourseCode.Text,
                };
                courses.Add(course);
                lbxCourse.Items.Clear();
                foreach (Course c in courses)
                {
                    lbxCourse.Items.Add(c);
                }
                txtCourseName.Text = "";
                txtCourseCode.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentlySelectedCourse = lbxCourse.SelectedItem as Course;

            if (currentlySelectedCourse != null)
            {
                txtCourseName.Text = currentlySelectedCourse.Name;
                txtCourseCode.Text = currentlySelectedCourse.Code;
            }
            //update CourseStudents list
            lbxCourseStudents.Items.Clear();
            foreach (Student c in currentlySelectedCourse.Students)
            {
                lbxCourseStudents.Items.Add(c);
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (currentlySelectedStudent != null && currentlySelectedCourse != null)
            {
                currentlySelectedCourse.AddStudent(currentlySelectedStudent);
            }

            lbxCourseStudents.Items.Clear();

            foreach (Student c in currentlySelectedCourse.Students)
            {
                lbxCourseStudents.Items.Add(c);
            }
        }

        private void btnStudentEdit_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm(currentlySelectedStudent);
            if (studentForm.ShowDialog() == DialogResult.OK)
            {
                updateStudentList();
            }
        }

        private void updateStudentList()
        {
            lbx_Students.Items.Clear();
            foreach (Student student in students)
            {
                lbx_Students.Items.Add(student);
            }
        }
    }
}