using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Y9_DEC_TO_BIN_SKELETON
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /////TASK 1: CONVERT AN INTEGER TO A STRING

            //Console.WriteLine("Enter a number");
            //int h = Convert.ToInt32(Console.ReadLine());
            //int b = h;
            //for (int i = 0; i < b; i++)
            //{
            //    h = h - 1;
            //    Console.WriteLine(h);

            //}




            /////TASK 2: INSERT A STRING AT THE START OF ANOTHER STRING

            //Console.WriteLine("enter something");
            //string first = Console.ReadLine();
            //Console.WriteLine("enter something");
            //string second = Console.ReadLine();
            //string final = first + second;
            //Console.WriteLine(final);


            ////STARTER: Practice using breakpoints and the watch window (F8 to single-step, F11 to start in single step mode)
            ///* int myInt = 0; *///just for testing single stepping
            //string myString = "12"; //watch me being cast from string to int
            //int myStringAsInt = Convert.ToInt32(myString); //watch me cast from string to int

            //MAIN:  NUMBER CONVERSION PROGRAM

           

            int Usernum = 0;
            int numberbasee = 0;
            Console.WriteLine("Press 1 to Start the denary to binary conversion if not then press any key to continue"); 
            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                while (Usernum == 0 || Usernum < 0)
                {
                    Console.WriteLine("Enter denary number");
                    Usernum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("pLEASE ENTER THE BASE");
                    numberbasee = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine(numberConversion(Usernum, numberbasee));
            }


            Console.WriteLine("Press 2 to Start the denary to binary conversion if not then press any key to continue");
            if (Convert.ToInt32(Console.ReadLine()) == 2)
            {
                
                    Console.WriteLine("Enter binary number");
                    Usernum = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine(numbertodenaryConversion(Usernum));

            }
            //if (numberbase == 16)
            //{ Console.WriteLine(Hexadecimal(Usernum, numberbase)); }

           

            //        static string Hexadecimal(int number, int numberbase)
            //        {
            //            int y = 0;
            //            int i = 0;


            //            string Binary = "";

            //            string result = "";

            //            while (i == 0)
            //            {
            //                if (y == 0)
            //                {
            //                    Binary = Convert.ToString(number % numberbase);
            //                }

            //                if (y != 0)
            //                {
            //                    Binary = Binary + Convert.ToString(number % numberbase);
            //                }


            //                y = y + 1;

            //                number = number / numberbase;
            //                if (number == 0)
            //                { i++; }

            //            };
            //            int m = Binary.Length;


            //            string substring = Binary.Substring(0, 4);

            //            string Hexadecimal = "";
            //            int substring2 = Convert.ToInt32(substring);
            //            if (substring2 >9) {
            //                if (substring2 == 10) { Hexadecimal = "A"; }
            //                if (substring2 == 11) { Hexadecimal = "B"; }
            //                if (substring2 == 12) { Hexadecimal = "C"; }
            //                if (substring2 ==13) { Hexadecimal = "D"; }
            //                if (substring2 == 14) { Hexadecimal = "E"; }
            //                if (substring2 == 15) { Hexadecimal = "F"; }
            //                if (substring2 == 16) { while () { } }

        }

        //static void means the function will not return a value so it does not  need a data type 
        //...this function DOES return a value so the method must have a data type
        static string numberConversion(int number, int numberbase)
        {
            int y = 0;
            int i = 0;


            string Binary = "";

            string result = "";

            while (i == 0)
            {
                if (y == 0)
                {
                    Binary = Convert.ToString(number % numberbase);
                }

                if (y != 0)
                {
                    Binary = Binary + Convert.ToString(number % numberbase);
                }


                y = y + 1;

                number = number / numberbase;
                if (number == 0)
                { i++; }

            };
            int m = Binary.Length;
            int l = 0;
            while (m != 0)
            {
                if (l == 0)
                {
                    result = Convert.ToString(Binary[m - 1]);

                }
                if (l != 0)
                {
                    result = result + Convert.ToString(Binary[m - 1]);
                }
                m--;
                l++;
            }


            return result;

        }

        static string numbertodenaryConversion(int number)

        {
            int y = 1;
            string binnumber = Convert.ToString(number);
            int u = binnumber.Length - 1;
            int i = 0;
            int x = 0;
            char c =Convert.ToChar( 1);
            while (u != -1)
            {
                char binnumber2 = binnumber[u];
                if (binnumber2 == c)
                {
                    if (i != 0)
                    {
                        x += (2 * y);
                    }
                    if (i == 0)
                    {
                        x = y;
                    }
                }
                u--;
                i++;
                y = 2 * y;
            }
            string result = Convert.ToString(x);
            return result;

        }
    } 
}

