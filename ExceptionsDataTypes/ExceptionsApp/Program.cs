using System;
using System.IO;

namespace ExceptionsApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text;
            string fileName = "HelloWorlds.txt";

            try
            {
                Console.WriteLine("Aura's mark is 65: " + Grade(65));
                //Console.WriteLine("Norren's mark is 101: " + Grade(101));
                Console.WriteLine("Anil's mark is 82: " + Grade(85));
                Console.WriteLine("Nick's mark is -23: " + Grade(-23));
                
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Invalida data, please try again");
                Console.WriteLine(e.Message);
            }


            



            try
            {
                text = File.ReadAllText(fileName);
                Console.WriteLine(text);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Sorry I cant't find: " + fileName);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("You gave me an empty file name - " + e.Message);
            }
            finally
            {
                Console.WriteLine("We Made it");
            }

        }

        public static string Grade(int mark)
        {

            if (mark < 0)
            {

                throw new ArgumentOutOfRangeException("Mark: " + mark + " Allowed range 1-100");
            }
            else if (mark > 100)
            {
                throw new ArgumentOutOfRangeException("Mark: " + mark + " Allowed range 1-100");
            }

            return mark >= 65 ? (mark >= 85 ? "Distinct" : "Pass") : "Fail";
        }

    }
}
