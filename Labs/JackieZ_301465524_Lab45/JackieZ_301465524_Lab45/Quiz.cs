//Jackie Zhou 301465524 Lab4/5

namespace JackieZ_301465524_Lab45
{
    internal class Quiz : Evaluation
    {
        public uint NumberOfQuestions
        { get; set; }

        public Quiz(Course course, byte weight, uint numberOfQuestions = 1) : base(course, EvaluationType.Quiz, weight)
        {
            NumberOfQuestions = numberOfQuestions;
        }

        public override string ToString()
        {
            return base.ToString() + $", {NumberOfQuestions} Questions ";
        }
    }
}