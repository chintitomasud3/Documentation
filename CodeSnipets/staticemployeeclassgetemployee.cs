public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Employee> GetEmployee() {

            List<Employee> employees = new List<Employee>()
            {
               new Employee(){ Id=1,Name="Masudur rahman"},
               new Employee(){ Id=2,Name="sumaiya mehreen meem"}
            };

            return employees;    
         
         }
            
        }



public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }

        public static List<Department> GetDepartments() {

            List<Department> departments = new List<Department>()
            {
                new Department{ DepartmentId=1,Name="HR"},
                new Department{ DepartmentId=2,Name="IT"}

            };
            return departments;
        
        }
    }





public IActionResult Index()

        {
            // IEnumerable<Employee> employees = Employee.GetEmployee().Where(emp=>emp.DepartmentId==2);
            var result = from e in Employee.GetEmployee()
                         join d in Department.GetDepartments()
                         on e.DepartmentId equals d.DepartmentId
                         select new Customviewmodel
                         {
                             employeename = e.Name,
                             departmentname = d.Name
                         };
            
            
            return View(result);
        }




public class Customviewmodel
    {
        public string employeename { get; set; }
        public string departmentname { get; set; }
    }






@model IEnumerable<freecode.Models.Customviewmodel>
@{
    ViewData["Title"] = "Home Page";
}

<div class="text-center">
    <h1 class="display-4">Welcome</h1>
    <p>Learn about <a href="https://docs.microsoft.com/aspnet/core">building Web apps with ASP.NET Core</a>.</p>
</div>

@foreach(var item in @Model){
    <h1>ID:@item.employeename</h1>
    <h2>Name: @item.departmentname</h2>
     
}
