using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02_oop_c_
{
    internal class True_False : Question
    {
        public True_False(string header, string body, int mark, Answer[] answers, Answer[] rightAnswer) : base(header, body, mark, answers, rightAnswer)
        {
        }

    }
}
