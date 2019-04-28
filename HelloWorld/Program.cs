using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte number = 2;
            //int count = 10;
            //float totalPrice = 20.95f;
            //char character = 'A';
            //string firstName = "Clark";
            //bool isWorking = false;

            // var can also be used and c# compiler will detect the data type

            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Clark";
            bool isWorking = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
        }
    }
}
