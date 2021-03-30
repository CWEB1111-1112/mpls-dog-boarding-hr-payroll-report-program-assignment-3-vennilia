using System;
using System.Collections.Generic;

/**
Name: Kei Mullins
Date of completion: 3/29

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
            int  hourlySalary, hoursWorked, departmentInput;
            string EXIT = "EXIT";

            //initializing the loop
            Console.WriteLine("Thank you for using the MPLS Dog Boarding HR Payroll Report Program. Please enter a name.");
            name = Console.ReadLine();
            while(name != EXIT){
                 

            //dictionary for the department names
            /**var departmentDict = new Dictionary<int, string>();
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
            departmentInput = Convert.ToInt32((Console.ReadLine()));
            
            
            //Defensive Coding to make sure user imputs the correct range.
            
            if(departmentInput > 7 && departmentInput < 1){
                Console.WriteLine("Invalid. Please enter a number from 1 to 7.");
                
            }

            

            Console.WriteLine("Please enter the hourly salary");
            hourlySalary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the hours they have worked.");
            hoursWorked = Convert.ToInt32(Console.ReadLine());


            //Individual salary
            int grossSalary = hourlySalary * hoursWorked;
            
            Console.WriteLine($"For {name} in department {departmentInput}, the gross salary is {grossSalary}.");
            

            /**string [ , ] departmentSalary = {
                { "Personnel", "accumulatedSalary"},
                { "Marketing", "accumulatedSalary"},
                { "Information Technology", "accumulatedSalary"},
                {"Computer Services", "accumulatedSalary"},
                { "Sales", "accumulatedSalary"},
                { "Legal", "accumulatedSalary"},
                { "Accouting", "accumulatedSalary"},
            };

            string salary = departmentSalary [department - 1, grossSalary ];**/

            //arrays
            string[] departments_array = {"Personnel", "Marketing", "Information Technology", "Computer Services", "Sales", "Legal", "Accounting"};
            double[] accumulatedSalary = {0, 0, 0, 0, 0, 0, 0};

            List<string> departmentList = new List<string>();

            //populating arrays
            for (var i = 0; i < departments_array.Length; i++)
            {
                departmentList.Add(departments_array[i]);
            }




            

            
            





            Console.WriteLine(" To start again enter a name or type EXIT.");
           
                name=Console.ReadLine();

            //name=Console.ReadLine();

            
            
            
            Console.WriteLine("Thank you for using this program. ");
            departmentList.ForEach(a => Console.WriteLine((a + accumulatedSalary[departmentList.IndexOf(a)])));
        }
            
      }
    }
}