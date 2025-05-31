using Model;

namespace DelegatesExample
{
    public static class GroupBy
    {
        public static void GroupByUsingLinq()
        {
            List<Employee> employees     = Data.GetEmployees();
            List<Department> departments = Data.GetDepartments();
            var listOfResult = from employee in employees
                               group employee by employee.Email;
            foreach (var item in listOfResult)
            {
                Console.WriteLine("{0}", item.Key);
                
            }
        }
    }
}
