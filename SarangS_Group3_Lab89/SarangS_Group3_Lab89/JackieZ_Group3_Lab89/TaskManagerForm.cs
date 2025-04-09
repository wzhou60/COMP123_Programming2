using JackieZ_Group3_Lab89Library;
using Task = JackieZ_Group3_Lab89Library.Task;

namespace JackieZ_Group3_Lab89
{
    public partial class TaskManagerForm : Form
    {
        //private TaskManager taskManager = new TaskManager();
        //private string filePath = "tasks.json";
        private TaskManager taskManager;

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
                newTask.DueDate = dtp_TaskDate.Value;
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
        }

        private void btn_TaskEdit_Click(object sender, EventArgs e)
        {
            new TaskEditor().Show();
        }

        private void btn_DeleteTask_Click(object sender, EventArgs e)
        {
            if (lbx_TaskList.SelectedItem != null)
            {
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

        private void lbx_TaskList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}