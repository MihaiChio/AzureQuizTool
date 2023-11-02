using AzureWebLearningTool.Models;

namespace AzureWebLearningTool.Services
{
    public class ExamService : IExamService
    {
        public Exam GetExam()
        {
            Exam exam = new Exam()
            {
                id = 1,
                Name = "Azure Training Tool"
            };

            exam.AddQuestions(GetQuestions());

            return exam;
        }
        List<Question> GetQuestions()
        {
            List<Question> questionList = new List<Question>()
            {
                new Question() {Text = "What is the most common cloud type?", Id = 1},
                new Question() {Text = "Which cloud service model is rapidly gaining popularity among developers?",Id = 2},
                new Question() {Text = "What is Vertical Scaling?",Id = 3},
                new Question() {Text = "What is Horizontal Scaling?",Id = 4},
                new Question() {Text = "What aspects have to be managed in IaaS?",Id = 5},
                new Question() {Text = "Which of the following are true about IaaS?",Id = 6},
                new Question() {Text = "What do you manage when choosing the PaaS cloud service model?",Id = 7},
                new Question() {Text = "Which of the following is true about SaaS?",Id = 8},
                new Question() {Text = "Identity management can be achieved without a single physical server for you to manage",Id = 9},
                new Question() {Text = "What is a Resource Group?",Id = 10},
                new Question() {Text = "How many Resource Groups can a resource be a part of?",Id = 11},
                new Question() {Text = "Why wouldn't you be able to deploy a resource?",Id = 12},
                new Question() {Text = "What properties are present in resources managed by ARM?",Id = 13},
                new Question() {Text = "What is Microsoft.Compute an example of?",Id = 14},
                new Question() {Text = "What is Microsoft.Compute/virtualMachines an example of?",Id = 15},
                new Question() {Text = "What is the Resource Provider for virtual machines?",Id = 16},
                new Question() {Text = "Azure Virtual Machines are an example of which cloud service model?",Id = 17},
            };

            questionList[0].AddChoice(new List<Choice>
            { new Choice() {text = "Public Cloud", isAnswer = true, id = 1 },
              new Choice() {text = "Private Cloud", isAnswer = false, id = 2},
              new Choice() {text = "Hybrid Cloud", isAnswer = false, id = 3 },
            });

            questionList[1].AddChoice(new List<Choice>
            { new Choice() {text = "IaaS", isAnswer = false, id = 4 },
              new Choice() {text = "PaaS", isAnswer = true, id = 5},
              new Choice() {text = "SaaS", isAnswer = false, id = 6 },
            });

            questionList[2].AddChoice(new List<Choice>
            { new Choice() {text = "Upgrade resources(CPU,RAM)", isAnswer = true, id = 6 },
              new Choice() {text = "Increase the number of machines that are running your app", isAnswer = false, id = 7},
              new Choice() {text = "Increase storage", isAnswer = false, id = 8 },
            });

            questionList[3].AddChoice(new List<Choice>
            { new Choice() {text = "Increase number of image instances", isAnswer = false, id = 9 },
              new Choice() {text = "Increase the number of machines that are running your app", isAnswer = true, id = 10},
              new Choice() {text = "Increase storage", isAnswer = false, id = 11 },
            });

            questionList[4].AddChoice(new List<Choice>
            {
                new Choice() {text = "Applications,Storage,Networking", isAnswer = false, id = 12},
                new Choice() {text = "Data and Access", isAnswer = false, id = 13},
                new Choice() {text = "Data And Access, Applications, Runtime, OS, VM", isAnswer = true,id = 14},
                new Choice() {text = "Data and Access,Applications, Runtime, OS, VM, Networking", isAnswer = false ,id = 15},
            });

            questionList[5].AddChoice(new List<Choice>
            {
                new Choice() {text = "Storage has to be managed by you", isAnswer = false, id = 1},
                new Choice() {text = "You get the least flexibility with this model", isAnswer = false, id = 2},
                new Choice() {text = "With this model you just manage who can use the software and which features", isAnswer = false,id = 3},
                new Choice() {text = "You get the most flexibility and control with this model", isAnswer = true ,id = 4},
            });

            questionList[6].AddChoice(new List<Choice>
            {
                new Choice() {text = "Data and access", isAnswer = false, id = 1},
                new Choice() {text = "Data and access, Application", isAnswer = true, id = 2},
                new Choice() {text = "Data and access, Application, Virtual Machine", isAnswer = false,id = 3},
            });

            questionList[7].AddChoice(new List<Choice>
            {
                new Choice() {text = "You are paying based on how much the software is used", isAnswer = false, id = 1},
                new Choice() {text = "You are paying the same amount regardless of how much the software is used", isAnswer = true, id = 2},
                new Choice() {text = "You have control over software features", isAnswer = false,id = 3},
            });

            questionList[8].AddChoice(new List<Choice>
            {
                new Choice() {text = "False", isAnswer = false, id = 1},
                new Choice() {text = "True", isAnswer = true, id = 2},
            });

            questionList[9].AddChoice(new List<Choice>
            {
                new Choice() {text = "A group of multiple resources", isAnswer = false, id = 1},
                new Choice() {text = "A mangament unit for your logically related resources", isAnswer = true, id = 2},
                new Choice() {text = "A number that shows your logically related resources", isAnswer = false, id = 3},
            });

            questionList[10].AddChoice(new List<Choice>
            {
                new Choice() {text = "1", isAnswer = true, id = 1},
                new Choice() {text = "0", isAnswer = false, id = 2},
                new Choice() {text = "2", isAnswer = false, id = 3},
                new Choice() {text = "As many as the configuration allows", isAnswer = false, id = 4},
            });

            questionList[11].AddChoice(new List<Choice>
            {
                new Choice() {text = "Resource Provider has not been registered", isAnswer = true, id = 1},
                new Choice() {text = "If the number of resources is too high", isAnswer = false, id = 2},
                new Choice() {text = "The resource has not beeng registered", isAnswer = false, id = 3}
            });

            questionList[12].AddChoice(new List<Choice>
            {
                new Choice() {text = "Name, ResourceGroupName, ResourceType, Location, ResourceId", isAnswer = true, id = 1},
                new Choice() {text = "Name, ResourceGroupName, ResourceType, Location, ResourceId, Size", isAnswer = false, id = 2},
                new Choice() {text = "Name, ResourceGroupName, ResourceType, Location, ResourceId, Subscription", isAnswer = false, id = 3},
                new Choice() {text = "Name, ResourceGroupName, ResourceType, Location, ResourceId, Size, Subscription", isAnswer = false, id = 4},
            });

            questionList[13].AddChoice(new List<Choice>()
            {
                new Choice() {text = "Resource Type", isAnswer = false, id = 1},
                new Choice() {text = "Resource Provider", isAnswer = true, id = 2},
                new Choice() {text = "Resource Storage", isAnswer = false, id = 3},
            });

            questionList[14].AddChoice(new List<Choice>()
            {
                new Choice() {text = "Resource Type", isAnswer = true, id = 1},
                new Choice() {text = "Resource Provider", isAnswer = false, id = 2},
                new Choice() {text = "Resource Storage", isAnswer = false, id = 3},
            });

            questionList[15].AddChoice(new List<Choice>()
            {
                new Choice() {text = "Microsoft.Compute", isAnswer = true, id = 1},
                new Choice() {text = "Compute.VirtualMachine", isAnswer = false, id = 2},
                new Choice() {text = "Microsoft.VirtualMachine", isAnswer = false, id = 3},
            });

            questionList[16].AddChoice(new List<Choice>()
            {
                new Choice() {text = "PaaS", isAnswer = false, id = 1},
                new Choice() {text = "SaaS", isAnswer = false, id = 2},
                new Choice() {text = "IaaS", isAnswer = true, id = 3},
            });
            return questionList;
        }
    }
}
