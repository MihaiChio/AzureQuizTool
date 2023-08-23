namespace AzureWebLearningTool.Models
{
    public class Choice
    {
        public int id { get; set; }
        public string question { get; set; }
        public bool isAnswer { get; set; }
        public bool isSelected { get; set; }
        public string text { get; set; }

    }
}
