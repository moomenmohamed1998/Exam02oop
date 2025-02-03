using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02_oop_c_
{
    internal class Answer
    {

        public int AnswerId { get; set; }
        public string AnswerText { get; set; }


        public Answer(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }
    }
}
