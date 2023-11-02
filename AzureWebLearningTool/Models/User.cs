namespace AzureWebLearningTool.Models
{
    public class User
    {
        public string email { get; set; }
        public string phoneNumber { get; set; }

        public string ipAddress { get; set; }

        int code;

        private void generateCode()
        {
            Random rnd = new Random();
            code = rnd.Next(100000,900000);
        }

        public bool compareCode(int _code)
        {
            return code == _code;
        }
    }
}
