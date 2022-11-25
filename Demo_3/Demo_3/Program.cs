using System;
 
namespace Demo_3
{
    class Program
    {
        //Using Ref.Keyword
        private static void Method1(int num1,int num2, ref int addition, ref int multiplication)
        {

            addition = num1 + num2;
            multiplication = num1 * num2;
            
        }

        //Using Out Parameter
        private static void Method2(int num1, int num2, out int addition,out int multiplication)
        {
            addition = num1 + num2;
            multiplication = num1 * num2;
        }

        //Using Tuple
        private static Tuple<int,int>Method3(int num1, int num2)
        {
            return Tuple.Create(num1 + num2, num1 * num2);
        }

        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter 1st and 2nd Numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            //Using Ref. Keyword
            int addition = 0, multiplication = 0;
            Method1(num1, num2, ref addition, ref multiplication);
            Console.WriteLine(addition);
            Console.WriteLine(multiplication);


            //Using Out Parameter
            int multiplication1 = 0, addition1 = 0;
            Method2(num1, num2, out addition1,out multiplication1);
            Console.WriteLine(addition1);
            Console.WriteLine(multiplication1);

            //Using Tuple
            Tuple<int, int> answer = Method3(num1, num2);
            Console.WriteLine(answer);

        }

       
    }
}
