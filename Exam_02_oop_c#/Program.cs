namespace Exam_02_oop_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region/Start Exam

            Console.WriteLine("Do you want to start the exam now? =====> ( Y , N )");

            if (char.Parse(Console.ReadLine()) == 'y')
            {
                Console.Clear();

                Subject Subject = new Subject(1, "C");
                Subject.CreateExam();
            }
            #endregion



        }
    }
}
