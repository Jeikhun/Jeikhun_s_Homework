using System;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student newStudent=new Student();
            {
               int UmumiBal=newStudent.UmumiBal();
                if (UmumiBal > 90) 
                {
                    Console.WriteLine("HighHonour"); 
                }
                else if (UmumiBal > 80)
                {
                    Console.WriteLine("Honour");
                }
                else Console.WriteLine("Normal");
            }

        }
    }

    public class Student
    {
        public int[] HomeWorkGrades = { 75, 89, 88, 71, 87 }; //25%
        public int[] ProjectGrades = { 88, 77, 94, 64, 67 }; //25%
        public int FinalGrades = 99;//40%
        public bool[] Davamiyyet = { true, false, true, false, true };//10%

        public int UmumiBal()
        {

            int UmumiHomeWorkGrades = FaizHesablanmasi(HomeWorkGrades, 25);
            int UmumiProjectGrades = FaizHesablanmasi(ProjectGrades, 25);
            int UmumiFinalGrade = (FinalGrades * 40) / 100;
            int UmumiDavamiyyet = DavamiyyetHesablanmasi(Davamiyyet, 10);
            return UmumiDavamiyyet + UmumiFinalGrade + UmumiHomeWorkGrades + UmumiProjectGrades;
        }

        public int FaizHesablanmasi(int [ ] arr, int faiz)
        {
            int sum = 0;
            int counter = 0;
            int result;
            for(int i = 0; i < arr.Length; i++)
            {
                counter++;
                sum += arr[i];
            }
            result = (sum * faiz) / 100;
            return result/counter;
        }
        public int DavamiyyetHesablanmasi(bool[]arr,int faiz)
        {
            int count1 = 0;
            int sum = 0;
            int result;
            int result1=0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum++;
                if (arr[i] == true)
                {
                    count1++;
                }
                result = (count1 * 100) / sum;
                result1=(result*10)/ 100;
            }return result1;

        }
    }   


}
