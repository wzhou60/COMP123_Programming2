using JackieZ_Group3_Lab89Library;

namespace JackieZ_Group3_Lab89
{
    public partial class ViewEvaluationsForm : Form
    {
        //Code by JackieZ - 301465524
        private Course currentCourse;

        public ViewEvaluationsForm(Course course)
        {
            currentCourse = course;
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
                if (cbx_EvalType.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select an Evaluation Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    newEval = null;
                }
                else if (cbx_EvalType.SelectedIndex == 0)
                {
                    newEval = new Assignment(currentCourse, Convert.ToByte(txt_Weight.Text),
                        Convert.ToDateTime(txt_DueDate.Text), cbx_GroupAssign.Checked)
                    { Name = txt_EvalName.Text, Grade = Convert.ToByte(txt_EvalGrade.Text) };
                }
                else if (cbx_EvalType.SelectedIndex == 1)
                {
                    newEval = new Evaluation(currentCourse, EvaluationType.Test,
                    Convert.ToByte(txt_Weight.Text))
                    {
                        DueDate = Convert.ToDateTime(txt_DueDate.Text),
                        Name = txt_EvalName.Text,
                        Grade = Convert.ToByte(txt_EvalGrade.Text)
                    };
                }
                else if (cbx_EvalType.SelectedIndex == 2)
                {
                    newEval = new Quiz(currentCourse, Convert.ToByte(txt_Weight.Text),
                        Convert.ToUInt32(txt_QuizQuestions.Text))
                    {
                        DueDate = Convert.ToDateTime(txt_DueDate.Text),
                        Name = txt_EvalName.Text,
                        Grade = Convert.ToByte(txt_EvalGrade.Text)
                    };
                }
                else if (cbx_EvalType.SelectedIndex == 3)
                {
                    newEval = new Evaluation(currentCourse, EvaluationType.Discussion,
                    Convert.ToByte(txt_Weight.Text))
                    {
                        DueDate = Convert.ToDateTime(txt_DueDate.Text),
                        Name = txt_EvalName.Text,
                        Grade = Convert.ToByte(txt_EvalGrade.Text)
                    };
                }
                else
                {
                    newEval = new Evaluation(currentCourse, EvaluationType.Project,
                    Convert.ToByte(txt_Weight.Text))
                    {
                        DueDate = Convert.ToDateTime(txt_DueDate.Text),
                        Name = txt_EvalName.Text,
                        Grade = Convert.ToByte(txt_EvalGrade.Text)
                    };
                }

                if (newEval != null)
                {
                    currentCourse.Evaluations.Add(newEval);
                    txt_DueDate.Text = "";
                    txt_Weight.Text = "";
                    txt_QuizQuestions.Text = "";
                    txt_EvalGrade.Text = "";
                    txt_EvalName.Text = "";
                    cbx_GroupAssign.Checked = false;
                    cbx_EvalType.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshEvaluationsList();
        }

        private void btn_DeleteEval_Click(object sender, EventArgs e)
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

        private void cbx_EvalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_EvalType.SelectedIndex == 0)
            {
                cbx_GroupAssign.Enabled = true;
                txt_QuizQuestions.Enabled = false;
            }
            else if (cbx_EvalType.SelectedIndex == 2)
            {
                txt_QuizQuestions.Enabled = true;
                cbx_GroupAssign.Enabled = false;
            }
            else
            {
                txt_QuizQuestions.Enabled = false;
                cbx_GroupAssign.Enabled = false;
            }
        }

        private void btn_EvalEdit_Click(object sender, EventArgs e)
        {
            EvaluationEditor evaluationEditor = new EvaluationEditor(lbx_EvalList.SelectedItem as Evaluation);
            if (evaluationEditor.ShowDialog() == DialogResult.OK)
            {
                RefreshEvaluationsList();
            }
        }

        private void lbx_EvalList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbx_EvalList.SelectedItem != null)
            {
                btn_EvalEdit.Enabled = true;
            }
            else
            {
                btn_EvalEdit.Enabled = false;
            }
        }
    }
}