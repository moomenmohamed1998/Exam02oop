using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02_oop_c_
{
    internal class Subject 
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
        }

     

        public void CreateExam()
        {
            int Exam;
            int Time;
            int Num;

            Console.WriteLine("Please Enter Exam  1=Practical - 2=Final");

            if (int.TryParse(Console.ReadLine(), out Exam) && (Exam is 1 or 2))
            {
                Console.Clear();

                Console.WriteLine("Please Enter Exam Time the minute");

                if (int.TryParse(Console.ReadLine(), out Time) && (Time > 0))
                {
                    Console.Clear();
                    Console.WriteLine("Please Enter The Num Of Exam");

                    if (int.TryParse(Console.ReadLine(), out Num) && (Num > 0))
                    {
                        Console.Clear();
                    }
                }



            }


        }
    }
}