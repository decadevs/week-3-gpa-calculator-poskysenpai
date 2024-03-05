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

            Console.WriteLine($"Hello! {name} How many Courses do you offer?");
            int num = int.Parse(Console.ReadLine());

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
