using Model;

namespace DelegatesExample
{
    public class LinqExample_2
    {
        public void LinqIntro_1()
        {
            List<Employee>   employees   = Data.GetEmployees();
            List<Department> departments = Data.GetDepartments();
            //Method syntax
            /* var result = employees.Select(e => new
             {
                 FullName = e.FullName,
                 Email = e.Email,
                 Salary = e.Salary,
             }).Where(e => e.Salary >= 500000);
             foreach (var emp in result)
             {
                 Console.WriteLine(emp.FullName);
                 Console.WriteLine(emp.Salary);
                 Console.WriteLine(emp.Email);
                 Console.WriteLine();
             }*/

            //Query syntax
            /* var result = from e in employees
                          where e.Salary >= 500000
                          select new
                          {
                              FullName = e.FullName,
                              Email    = e.Email,
                              Salary   = e.Salary
                          };

             foreach (var emp in result)
             {
                 Console.WriteLine(emp.FullName);
                 Console.WriteLine(emp.Salary);
                 Console.WriteLine(emp.Email);
                 Console.WriteLine();
             }*/

            //join- Method syntax
            /*var result = departments.Join(employees,
                departments => departments.DId,
                employees => employees.DId,
                (departments, employees) => new
                {
                    FullName   = employees.FullName,
                    Email      = employees.Email,
                    Salary     = employees.Salary,
                    Department = departments.DepartmentName
                }
                );
            foreach (var emp in result)
            {
                Console.WriteLine(emp.FullName);
                Console.WriteLine(emp.Salary);
                Console.WriteLine(emp.Email);
                Console.WriteLine(emp.Department);
                Console.WriteLine();
            }*/
            //join- Query syntax
            var result = from e in employees
                         join d in departments
                         on e.DId equals d.DId
                         select new
                         {
                             e.FullName,
                             e.Email,
                             e.Salary,
                             Department = d.DepartmentName
                         };
            foreach (var emp in result)
            {
                Console.WriteLine(emp.FullName);
                Console.WriteLine(emp.Salary);
                Console.WriteLine(emp.Email);
                Console.WriteLine(emp.Department);
                Console.WriteLine();
            }
        }
    }
}