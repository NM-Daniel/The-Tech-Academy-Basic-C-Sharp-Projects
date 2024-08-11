using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializes an Employee List
            List<Employee> employeeList = new List<Employee>
            {
                new Employee {Id = 1, FirstName = "Frederick", LastName = "Bingham" },
                new Employee {Id = 2, FirstName = "Tony", LastName = "Tiger" },
                new Employee {Id = 3, FirstName = "Joshua", LastName = "Frobisher" },
                new Employee {Id = 4, FirstName = "Fidelus", LastName = "Mosier" },
                new Employee {Id = 5, FirstName = "Lochlan", LastName = "Roderick" },
                new Employee {Id = 6, FirstName = "Phteven", LastName = "Blair" },
                new Employee {Id = 7, FirstName = "George", LastName = "Warshington" },
                new Employee {Id = 8, FirstName = "Joe", LastName = "Namath"},
                new Employee {Id = 9, FirstName = "Walter", LastName = "Winslow" },
                new Employee {Id = 10, FirstName = "Joe", LastName = "Schmoe" }
            };

            //Creates a new list and uses a foreach loop to add employees which have Joe as their FirstName
            List<Employee> tempList = new List<Employee>();
            foreach (Employee employee in employeeList)
            {
                if (employee.FirstName == "Joe")
                {
                    tempList.Add(employee);
                }
            }
            //Prints the list of Joe's that we created
            foreach (Employee joe in tempList)
            {
                Console.WriteLine("{0} {1} Id# {2}", joe.FirstName, joe.LastName, joe.Id );
            }
            Console.ReadLine();


            //Makes a new list that accomplishes the same as above but using a lambda expression
            List<Employee> lambdaList = employeeList.Where(x => x.FirstName == "Joe").ToList();
            
            //Prints the list of Joe's that we created
            foreach (Employee joe in lambdaList)
            {
                Console.WriteLine("{0} {1} Id# {2}", joe.FirstName, joe.LastName, joe.Id);
            }
            Console.ReadLine();

            //We will erase the lambdaList and rebuild it to add employees with an Id of >5
            lambdaList.Clear();
            lambdaList = employeeList.Where(x => x.Id > 5).ToList();

            //Print the new lambdaList to confirm
            foreach (Employee employee in lambdaList)
            {
                Console.WriteLine("{0} {1} Id# {2}", employee.FirstName, employee.LastName, employee.Id);
            }
            Console.ReadLine();


        }
    }
}
