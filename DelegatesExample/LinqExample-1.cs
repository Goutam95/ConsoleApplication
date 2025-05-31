using Model;

namespace DelegatesExample
{
    public class LinqExample_1
    {
        public static void LinqIntro()
        {
            List<Employee> employees     = Data.GetEmployees();
            List<Department> departments = Data.GetDepartments();
                            
            var resultData = from e in employees
                             join d in departments
                             on e.DId equals d.DId
                             select new
                             {
                                 e.FullName,
                                 e.Email,
                                 e.Salary,
                                 Department = d.DepartmentName
                             };

            var filterData = employees.Filter(e => e.DId == 2 && e.Salary > 600000);
            foreach (var emp in resultData)
            {
                Console.WriteLine(emp.FullName);
                Console.WriteLine(emp.Salary);
                Console.WriteLine(emp.Email);
                Console.WriteLine(emp.Department);
                Console.WriteLine(); 
            } 
            var avaragesalary = resultData.Average(x => x.Salary);
            Console.WriteLine(avaragesalary);

            var maxsalary = resultData.Max(x => x.Salary);
            Console.WriteLine(maxsalary);

            var minSalary = resultData.Min(x => x.Salary);
            Console.WriteLine(minSalary);
            Console.ReadKey();
        }
    }
}
