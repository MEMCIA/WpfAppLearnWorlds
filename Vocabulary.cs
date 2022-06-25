using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApp2
{
    public class Vocabulary
    {
        Dictionary<string, string> words = new Dictionary<string, string> { { "uroczy", "carino" }, { "kot", "gatto" }, { "dobranoc", "buonanotte" } };
        int numberOfWord = -1;
        int startNumberOfSuccesiveRounds = 0;

        void IncreaseNumber()
        {
            if(numberOfWord++>=words.Count)
            {
                numberOfWord = startNumberOfSuccesiveRounds;
            }
        }

        public string FindRightAnswer()
        {
            return words.ElementAtOrDefault(numberOfWord).Value;
        }

        public KeyValuePair<string,string> FindNextPairOfWords()
        {
            IncreaseNumber();
            return words.ElementAtOrDefault(numberOfWord);
        }

        public bool CheckIfAnswerIsCorrect(string answer)
        {
            string answerToLower = answer.ToLower();
            if (FindRightAnswer() == answerToLower) return true;
            return false;
        }
    }
}
