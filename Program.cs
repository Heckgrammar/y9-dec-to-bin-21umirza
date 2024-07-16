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
            int numberbase = 0;



            Console.WriteLine("Press 1 to Start the denary to binary conversion if not then press any number to continue");
            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                while (Usernum == 0 || Usernum < 0)
                {
                    Console.WriteLine("Enter denary number");
                    Usernum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the base");
                    numberbase = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine(numberConversion(Usernum, numberbase));
            }



            Console.WriteLine("Press 2 to Start the denary to binary conversion if not then press any number to continue");
            if (Convert.ToInt32(Console.ReadLine()) == 2)
            {

                Console.WriteLine("Enter binary number");
                Usernum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(numbertodenaryConversion(Usernum));

            }



            Console.WriteLine("Press 3 to Start the denary to hexadecimal conversion if not then press any number to continue");
            if (Convert.ToInt32(Console.ReadLine()) == 3)

            {

                Console.WriteLine("Enter denary number");
                Usernum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(Dectohex(Usernum));

            }




            Console.WriteLine("Press 4 to Start the binary to hexadecimal conversion if not then press any number to continue");
            if (Convert.ToInt32(Console.ReadLine()) == 4)
            {

                Console.WriteLine("Enter binary number");
                Usernum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(Bintohex(Usernum));

            }
        }


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
            while (u != -1)
            {
                int binnumber2 = Convert.ToInt32(binnumber[u]);
                if (binnumber2 == 49)
                {
                    if (i != 0)
                    {
                        x += (y);
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









        static string Dectohex(int number)
        {
            string result = null;


            int substring = 0;
            if (number <= 9)
            {
                result = Convert.ToString(number / 16);
            }



            while (number >=9) 
            {

                substring = number / 16;
                number = number / 16;

                if (substring > 9)
                {
                    if (substring == 10) { result = result + "A"; }
                    if (substring == 11) { result = result + "B"; }
                    if (substring == 12) { result = result + "C"; }
                    if (substring == 13) { result = result + "D"; }
                    if (substring == 14) { result = result + "E"; }
                    if (substring == 15) { result = result + "F"; }

                }
                if (number <= 9)
                {
                    result = Convert.ToString(result);
                }






            }
            
            
          



            int substring2 = number % 16;
            if (substring2 != 0 && substring2<9 )

              result = result + Convert.ToString(substring2);

            if (substring2 > 9)
            {
                if (substring2 == 10) { result = result+"A"; }
                if (substring2 == 11) { result= result + "B"; }
                if (substring2 == 12) { result = result + "C"; }
                if (substring2 == 13) { result= result+ "D"; }
                if (substring2 == 14) { result = result + "E"; }
                if (substring2 == 15) { result = result + "F"; }
              
            }
            return result;
        }









        static string Bintohex(int number)
        {
            int y = 1;
            string binnumber = Convert.ToString(number);
            int u = binnumber.Length - 1;
            int i = 0;
            int x = 0;
            while (u != -1)
            {
                int binnumber2 = Convert.ToInt32(binnumber[u]);
                if (binnumber2 == 49)
                {
                    if (i != 0)
                    {
                        x += (y);
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

            string result = null;
          
            while (number >= 9)
            {
                number = number / 16;


               
                    result = result + Convert.ToString(number);
                

                
            }

            if (number <= 9)
            {
                result = Convert.ToString(number / 16);
            }
            int substring2 = x % 16;
            if (substring2 != 0 && substring2 < 9)

                result = result + Convert.ToString(substring2);

            if (substring2 > 9)
            {
                if (substring2 == 10) { result = result + "A"; }
                if (substring2 == 11) { result = result + "B"; }
                if (substring2 == 12) { result = result + "C"; }
                if (substring2 == 13) { result = result + "D"; }
                if (substring2 == 14) { result = result + "E"; }
                if (substring2 == 15) { result = result + "F"; }

            }
            return result;
        }








    }

}

