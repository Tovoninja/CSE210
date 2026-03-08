using System;


/* class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Sandbox World!");
//     }
// }


// class loopThing
// {
//     static void Main(string[] args)

//     {
//         int a = 1;
//         for(int i = 0; i <= 20; i++)
//         {
//             Console.WriteLine(++a);

//         }
//     }
// }

// bool done;
// do

// while (!done)
// {
//     Console.Write("Please input your age: ");
//     int age = int.Parse(Console.ReadLine());
//     if(age >= 0 && age <= 125)
//     {
//         done = true;
//         Console.WriteLine("Thank you.");
//     }
//     else
//     {
//         Console.WriteLine("Please inpute a valid age");
//     }
// }


// List<int> myData = new List<int>();
// myData.Add(1);
// myData.Add(1);
// myData.Add(2);
// myData.Add(3);
// myData.Add(5);
// myData.Add(8);
// myData.Add(13);

// foreach(int i in myData)
// {
//     Console.WriteLine(i);
// }

// List<string> myFriends = myFriends = ["Bob","Betty","Jeannie"];
// myFriends.Add("Yummy");

// foreach(string friend in myFriends)
// {
//     Console.WriteLine(friend);
// }

// class BobsYourUncle
// {
//     public static void Greeting()
//     {
//         Console.WriteLine("Hello Bob");
//     }
//     public static int AddNumbers(int n1, int n2)
//     {
//         return n1 + n2;
//     }
//     static void Main(string[] args)
//     {
//         Greeting();
//     }
// }

// class conditionTime
// {
//     static void Main(String[] argu)
//     {

//     int i = 0;
//     while (i < 20)
//     {
//         Console.WriteLine("Yes");
//         i++;
//     }
//     }
// }

// class whatToDo
// {
//     public static void Main(string[] argu)
//     {
//         int i = 0;
//         do
//         {
//             Console.WriteLine($"Yes{i}");
//             i++;
//         } while (i < 10);
//     }

// }




// public static void passByValue(int a)
// {
//     a++;
//     Console.WriteLine(a);
// }

// public static void passByRef(ref int x)
// {
//     x++;
//     Console.WriteLine(x);

// }

// static BrotliDecoder Main(string[] args)
// {
//     int x = 20;
//     Console.WriteLine($"In the main 1: {x}");
    
//     passByValue(x);
//     Console.WriteLine($"In the main 2: {x}");

    
// }

// static void Main(string[] args)
// {
//     Console.WriteLine("Circle");

//     Circle myCircle = new Circle();

//     myCircle.SetRadoius(10);
//     Console.WriteLine(myCircle.GetRaidius());
//     myCircle._radius = 900;

//     Circle myCircle2 = new Circle();

//     myCircle2.SetRadius(99999999);
//     Console.WriteLine(myCircle2.GetRadius());

//     Console.WriteLine(myCircle2.GetArea());
//     Console.WriteLine(myCircle2.GetDiameter());
// }*/

class OurList
{
    static void Main(string[] argu)
    {
        Console.WriteLine("Name a number: ");
        int numberForList = int.Parse(Console.ReadLine());
        Console.WriteLine(numberForList);        
    }
}