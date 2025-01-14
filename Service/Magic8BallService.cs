using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOne.Service
{
    public class Magic8BallService
    {
        public string resposne;
        public Magic8BallService()
        {
            resposne = "Error: No question asked";
        }
        public string GetResponse(string question)
        {
            string[] responses = new string[]
            {
                "It is certain",
                "It is decidedly so",
                "Without a doubt",
                "Yes - definitely",
                "You may rely on it",
                "As I see it, yes",
                "Most likely",
                "Outlook good",
                "Yes",
                "Signs point to yes",
                "Reply hazy, try again",
                "Ask again later",
                "Better not tell you now",
                "Cannot predict now",
                "Concentrate and ask again",
                "Don't count on it",
                "My reply is no",
                "My sources say no",
                "Outlook not so good",
                "Very doubtful"
            };
            if (question == null)
            {
                return resposne;
            }
            Random random = new Random();
            int index = random.Next(0, responses.Length);
            resposne = responses[index];
            return resposne;
        }
    }
}