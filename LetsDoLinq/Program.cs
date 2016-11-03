using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsDoLinq.Extensions;

namespace LetsDoLinq
{
    class Program
    {
        static void Main(string[] args)
        {

      

            var workingPlaces = new List<WorkPlace>
            {
                new WorkPlace ("ICA", 1),
                new WorkPlace ("Coop", 2),
                new WorkPlace ("CityGross", 3)
            };

            var employees = new List<Person>
            {
                new Person("Göran", 41,1),
                new Person("Kalle", 18,2),
                new Person("Bosse", 19,2),
                new Person("Håkan", 36,1),
                new Person("Patrik", 36,3),
                new Person("Johan", 33,1),
                new Person("Anders", 38,1),
                new Person("Göran", 33,2),
                new Person("Göran", 34,3),
                new Person("Alfred", 36,3),


            };

            Console.WriteLine(hello world);
            //A alla över 30


            var employeesOver30 = employees.Where(p => p.Age > 30 );

            Console.WriteLine("Det här är alla över 30år:");
            employeesOver30.Print();
            Console.WriteLine();

            //B alla under 30

            var employeesUnder30 = employees.Where(p => p.Age < 30);

            Console.WriteLine("Det här är alla under 30år:");
            employeesUnder30.Print();
            Console.WriteLine();

            //C

            var employeeAverageYears = employees.Average(p => p.Age);

            Console.WriteLine("Den genomsnittliga åldern bland alla anställda är");
            Console.WriteLine(employeeAverageYears);
            Console.WriteLine();

            //D
            var aCertainEmployee = employees.FirstOrDefault(p => p.Name == "Göran");

            Console.WriteLine("Här är den första Göran");
            aCertainEmployee.Print();
            Console.WriteLine();

            //E
            var nameOfEmployeesAndTheirJobs = workingPlaces.Join(employees, w => w.WorkPlaceID, p => p.WorkPlaceID,
                (w, pers) => new
                {
                    CompanyName = w.CompanyName,
                    EmployeeName=pers.Name
                } );

            Console.WriteLine("Här är kombinationerna");
            nameOfEmployeesAndTheirJobs.Print();
            Console.WriteLine();


            //F

            var workPlacesAndTheNumberOfEmployees = workingPlaces.GroupJoin(employees, w => w.WorkPlaceID, p => p.WorkPlaceID, (w, pers) =>
               new
               {
                   CompanyName = w.CompanyName,
                   NumberOfEmployees = pers.Count()
               } );

            Console.WriteLine("Företag med antalet anställda");
            workPlacesAndTheNumberOfEmployees.Print();
            Console.WriteLine();


            //

            var workPlacesAndTheWorkers = workingPlaces.GroupJoin(employees, w => w.WorkPlaceID, p => p.WorkPlaceID, (w, pers) => new
            {
                CompanyName = w.CompanyName,
                Employees = pers
            });

            Console.WriteLine("Gruppering");
           

            foreach (var item in workPlacesAndTheWorkers)
            {
                Console.WriteLine(item.CompanyName);
                foreach (var employee in item.Employees)
                {
                    Console.WriteLine(employee.Age);
                }
            }

        }
    }
}
