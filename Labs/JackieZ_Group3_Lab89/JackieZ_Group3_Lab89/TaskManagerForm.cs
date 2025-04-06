using JackieZ_Group3_Lab89Library;
using Task = JackieZ_Group3_Lab89Library.Task;

namespace JackieZ_Group3_Lab89
{
    public partial class TaskManagerForm : Form
    {
        //Code by JackieZ - 301465524
        private TaskManager taskManager;

        private Task currentlySelectedTask;

        public TaskManagerForm(TaskManager taskManager)
        {
            this.taskManager = taskManager;
            InitializeComponent();
            RefreshTaskList();
        }

        private void btn_TaskAdd_Click(object sender, EventArgs e)
        {
            string description = "";

            try
            {
                description = txt_TaskDescription.Text;
                Task newTask = taskManager.CreateTask(description);
                //newTask.DueDate = dtp_TaskDate.Value;
                if (txt_DueDate.Text == null || txt_DueDate.Text == "")
                {
                }
                else
                {
                    newTask.DueDate = DateTime.Parse(txt_DueDate.Text);
                }
                newTask.IsDone = chkbx_TaskDone.Checked;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lbx_TaskList.Items.Clear();
            foreach (Task task in taskManager.Tasks)
            {
                lbx_TaskList.Items.Add(task);
            }

            txt_TaskDescription.Text = "";
            txt_DueDate.Text = "";
            chkbx_TaskDone.Checked = false;
        }

        private void lbx_TaskList_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentlySelectedTask = lbx_TaskList.SelectedItem as Task;

            if (currentlySelectedTask != null)
            {
                //txt_Id.Text = currentlySelectedTask.Description;
                //txtName.Text = currentlySelectedTask.Name;
                //txtYob.Text = currentlySelectedTask.YOB.ToString();
                btn_TaskEdit.Enabled = true;
            }
            else
            {
                btn_TaskEdit.Enabled = false;
            }
        }

        private void btn_TaskEdit_Click(object sender, EventArgs e)
        {
            if (currentlySelectedTask == null)
            {
                MessageBox.Show("Please select a task to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TaskEditor taskEditor = new TaskEditor(currentlySelectedTask);
            if (taskEditor.ShowDialog() == DialogResult.OK)
            {
                RefreshTaskList();
            }
        }

        private void btn_DeleteTask_Click(object sender, EventArgs e)
        {
            if (lbx_TaskList.SelectedItem != null)
            {
                taskManager.Tasks.Remove(lbx_TaskList.SelectedItem as Task);
                lbx_TaskList.Items.Remove(lbx_TaskList.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select a task to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_TaskExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void RefreshTaskList()
        {
            lbx_TaskList.Items.Clear();
            foreach (Task task in taskManager.Tasks)
            {
                lbx_TaskList.Items.Add(task);
            }
        }
    }
}