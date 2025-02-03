using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exam_02_oop_c_
{
    internal class Exam
    {

        public int Time { get; set; }
        public int NumOfQuestions { get; set; }


        public Exam(int time, int numOfQuestions)
        {
            Time = time;
            NumOfQuestions = numOfQuestions;
        }



    }
}
