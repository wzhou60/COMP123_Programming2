 

namespace JackieZ_Group3_Lab89Library 
{
    public class Quiz : Evaluation
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