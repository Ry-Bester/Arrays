using System;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {

        //List<int> intList = new List<int>();

        //intList.Add(4);
        //intList.Add(10);
        //intList.Add(15);
        //intList.Add(120);
        //intList.Add(700);
        //intList.Add(1200);

        //Console.WriteLine("choose a number between 0-6, and get a number");
        //int num = Convert.ToInt32( Console.ReadLine());
        //Console.WriteLine("your number is " num);

        //List<string> intList2 = new List<string>();

        //intList2.Add("joe");
        //intList2.Add("bill");
        //intList2.Add("mary");
        //intList2.Add("sue");
        //intList2.Add("beth");
        //intList2.Add("joel");


        //Console.WriteLine("choose another number betweeeen 0-5, and get a name");
        //Console.ReadLine();



        //    int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;


        //int[] numArray1 = new[] { 5, 2, 10, 22, 5000 };

        int[] numArray = { 5, 2, 10, 200, 500, 600, 2300 };
            Console.WriteLine("choose a number between 0-6, and get a number");
            int num = Convert.ToInt32( Console.ReadLine());
           

          if (num > numArray.Length)
            {
            Console.WriteLine("your number is out of bounds");
            
            }
        else
        {
            Console.WriteLine("your number is " + numArray[num]);
        }
        string[] sArray = { "bob", "joe", "mary", "bill", "nick", "sue" };
        
        Console.WriteLine("choose another number betweeeen 0-5, and get a name");
          int str = Convert.ToInt32(Console.ReadLine());

        if (str > sArray.Length)
        {
            Console.WriteLine("your number is out of bounds");

        }
        else
        {
            Console.WriteLine("your name is " + sArray[str]);
        }

       

        List<string> intList2 = new List<string>();

            intList2.Add("Joe");
            intList2.Add("Bill");
            intList2.Add("Mary");
            intList2.Add("Sue");
            intList2.Add("Beth");
            intList2.Add("Joel");

        Console.WriteLine("Please choose a number from 0-6");

        int lst = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("the Name you choose is " + intList2[lst]);

        Console.ReadLine();
    }
}

