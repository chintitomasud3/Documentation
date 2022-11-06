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
.
