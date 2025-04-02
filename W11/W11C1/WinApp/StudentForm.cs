using SchoolLib;

namespace WinApp
{
    public partial class StudentForm : Form
    {
        private Student student;

        public StudentForm(Student student)
        {
            this.student = student;
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            if (student.Id != 0)
            {
                try
                {
                    txt_Id.Text = student.Id.ToString();
                    txtName.Text = student.Name;
                    txtYob.Text = student.YOB.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            try
            {
                student.Name = txtName.Text;
                student.Id = Convert.ToInt32(txt_Id.Text);
                student.YOB = Convert.ToInt32(txtYob.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}