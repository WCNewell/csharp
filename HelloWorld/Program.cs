using System;
using Microsoft.SqlServer.Server;

namespace HelloWorld
{
    class Program
    {

        public class Person
        {
            public string FirstName;
            public string LastName;

            public void Introduce()
            {
                Console.WriteLine("My name is " + FirstName + " " + LastName);
            }
        }

        static void Main(string[] args)
        {
            
            var clark = new Person();
            clark.FirstName = "Clark";
            clark.LastName = "Newell";
            clark.Introduce();


            //var a = 10;
            //var b = 3;

            //Console.WriteLine((float)a / (float)b);

            //try
            //{
            //    string str = "true";
            //    bool b = Convert.ToBoolean(str);
            //    Console.WriteLine(b);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("The number could not be converted to a byte");
            //}


            //const float Pi = 3.14f;

            //Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            //Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            // var can also be used and c# compiler will detect the data type


            //byte number = 2;
            //int count = 10;
            //float totalPrice = 20.95f;
            //char character = 'A';
            //string firstName = "Clark";
            //bool isWorking = false;



        }
    }
}
