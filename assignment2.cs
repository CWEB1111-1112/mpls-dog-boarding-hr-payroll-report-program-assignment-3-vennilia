using System;
using System.Collections.Generic;

/**
Name: 
Date of completion:

Please be sure to comment your code - provide a comment for each structure use in 
program.
 */
namespace assignment_three
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarations
            string name;
            int  hourlySalary, hoursWorked, department;
            string EXIT = "EXIT";

            
            Console.WriteLine("Please enter a name.");
            name = Console.ReadLine();
            while(name != EXIT){
                 


            /***var departmentDict = new Dictionary<int, string>();
            departmentDict.Add(1, "Personnel");
            departmentDict.Add(2, "Marketing");
            departmentDict.Add(3, "Information Technology");
            departmentDict.Add(4, "Computer Services");
            departmentDict.Add(5, "Sales");
            departmentDict.Add(6, "Legal");
            departmentDict.Add(7, "Accouting");

            foreach(KeyValuePair<int, string> kvp in departmentDict)
            Console.WriteLine(" {0} = {1}", kvp.Key, kvp.Value);**/
            

            Console.WriteLine("Please enter a number from 1 - 7 for a department.");
            department = Convert.ToInt32((Console.ReadLine()));
            if(department > 7 && department < 1){
                Console.WriteLine("Invalid. Please enter a number from 1 to 7.");
            }

            

            Console.WriteLine("Please enter the hourly salary");
            hourlySalary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the hours they have worked.");
            hoursWorked = Convert.ToInt32(Console.ReadLine());

            int grossSalary = hourlySalary * hoursWorked;
            
            Console.WriteLine($"For {name} in department {department}, the gross salary is {grossSalary}.");
            

            string [ , ] departmentSalary = {
                { "Personnel", "accumulatedSalary"},
                { "Marketing", "accumulatedSalary"},
                { "Information Technology", "accumulatedSalary"},
                {"Computer Services", "accumulatedSalary"},
                { "Sales", "accumulatedSalary"},
                { "Legal", "accumulatedSalary"},
                { "Accouting", "accumulatedSalary"},
            };

            string salary = departmentSalary [department - 1, grossSalary ];


            //string[] departments = {"Personnel, Marketing, Information Technology, Computer Services, Sales, Legal, Accounting"};
            //int[] accumulatedSalary = {1, 2, 3, 4, 5, 6, 7};

            //int salary = accumulatedSalary[department - 1];
            //Console.WriteLine(accumulatedSalary);




            


            
            //foreach(string hourlySalary in accumulatedSalary){

            //}


            Console.WriteLine(" To start again enter a name or type EXIT.");
            name=Console.ReadLine();

            
            
            
            Console.WriteLine("Thank you for using this program. ");
        }
      
      }
    }
}