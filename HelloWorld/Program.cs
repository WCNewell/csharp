﻿using System;
using System.Text;
using HelloWorld.Math;
using Microsoft.SqlServer.Server;

namespace HelloWorld
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    partial class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int) method);

            // below is an example of "casting":

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());

            //^^ FYI, Console.WriteLine always converts whatever you pass to it into a string anyway

            //var firstName = "William";
            //var lastName = "Newell";

            //var fullName = firstName + " " + lastName;

            //// or the above ^^ could also be written as:

            //var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            //var names = new string[3] {"Jack", "John", "Mary"};
            //var formattedNames = string.Join(", ", names);
            //Console.WriteLine(formattedNames);


            //var firstName = "William";
            //String lastName = "Newell";
            //string middleName = "Clark";

            //^^All of these are different ways of declaring a string
            // Similarly, Int32 i and int i are the same thing as well


            //var numbers = new int[3];
            //numbers[0] = 1;

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            //var flags = new bool[3];
            //flags[0] = true;

            //Console.WriteLine(flags[0]);
            //Console.WriteLine(flags[1]);
            //Console.WriteLine(flags[2]);

            //var names = new string[3] {"Jack", "John", "Mary"};


            //var clark = new Person();
            //clark.FirstName = "Clark";
            //clark.LastName = "Newell";
            //clark.Introduce();

            //Calculator calculator = new Calculator();
            //var result = calculator.Add(1, 2);
            //Console.WriteLine(result);


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
