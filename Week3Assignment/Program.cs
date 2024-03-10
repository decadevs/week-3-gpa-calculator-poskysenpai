// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3Assignment;

namespace h
{
 internal class Calc
    {
        public static void Main(string[] args) 
        {
            //table able = new table();
            Console.WriteLine("What is your Name ?");
            string name = Console.ReadLine();

                        decide:
            Console.WriteLine($"Hello! {name} How many Courses do you offer?");
            int num;
            if(!int.TryParse(Console.ReadLine(), out num)|| num <= 0)
            {
                Console.WriteLine("The input is invalid, Please enter a positive integer greater than Zero");
                goto decide;

            }

            GPAcalculator gPAcalculator = new GPAcalculator();


            for (int i = 1; i <=num; i++)
            {
                
                gPAcalculator.UserInput();
                

            }
            Console.Clear();

            

            gPAcalculator.CreateTable();

            gPAcalculator.Result();

        }

        

       
    }
}
