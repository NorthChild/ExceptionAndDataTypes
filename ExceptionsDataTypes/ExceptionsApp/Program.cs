using System;
using System.IO;
using System.Collections.Generic;

namespace ExceptionsApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            //var theInt = 5;
            //var anotherInt = Convert.ToInt32(theInt);       // conversion 

            //var myDouble = Convert.ToDouble(theInt);        // safe widening 

            //// narrowing (unsafe) with no data loss
            //var myShort = Convert.ToInt16(theInt);
            //double myPi = 3.14;
            //float floatPi = Convert.ToSingle(myPi);

            //double x = 3.14159265359;
            ////float y = (float)x;

            ////Console.WriteLine(x);
            ////Console.WriteLine(y);

            //int numCows = 260;
            //byte myByteCows = Convert.ToByte(numCows);

            //int myBankBalance = -2;
            //uint myPostBalance = Convert.ToUInt32(myBankBalance);


            ////uint countCows = (uint)numCows;
            ////byte byteCows = (byte)numCows;

            //Console.WriteLine(Convert.ToString(numCows, 2));
            //Console.WriteLine(Convert.ToString(byteCows, 2));

            //int bankBalance = -2;
            //uint posBalance = (uint)bankBalance;

            //Console.WriteLine(Convert.ToString(bankBalance, 2));
            //Console.WriteLine(Convert.ToString(posBalance, 2));


            //var result = 5.50 / 2;
            //var myInt = 5;
            //double nyMun = myInt;


            //sbyte num = SByte.MaxValue;

            //Console.WriteLine("Byte max: " + num);

            //num += 1;
            //Console.WriteLine(num);

            //128 + 64 + 32 + 8 + 4 + 2 + 1

            // data types
            //int anInt = 3;          // explicitly typed

            //var vInt = 3;           // implicitly typed
            //var v2Int = vInt;       // implicitly typed


            //var name = "Cathy";
            //var isClean = true;
            //var letter = 'P';
            //var uLongNum = 52ul;


            //// neater way to make lists 
            //var prices = new List<decimal>();


            // other data types
            // integers
            //short n1 = -65;
            //ushort n2 = 65;
            //int n3 = -100_000;
            //uint n4 = 100_000;
            //uint n5 = 4_000_000_000;
            //var max = Int32.MaxValue;
            //long n6 = -5_000_000_000;
            //long n7 = 5_000_000_000;

            //var m1 = -65;
            //var m2 = 65;
            //var m3 = -100_000;
            //var m4 = 100_000;
            //var m5 = 4_000_000_000;
            //var max2 = Int32.MaxValue;
            //var m6 = -5_000_000_000;
            //var m7 = 5_000_000_000;

            //floats
            //float sum = 0;

            //for (int i = 0; i < 100_000; i++) {
            //    sum += 2 / 5.0f;
            //}

            //Console.WriteLine("2/5 added 100,000 times " + sum);
            //Console.WriteLine("2/5 multiplied 100,000 times " + 2/5.0f * 100_000);



            //    string text;
            //    string fileName = "HelloWorlds.txt";

            //    try
            //    {
            //        Console.WriteLine("Aura's mark is 65: " + Grade(65));
            //        //Console.WriteLine("Norren's mark is 101: " + Grade(101));
            //        Console.WriteLine("Anil's mark is 82: " + Grade(85));
            //        Console.WriteLine("Nick's mark is -23: " + Grade(-23));

            //    }
            //    catch (ArgumentOutOfRangeException e)
            //    {
            //        Console.WriteLine("Invalida data, please try again");
            //        Console.WriteLine(e.Message);
            //    }

            //    try
            //    {
            //        text = File.ReadAllText(fileName);
            //        Console.WriteLine(text);
            //    }
            //    catch (FileNotFoundException e)
            //    {
            //        Console.WriteLine("Sorry I cant't find: " + fileName);
            //    }
            //    catch (ArgumentException e)
            //    {
            //        Console.WriteLine("You gave me an empty file name - " + e.Message);
            //    }
            //    finally
            //    {
            //        Console.WriteLine("We Made it");
            //    }

            //}

           

        }

        public static string Grade(int mark)
        {

            if (mark < 0 || mark > 100)
            {
                throw new ArgumentOutOfRangeException("Mark: " + mark + " Allowed range 1-100");
            }


            return mark >= 65 ? (mark >= 85 ? "Distinct" : "Pass") : "Fail";
        }




    }
}
