using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    public class Answer
    {
        private List<ListConfig> answerList;

        public Answer()
        {
            answerList = new List<ListConfig>();

            answerList.Add(new ListConfig("Yes", true));
            answerList.Add(new ListConfig("No!", false));
            answerList.Add(new ListConfig("Sure!", true));
            answerList.Add(new ListConfig("Are you crazy?", false));
            answerList.Add(new ListConfig("Of course not!", false));
            answerList.Add(new ListConfig("Most probably...", true));
            answerList.Add(new ListConfig("Are you insane?!", false));
            answerList.Add(new ListConfig("Of course!", true));
            answerList.Add(new ListConfig("I think so...", true));
            answerList.Add(new ListConfig("Maybe yes...", true));
            answerList.Add(new ListConfig("Maybe no...", false));
            answerList.Add(new ListConfig("I'm not sure...", false));
            answerList.Add(new ListConfig("How should I know?!", false));
            answerList.Add(new ListConfig("Duh! Of course!", true));
            answerList.Add(new ListConfig("Are you mad?! Of course not!", false));
            answerList.Add(new ListConfig("Maybe....", true));
            answerList.Add(new ListConfig("Don't ask me!", false));
        }
        public ListConfig CheatRandGen()
        {
            Random randomNumber = new Random();
            bool isPositiveAnswer = false;
            ListConfig randomAnswer = new ListConfig("",false);

            while (isPositiveAnswer == false)
            {
                int randomPosition = randomNumber.Next(answerList.Count);
                randomAnswer = answerList[randomPosition];

                isPositiveAnswer = randomAnswer.Yn;
            }
            return randomAnswer;
        }
    
        public ListConfig RandGen()
        {
            Random randomNumber = new Random();
            int randomPosition = randomNumber.Next(answerList.Count);

            ListConfig randomAnswer;
            randomAnswer = answerList[randomPosition];

            return randomAnswer;
        }
        
    }
}
