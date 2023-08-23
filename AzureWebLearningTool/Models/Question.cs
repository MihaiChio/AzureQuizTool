
namespace AzureWebLearningTool.Models
{
    public class Question
    {
        public List<Choice> Choices { get; set; }

        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public int Points { get; set; }

        public string Text { get; set; }

        public void AddChoice(List<Choice> choices)
        {
            Choices = new List<Choice>();
            foreach (var choice in choices)
            {
                Choices.Add(choice);
            }
        }
    }
}
