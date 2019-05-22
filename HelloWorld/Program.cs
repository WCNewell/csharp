using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;
using HelloWorld.Math;
using Microsoft.SqlServer.Server;

namespace HelloWorld
{
    //public enum ShippingMethod
    //{
    //    RegularAirMail = 1,
    //    RegisteredAirMail = 2,
    //    Express = 3
    //}

    //public class Person
    //{
    //    public int Age;
    //}

    partial class Program
    {
        public static void Main(string[] args)
        {

            var numbers = new List<int> {1, 2, 3, 4, 5, 6};
            var smallests = GetSmallests(numbers, 3);

            foreach (var number in smallests)
                Console.WriteLine(number);

        }

        public static List<int> GetSmallests(List<int> list, int count)
        {
            var smallests = new List<int>();

            while (smallests.Count < count)
            {
                var min = GetSmallest(list);
                smallests.Add(min);
                list.Remove(min);
            }

            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            // Assume the first number is the smallest
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }

            return min;
        }

    }
        //var path = @"C:\Users\Clark Newell\documents\webdev\udemy\csharp\HelloWorld\HelloWorld.sln";

        //var dotIndex = path.IndexOf('.');
        //var extension = path.Substring(dotIndex);

        //Console.WriteLine("Extension: " + Path.GetExtension(path));
        //Console.WriteLine("File Name: " + Path.GetFileName(path));
        //Console.WriteLine("File Name without Extension " + Path.GetFileNameWithoutExtension(path));
        //Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));

        //Directory.CreateDirectory(@"c:\temp\folder1");


        //var files = Directory.GetFiles(@"C:\Users\Clark Newell\documents\webdev\udemy\csharp\HelloWorld", "*.*", SearchOption.AllDirectories);
        //foreach (var file in files)
        //    Console.WriteLine(file);

        //var directories = Directory.GetDirectories(@"C:\Users\Clark Newell\documents\webdev\udemy\csharp\HelloWorld", "*.*", SearchOption.AllDirectories);
        //foreach (var directory in directories)
        //    Console.WriteLine(directory);

        //Directory.Exists("...");

        //var directoryInfo = new DirectoryInfo("...");
        //directoryInfo.GetFiles();
        //directoryInfo.GetDirectories()


        //var path = @"c:\somefile.jpg";
        //File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
        //File.Delete(path);
        //if (File.Exists(path))
        //{
        //    // do something
        //}
        //var content = File.ReadAllText(path);

        //var fileInfo = new FileInfo(path);
        //fileInfo.CopyTo("...");
        //fileInfo.Delete();
        //if (fileInfo.Exists)
        //{
        //    // do something
        //}

        //fileInfo.OpenRead();

        //}


        //static void Main(string[] args)
        //{

        //    Console.WriteLine("What's your name? ");
        //    var name = Console.ReadLine();
        //    var reversed = ReverseName(name);
        //    Console.WriteLine("Reversed name: " + reversed);
        //}

        //public static string ReverseName(string name)
        //{
        //    var myArray = new char[name.Length];
        //    for (var i = name.Length; i > 0; i--)
        //        myArray[name.Length - i] = name[i - 1];

        //    return new string(myArray);
        //}

        //var builder = new StringBuilder("Hello World");
        //builder
        //    .Append('-', 10)
        //    .AppendLine()
        //    .Append("Header")
        //    .AppendLine()
        //    .Append('-', 10)
        //    .Replace('-', '+')
        //    .Remove(0, 10)
        //    .Insert(0, new string('-', 10));

        //Console.WriteLine(builder);

        //Console.WriteLine("First Char: " + builder[0]);


        //var sentence = "This is going to be a really really really really really really really long text.";
        //var summary = StringUtility.SummarizeText(sentence);
        //Console.WriteLine(summary);

        //var fullName = "William Newell ";
        //Console.WriteLine("Trim: '{0}'", fullName.Trim());
        //Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

        //var index = fullName.IndexOf(' ');
        //var firstName = fullName.Substring(0, index);
        //var lastName = fullName.Substring(index + 1);
        //Console.WriteLine("First Name: " + firstName);
        //Console.WriteLine("Last Name: " + lastName);

        //var names = fullName.Split(' ');
        //Console.WriteLine("First Name: " + names[0]);
        //Console.WriteLine("Last Name: " + names[1]);

        //Console.WriteLine(fullName.Replace("William", "Clark"));

        ////if (String.IsNullOrEmpty(" ".Trim()))
        ////    Console.WriteLine("Invalid");

        //if (String.IsNullOrWhiteSpace(" "))
        //    Console.WriteLine("Invalid");

        //var str = "46";
        //var age = Convert.ToByte(str);
        //Console.WriteLine(age);

        //float price = 29.95f;
        //Console.WriteLine(price.ToString("C0"));

        //var timeSpan = new TimeSpan(1, 2, 3);
        //var timeSpan1 = new TimeSpan(1, 0, 0);

        //var timeSpan2 = TimeSpan.FromHours(1);

        //var start = DateTime.Now;
        //var end = DateTime.Now.AddMinutes(2);
        //var duration = end - start;
        //Console.WriteLine("Duration: " + duration);

        //// Properties
        //Console.WriteLine("Minutes: " + timeSpan.Minutes);
        //Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

        //// Add
        //Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
        //Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

        //// To String
        //Console.WriteLine("ToString: " + timeSpan.ToString());

        //// Parse
        //Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));


        //var dateTime = new DateTime(2015, 1, 1);
        //var now = DateTime.Now;
        //var today = DateTime.Today;

        //Console.WriteLine("Hour: " + now.Hour);
        //Console.WriteLine("Minute: " + now.Minute);

        //var tomorrow = now.AddDays(1);
        //var yesterday = now.AddDays(-1);

        //Console.WriteLine(now.ToLongDateString());
        //Console.WriteLine(now.ToShortDateString());
        //Console.WriteLine(now.ToLongTimeString());
        //Console.WriteLine(now.ToShortTimeString());
        //Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

        //var numbers = new List<int>() { 1, 2, 3, 4 };
        //numbers.Add(1);
        //numbers.AddRange(new int[3] { 5, 6, 7});

        //foreach (var number in numbers)
        //{
        //    Console.WriteLine(number);
        //}

        //Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
        //Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));

        //for (var i = 0; i < numbers.Count; i++)
        //{
        //    if (numbers[i] == 1)
        //        numbers.Remove(numbers[i]);
        //}
        //foreach (var number in numbers)
        //    Console.WriteLine(number);

        //numbers.Clear();

        //Console.WriteLine("Count: " + numbers.Count);

        //var numbers = new[] { 5, 6, 3, 4, 46, 100 };

        //// Length
        //Console.WriteLine("Length: " + numbers.Length);

        //// IndexOf()
        //var index = Array.IndexOf(numbers, 9);
        //Console.WriteLine("Index of 9: " + index);

        //// Clear()
        //Array.Clear(numbers, 0, 2);

        //Console.WriteLine("Effect of Clear()");
        //foreach (var number in numbers)
        //{
        //    Console.WriteLine(number);
        //}

        //// Copy()
        //var another = new int[3];
        //Array.Copy(numbers, another, 3);

        //Console.WriteLine("Effect of Copy()");
        //foreach (var number in another)
        //{
        //    Console.WriteLine(number);
        //}

        //// Sort()
        //Array.Sort(numbers);

        //Console.WriteLine("Effect of Sort()");
        //foreach (var number in numbers)
        //{
        //    Console.WriteLine(number);
        //}

        //// Reverse()
        //Array.Reverse(numbers);

        //Console.WriteLine("Effect of Reverse()");
        //foreach (var number in numbers)
        //{
        //    Console.WriteLine(number);
        //}

        //var random = new Random();

        //const int passwordLength = 13;

        //var buffer = new char[passwordLength];
        //for (var i = 0; i < passwordLength; i++)
        //    buffer[i] = (char)('a' + random.Next(0, 26));

        //var password = new string(buffer);

        //Console.WriteLine(password);

        //while (true)
        //{
        //    Console.Write("Type your name");
        //    var input = Console.ReadLine();

        //    if (!String.IsNullOrWhiteSpace(input))
        //    {
        //        Console.WriteLine("@Echo: " + input);
        //        continue;
        //    }

        //    break;
        //}

        //var i = 0;
        //while (i <= 10)
        //{
        //    if (i % 2 == 0)
        //        Console.WriteLine(i);

        //    i++;
        //}

        //var numbers = new int[] {1, 2, 3, 4};

        //foreach (var number in numbers)
        //{
        //    Console.WriteLine(number);
        //}

        //var name = "Clark Newell";

        //for (var i = 0; i < name.Length; i++)
        //{
        //    Console.WriteLine(name[i]);
        //}

        //foreach (var character in name)
        //{
        //    Console.WriteLine(character);
        //}

        //for (var i = 1; i <= 10; i++)
        //{
        //    if (i % 2 == 0)
        //    {
        //        Console.WriteLine(i);
        //    }

        //}

        //for (var i = 10; i >= 1; i--)
        //{
        //    if (i % 2 == 0)
        //    {
        //        Console.WriteLine(i);
        //    }

        //}

        //var season = Season.Autumn;

        //switch (season)
        //{
        //    case Season.Autumn:
        //    case Season.Summer:
        //        Console.WriteLine("Some like it sunny");
        //        break;

        //    default:
        //        Console.WriteLine("The other two seasons are very wet");
        //        break;
        //}

        //bool isGoldCustomer = true;

        ////float price;
        ////if (isGoldCustomer)
        ////{
        ////    price = 19.95f;

        ////}
        ////else
        ////{
        ////    price = 29.99f;
        ////}

        //float price = (isGoldCustomer) ? 19.95f : 29.95f;
        //Console.WriteLine(price);

        //int hour = 19;

        //if (hour > 0 && hour < 12)
        //{
        //    Console.WriteLine("It's morning!");
        //}   
        //else if (hour >= 12 && hour < 18)
        //{
        //    Console.WriteLine("It's afternoon");
        //}
        //else
        //{
        //    Console.WriteLine("It's evening");
        //}

        //var number = 1;
        //Increment(number);
        //Console.WriteLine(number);

        //var person = new Person() {Age = 20};
        //MakeOld(person);
        //Console.WriteLine(person.Age);

        //var a = 10;
        //var b = a;
        //b++;
        //Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

        //var array1 = new int[3] {1, 2, 3};
        //var array2 = array1;
        //array2[0] = 0;
        //Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));


        //var method = ShippingMethod.Express;
        //Console.WriteLine((int) method);

        //// below is an example of "casting":

        //var methodId = 3;
        //Console.WriteLine((ShippingMethod)methodId);

        //Console.WriteLine(method.ToString());

        ////^^ FYI, Console.WriteLine always converts whatever you pass to it into a string anyway

        //var methodName = "Express";

        //// This is how you convert or parse a string into an Enumeration:
        //var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);

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
        //}

        //public static void Increment(int number)
        //{
        //    number += 10;
        //}

        //public static void MakeOld(Person person)
        //{
        //    person.Age += 10;
        //}
    //}
}
