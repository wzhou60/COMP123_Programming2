using JackieZ_Group3_Lab89Library;

namespace JackieZ_Group3_Lab89
{
    public partial class CourseEditor : Form
    {
        //Code by JackieZ - 301465524

        private Course courseToEdit;

        public CourseEditor(Course course)
        {
            courseToEdit = course;
            InitializeComponent();
        }

        private void CourseEditor_Load(object sender, EventArgs e)
        {
            try
            {
                txt_CourseCode.Text = courseToEdit.Code;
                //txt_CourseID.Text = courseToEdit.Id.ToString();
                txt_CourseName.Text = courseToEdit.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                courseToEdit.Code = txt_CourseCode.Text;
                //courseToEdit.Id = DateTime.Parse(txt_DueDate.Text);
                courseToEdit.Name = txt_CourseName.Text;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}