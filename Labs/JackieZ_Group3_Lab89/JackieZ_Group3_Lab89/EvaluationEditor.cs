using JackieZ_Group3_Lab89Library;

namespace JackieZ_Group3_Lab89
{
    public partial class EvaluationEditor : Form
    {
        private Evaluation evalToEdit;

        public EvaluationEditor(Evaluation eval)
        {
            evalToEdit = eval;
            InitializeComponent();
        }

        private void EvaluationEditor_Load(object sender, EventArgs e)
        {
            try
            {
                cbx_EvalType.SelectedIndex = (int)evalToEdit.Type;
                txt_DueDate.Text = Convert.ToString(evalToEdit.DueDate);
                txt_EvalGrade.Text = evalToEdit.Grade.ToString();
                txt_EvalName.Text = evalToEdit.Name;
                txt_Weight.Text = evalToEdit.Weight.ToString();

                cbx_GroupAssign.Enabled = evalToEdit is Assignment;
                cbx_GroupAssign.Checked = evalToEdit is Assignment a && a.IsGroupAssignment;

                txt_QuizQuestions.Enabled = evalToEdit is Quiz;
                if (evalToEdit is Quiz q)
                {
                    txt_QuizQuestions.Text = q.NumberOfQuestions.ToString();
                }
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
                evalToEdit.Name = txt_EvalName.Text;
                evalToEdit.Weight = Convert.ToByte(txt_Weight.Text);
                evalToEdit.Grade = Convert.ToByte(txt_EvalGrade.Text);
                evalToEdit.DueDate = Convert.ToDateTime(txt_DueDate.Text);

                if (evalToEdit is Assignment a)
                {
                    a.IsGroupAssignment = cbx_GroupAssign.Checked;
                }

                if (evalToEdit is Quiz q)
                {
                    q.NumberOfQuestions = Convert.ToUInt32(txt_QuizQuestions.Text);
                }

                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}