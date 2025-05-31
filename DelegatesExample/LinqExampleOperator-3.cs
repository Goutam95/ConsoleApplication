using Model;
using System.Diagnostics.CodeAnalysis;

namespace DelegatesExample
{
    public class LinqExampleOperator_3
    {
        public void LinqIntro_1()
        {
            List<Employee> employees     = Data.GetEmployees();
            List<Department> departments = Data.GetDepartments();
            //sorting orderby, descending
            //var result = from e in employees
            //             where e.Salary >= 500000
            //             orderby e.FullName descending
            //             select new
            //             {
            //                 FullName = e.FullName,
            //                 Email = e.Email,
            //                 Salary = e.Salary
            //             };

            //foreach (var emp in result)
            //{
            //    Console.WriteLine(emp.FullName);
            //    Console.WriteLine(emp.Salary);
            //    Console.WriteLine(emp.Email);
            //    Console.WriteLine();
            //}
            ///ToLookUp operator
            //var groupResult = employees.OrderBy(d => d.DId).ToLookup(e => e.DId);

            //foreach (var emp in groupResult)
            //{
            //    Console.WriteLine(emp.Key);
            //    foreach (var item in emp)
            //    {
            //        Console.WriteLine(item.FullName);
            //        Console.WriteLine(item.Salary);
            //        Console.WriteLine(item.Email);
            //        Console.WriteLine();
            //    }
            //}
            ///Contains Operator
            //var addemployee = new Employee()
            //{
            //    Email = "demo@gmail.com",
            //    Id = 1,
            //    FullName = "G Goutam",
            //    Salary = 500003,
            //    DId = 1,
            //};
            //bool containsEmployee = employees.Contains(addemployee, new EmployeeComparer());
            //if (containsEmployee)
            //{
            //    Console.WriteLine($"Employee name is {addemployee.FullName} was found");
            //}
            //else
            //{
            //    Console.WriteLine($"Employee name is {addemployee.FullName} was not found");
            //}
            ///OfType Filter opertor
            //ArrayList arrayList = Data.GetArrayList();
            //var result = from s in arrayList.OfType<Employee>()
            //             select s;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.FullName);
            //    Console.WriteLine(item.Salary);
            //    Console.WriteLine(item.Email);
            //    Console.WriteLine();
            //}
            //var resultInt = from s in arrayList.OfType<int>()
            //             select s;
            //foreach (var item in resultInt)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine();
            //}
            //var resultString = from s in arrayList.OfType<string>()
            //                select s;
            //foreach (var item in resultString)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine();
            //}
            //var resultFloat = from s in arrayList.OfType<float>()
            //                   select s;
            //foreach (var item in resultFloat)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine();
            //}
            ///first, FirstOrdefault
            //List<int> ints = new List<int> { 1, 9, 89, 17,46 };
            //var result = ints.FirstOrDefault(i => i % 2 == 0);
            //if (result != 0)
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{ 
            //    Console.WriteLine($"No data is maching this intger List");
            //}

            ///Concat opertor
            //List<Employee> employees2 = new() { new Employee { Id = 4, Email = "Sam@gmail.com", FullName = "Sam S", Salary = 345600 } };
            //IEnumerable<Employee> employees3 =employees.Concat(employees2);
            //foreach (var item in employees3)
            //{
            //    Console.WriteLine(item.FullName);
            //    Console.WriteLine(item.Salary);
            //    Console.WriteLine(item.Email);
            //    Console.WriteLine();
            //}
            ///Aggregate operator
            string data = employees.Aggregate<Employee, string, string>("Employee Annual salary is : ",
                (s, e) =>
                {
                    var bonus = 20;
                    s += $"{e.FullName} - {e.Salary + (e.Salary * bonus)},";
                    return s;
                }, s => s.Substring(0, s.Length - 2)
                );
            Console.WriteLine(data);

        }
        public class EmployeeComparer : IEqualityComparer<Employee>
        {
            public bool Equals(Employee? x, Employee? y)
            {
                if (x.Id == y.Id && x.Email == y.Email
                    && x.FullName.ToLower() == y.FullName.ToLower() 
                    && x.Salary == y.Salary 
                    && x.DId == y.DId)
                { 
                  return true;
                }
                return false;
            }

            public int GetHashCode([DisallowNull] Employee obj)
            {
                return obj.Id.GetHashCode();
            }
        }
    }
}