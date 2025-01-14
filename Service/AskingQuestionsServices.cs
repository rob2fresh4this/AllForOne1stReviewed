
namespace AllForOne.Service
{
    public class AskingQuestionsServices
    {
        public string reply;
        public AskingQuestionsServices()
        {
            reply = "Nothing here yet!";
        }

        public void SetReply(string name, string time)
        {
            reply = "The person is " + name + " and they woke up at " + time;
        }
    }
}