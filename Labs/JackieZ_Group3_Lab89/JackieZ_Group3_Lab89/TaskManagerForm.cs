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
            try
            {
                Task newTask = taskManager.CreateTask(txt_TaskDescription.Text);

                if (txt_DueDate.Text == null || txt_DueDate.Text == "")
                {
                }
                else
                {
                    newTask.DueDate = Convert.ToDateTime(txt_DueDate.Text);
                }
                newTask.IsDone = chkbx_TaskDone.Checked;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshTaskList();

            txt_TaskDescription.Text = "";
            txt_DueDate.Text = "";
            chkbx_TaskDone.Checked = false;
        }

        private void lbx_TaskList_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentlySelectedTask = lbx_TaskList.SelectedItem as Task;

            if (currentlySelectedTask != null)
            {
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