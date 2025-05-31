using System.Collections;
namespace Model
{
    public static class Data
    {
        public static List<Employee> GetEmployees() 
        {
          List<Employee> list = new();
            Employee employee = new()
            { 
              Email = "demo@gmail.com",
              Id = 1,
              FullName  = "Goutam G",
              Salary=500003,
              DId= 1,
            };
            list.Add(employee);
            employee = new()
            {
                Email = "Robi@gmail.com",
                Id = 2,
                FullName = "Robi",
                Salary = 400003,
                DId = 2,
            };
            list.Add(employee);
            employee = new()
            {
                Email = "Bapi@gmail.com",
                Id = 3,
                FullName = "Bapi",
                Salary = 600003,
                DId = 2,
            };
            list.Add(employee);
            return list;
        }
        public static List<Department> GetDepartments() 
        {
          List<Department> list = new();
            Department department = new()
            {
                DId = 1,
                DepartmentName = "IT"
            };
            list.Add(department);
            department = new()
            {
                DId = 2,
                DepartmentName = "Accounts"
            };
            list.Add(department);
            return list;
        }

        public static ArrayList GetArrayList()
        { 
        ArrayList arrayList= new();

            arrayList.Add(12);
            arrayList.Add(123);
            arrayList.Add("Sunday");
            arrayList.Add("Monday");
            arrayList.Add(12.89);
            arrayList.Add(new Employee { Id = 4,Email = "Sam@gmail.com",FullName = "Sam S", Salary = 345600 });
            arrayList.Add(new Employee { Id = 5, Email = "Deep@gmail.com", FullName = "Deep D", Salary = 456000 });
            arrayList.Add(new Department { DId = 3, DepartmentName = "HR"});
            arrayList.Add(new Department { DId = 4, DepartmentName = "Finance" });
            return arrayList;
        }
    }
}
