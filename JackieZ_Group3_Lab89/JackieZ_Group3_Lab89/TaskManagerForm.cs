using JackieZ_Group3_Lab89Library;
using Task = JackieZ_Group3_Lab89Library.Task;

namespace JackieZ_Group3_Lab89
{
    public partial class TaskManagerForm : Form
    {
        //Code by JackieZ - 301465524
        private TaskManager taskManager;

        private MyDay myDay;
        private Task currentlySelectedTask;

        public TaskManagerForm(TaskManager taskManager, MyDay myDay)
        {
            this.myDay = myDay;
            this.taskManager = taskManager;
            InitializeComponent();
            RefreshTaskList();
        }

        private void btn_TaskAdd_Click(object sender, EventArgs e)
        {
            bool remove = true;
            DateTime dueDate;
            try
            {
                Task newTask = taskManager.CreateTask(txt_TaskDescription.Text);
                newTask.IsDone = chkbx_TaskDone.Checked;

                if (txt_DueDate.Text == null || txt_DueDate.Text == "")
                {
                }
                else
                {
                    if (Convert.ToDateTime(txt_DueDate.Text) < DateTime.Today)
                    {
                        remove = false;
                        taskManager.Tasks.Remove(newTask);
                        MessageBox.Show("The due date must be in the future.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (Convert.ToDateTime(txt_DueDate.Text).Day == DateTime.Today.Day)
                    {
                        DateTime input = Convert.ToDateTime(txt_DueDate.Text);
                        DateTime now = DateTime.Now;

                        if (input.TimeOfDay > now.TimeOfDay)
                        {
                            newTask.DueDate = input;
                        }
                        else
                        {
                            newTask.DueDate = input.Date.AddHours(23).AddMinutes(59);
                        }
                    }
                    else
                    {
                        newTask.DueDate = Convert.ToDateTime(txt_DueDate.Text);
                        newTask.IsDone = chkbx_TaskDone.Checked;
                    }
                    if (newTask.DueDate.Day == DateTime.Today.Day)
                    {
                        myDay.TodaysTasks.Add(newTask);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshTaskList();
            if (remove)
            {
                txt_TaskDescription.Text = "";
                txt_DueDate.Text = "";
                chkbx_TaskDone.Checked = false;
            }
        }

        private void lbx_TaskList_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentlySelectedTask = lbx_TaskList.SelectedItem as Task;

            if (currentlySelectedTask != null)
            {
                btn_TaskEdit.Enabled = true;
                btn_DeleteTask.Enabled = true;
            }
            else
            {
                btn_TaskEdit.Enabled = false;
                btn_DeleteTask.Enabled = false;
            }
        }

        private void lbx_MyDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentlySelectedTask = lbx_MyDay.SelectedItem as Task;

            if (currentlySelectedTask != null)
            {
                btn_TaskEdit.Enabled = true;
                btn_DeleteTask.Enabled = true;
            }
            else
            {
                btn_TaskEdit.Enabled = false;
                btn_DeleteTask.Enabled = false;
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
                myDay.TodaysTasks.Remove(lbx_TaskList.SelectedItem as Task);
                RefreshTaskList();
            }
            else if (lbx_MyDay.SelectedItem != null)
            {
                taskManager.Tasks.Remove(lbx_MyDay.SelectedItem as Task);
                myDay.TodaysTasks.Remove(lbx_MyDay.SelectedItem as Task);
                RefreshTaskList();
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

            lbx_MyDay.Items.Clear();
            foreach (Task task in myDay.TodaysTasks)
            {
                lbx_MyDay.Items.Add(task);
            }
        }
    }
}