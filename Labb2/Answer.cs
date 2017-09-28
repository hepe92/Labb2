using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    class Answer
    {
        
        public string AList()
        {
            //List<string> awnserList = new List<string>();
            List<string> answerList;
            answerList = new List<string>();

            answerList.Add("Yes");
            answerList.Add("No!");
            answerList.Add("Sure!");
            answerList.Add("Are you crazy?");
            answerList.Add("Of course not!");
            answerList.Add("Most probably...");
            answerList.Add("Are you insane?!");
            answerList.Add("Of course!");
            answerList.Add("I think so...");
            answerList.Add("Maybe yes...");
            answerList.Add("Maybe no...");
            answerList.Add("I'm not sure...");
            answerList.Add("How should I know?!");
            answerList.Add("Duh! Of course!");
            answerList.Add("Are you mad?! Of course not!");
            answerList.Add("Maybe....");
            answerList.Add("Don't ask me!");

            Random randomNumber = new Random();
            int randomPosition = randomNumber.Next(answerList.Count);

            string randomAwnser = answerList[randomPosition];
            return randomAwnser;

        }
        
    }
}
