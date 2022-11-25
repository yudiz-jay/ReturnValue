using System;
 
namespace Demo_3
{
    class Program
    {
        //Using Ref.Keyword
        private static void function_usingRef(int num1,int num2, ref int addition, ref int multiplication)
        {

            addition = num1 + num2;
            multiplication = num1 * num2;
            
        }

        //Using Out Parameter
        private static void function_usingOut(int num1, int num2, out int addition,out int multiplication)
        {
            addition = num1 + num2;
            multiplication = num1 * num2;
        }

        //Using Tuple
        private static Tuple<int,int> function_usingTuple(int num1, int num2)
        {
            return Tuple.Create(num1 + num2, num1 * num2);
        }

        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter 1st and 2nd Numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            int addition = 0, multiplication = 0;

            //Using Ref. Keyword
            function_usingRef(num1, num2, ref addition, ref multiplication);
            Console.WriteLine(addition);
            Console.WriteLine(multiplication);


            //Using Out Parameter
            function_usingOut(num1, num2, out addition, out multiplication);
            Console.WriteLine(addition);
            Console.WriteLine(multiplication);

            //Using Tuple
            Tuple<int, int> answer = function_usingTuple(num1, num2);
            Console.WriteLine(answer);

        }

       
    }
}
