namespace Exam_02_oop_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Subject sub1 = new Subject(1, "C#");
            sub1.CreateExam();
            Console.Clear();
        }
    }
}
