namespace AzureWebLearningTool.Models
{
    public class Exam
    {
        public int id { get; set; }
        public string Name { get; set; }

        public List<Question> questions { get; set; }

        public int totalPoints { get; set; }

        public void AddQuestions(List<Question> _questions)
        {
            questions = _questions;
        }
    }
}
