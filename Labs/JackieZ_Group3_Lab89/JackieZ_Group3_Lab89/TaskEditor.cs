using Task = JackieZ_Group3_Lab89Library.Task;

namespace JackieZ_Group3_Lab89
{
    public partial class TaskEditor : Form
    {
        //Code by JackieZ - 301465524

        private Task taskToEdit;

        public TaskEditor(Task task)
        {
            taskToEdit = task;
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void TaskEditor_Load(object sender, EventArgs e)
        {
            try
            {
                txt_TaskDescription.Text = taskToEdit.Description;
                txt_DueDate.Text = taskToEdit.DueDate.ToString();
                chkbx_TaskDone.Checked = taskToEdit.IsDone;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            try
            {
                taskToEdit.Description = txt_TaskDescription.Text;
                taskToEdit.DueDate = DateTime.Parse(txt_DueDate.Text);
                taskToEdit.IsDone = chkbx_TaskDone.Checked;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }
    }
}