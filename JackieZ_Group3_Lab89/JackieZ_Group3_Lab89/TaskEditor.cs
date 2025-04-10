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
            try
            {
                if (txt_DueDate.Text == null || txt_DueDate.Text == "")
                {
                }
                else
                {
                    if (Convert.ToDateTime(txt_DueDate.Text) < DateTime.Today)
                    {
                        throw new ArgumentException("The due date must be in the future.");
                    }
                    else if (Convert.ToDateTime(txt_DueDate.Text).Day == DateTime.Today.Day)
                    {
                        DateTime input = Convert.ToDateTime(txt_DueDate.Text);
                        DateTime now = DateTime.Now;

                        if (input.TimeOfDay > now.TimeOfDay)
                        {
                            taskToEdit.DueDate = input;
                        }
                        else
                        {
                            taskToEdit.DueDate = input.Date.AddHours(23).AddMinutes(59);
                        }
                    }
                    else
                    {
                        taskToEdit.DueDate = Convert.ToDateTime(txt_DueDate.Text);
                    }
                }

                taskToEdit.Description = txt_TaskDescription.Text;
                taskToEdit.IsDone = chkbx_TaskDone.Checked;
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