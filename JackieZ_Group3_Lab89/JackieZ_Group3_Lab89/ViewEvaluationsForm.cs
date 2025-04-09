using JackieZ_Group3_Lab89Library;

namespace JackieZ_Group3_Lab89
{
    public partial class ViewEvaluationsForm : Form
    {
        // private List<Evaluation> evaluationsList = new List<Evaluation>();
        private Course currentCourse;

        public ViewEvaluationsForm(Course course)
        {
            currentCourse = course;
            //            evaluationsList = evaluations;
            InitializeComponent();
            RefreshEvaluationsList();
        }

        private void RefreshEvaluationsList()
        {
            lbx_EvalList.Items.Clear();
            foreach (Evaluation eval in currentCourse.Evaluations)
            {
                lbx_EvalList.Items.Add(eval);
            }
        }

        private void btn_EvalAdd_Click(object sender, EventArgs e)
        {
            Evaluation newEval;
            try
            {
                if (cbx_EvalType.SelectedIndex == 0)
                {
                    newEval = new Assignment(currentCourse, Convert.ToByte(txt_Weight.Text),
                        Convert.ToDateTime(txt_DueDate.Text), cbx_GroupAssign.Checked);
                }
                else if (cbx_EvalType.SelectedIndex == 1)
                {
                    newEval = new Evaluation(currentCourse, EvaluationType.Test,
                    Convert.ToByte(txt_Weight.Text))
                    { DueDate = Convert.ToDateTime(txt_DueDate.Text) };
                }
                else if (cbx_EvalType.SelectedIndex == 2)
                {
                    newEval = new Quiz(currentCourse, Convert.ToByte(txt_Weight.Text),
                        Convert.ToUInt32(txt_QuizQuestions.Text))
                    { DueDate = Convert.ToDateTime(txt_DueDate.Text) };
                }
                else if (cbx_EvalType.SelectedIndex == 3)
                {
                    newEval = new Evaluation(currentCourse, EvaluationType.Discussion,
                    Convert.ToByte(txt_Weight.Text))
                    { DueDate = Convert.ToDateTime(txt_DueDate.Text) };
                }
                else
                {
                    newEval = new Evaluation(currentCourse, EvaluationType.Project,
                    Convert.ToByte(txt_Weight.Text))
                    { DueDate = Convert.ToDateTime(txt_DueDate.Text) };
                }

                currentCourse.Evaluations.Add(newEval);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshEvaluationsList();

            txt_DueDate.Text = "";
            txt_Weight.Text = "";
            txt_QuizQuestions.Text = "";
            cbx_GroupAssign.Checked = false;
            cbx_EvalType.SelectedIndex = 0;
        }

        private void btn_DeleteTask_Click(object sender, EventArgs e)
        {
            if (lbx_EvalList.SelectedItem != null)
            {
                currentCourse.Evaluations.Remove(lbx_EvalList.SelectedItem as Evaluation);
                lbx_EvalList.Items.Remove(lbx_EvalList.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select a task to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}