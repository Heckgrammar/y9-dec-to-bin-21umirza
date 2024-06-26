using System;
using System.Collections.Generic;
using System.ComponentModel;
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




            ///TASK 1: CONVERT AN INTEGER TO A STRING

            Console.WriteLine("Enter a number");
            int h = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < h; i++) {
                h = h -1;
                Console.WriteLine(h);
                
            }




            ///TASK 2: INSERT A STRING AT THE START OF ANOTHER STRING

            Console.WriteLine("enter something");
            string first = Console.ReadLine();
            Console.WriteLine("enter something");
            string second = Console.ReadLine();
            string final = first + second;
            Console.WriteLine( final);


            //STARTER: Practice using breakpoints and the watch window (F8 to single-step, F11 to start in single step mode)
           /* int myInt = 0; *///just for testing single stepping
            string myString = "12"; //watch me being cast from string to int
            int myStringAsInt = Convert.ToInt32(myString); //watch me cast from string to int

            //MAIN:  NUMBER CONVERSION PROGRAM

            //CODE GOES HERE
            Console.WriteLine("Enter denary number");
            int Usernum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numberConversion(Usernum, 2)); 
            
        }

        //static void means the function will not return a value so it does not  need a data type 
        //...this function DOES return a value so the method must have a data type
        static string numberConversion(int number, int numberbase)
        {
            int y = 0;
            int i = 0;
            int bitNum = 0;
            string[] Binary = { };
            string result = "";

            while ( i == 0)
            {
                int x = number % numberbase;
                string Remainder = Convert.ToString(x);
                
                Binary[y]= Remainder;
                y = y++;
                 number = number / numberbase;
                bitNum = bitNum++;
                if (0 == number) 
                {
                    i = i++;
                }
            };
            
            for (int h = 0; h == bitNum ; h++)
            {
                
                    result = result + Binary[h] ; 
            }

            return result; //REMOVE THE RED LINE!
        }
    }
}
