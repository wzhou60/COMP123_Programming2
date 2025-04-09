using JackieZ_Group3_Lab89Library;

namespace JackieZ_Group3_Lab89
{
    public partial class Form1 : Form
    {
        public TaskManager taskManager = new TaskManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Tasks_Click(object sender, EventArgs e)
        {
            new TaskManagerForm(taskManager).Show();
        }


    }
}