namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (ExamPoint() < 60)
            {
                    Console.WriteLine("Mezun Olmadınız ");
            }
            if (ExamPoint() > 60) //result75>60
            {
                    Console.WriteLine("Mezun Oldunuz");
            }
        }

        static int ExamPoint()
        {
            int[] arr = { 60, 70, 57, 98, 75, 90 };
            int sum = 0;
            int counter = 0;
            int result = 0;
            foreach (int element in arr) 
            {
                sum += element;
                counter++;
            }
            return result=sum/counter; //result=75
        }
    }
}