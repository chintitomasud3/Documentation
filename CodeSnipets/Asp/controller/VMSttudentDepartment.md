  ```cs


  
  
  //Controller class
   public IActionResult StudentAllDepartment() {

           // List<Student> studentList = _context.Students.ToList();
            List<Student> studentList = _context.Students.Include(s => s.Department).ToList();
            List<Department> departments = _context.Departments.ToList();

            StudentAllDepartment studentdepartment=new StudentAllDepartment();
            studentdepartment.Students = studentList;
            studentdepartment.Departments = departments;

            return View(studentdepartment);
        }
        
      //Vm class  
        public class StudentAllDepartment
    {
        //public int StudentId { get; set; }
        //public string StudentName { get; set; }

        public List<Student> Students { get; set; }
        public List<Department>Departments { get; set; }
    }
        
        
        
        
        // Html file 
        @*
    For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
*@
@{
    @model experiment1.Models.ViewModel.StudentAllDepartment
}
 @*<h1> All Students </h1>

 @foreach(var item in Model.Students){
    <p>@item.StudentName</p>
 
 }*@

 <h1> All Department</h1>

@foreach (var item in Model.Departments)
{
    <p>@item.Name</p>

}

<h1> All Students</h1>

<table class="table">

    <thead>
        
            <tr>
                <th>
                    @Html.DisplayNameFor(model => Model.Students[0].StudentName)
                </th>
                <th>
                @Html.DisplayNameFor(model => Model.Students[0].Phone)
                </th>
                <th>
                @Html.DisplayNameFor(model => Model.Students[0].Email)
                </th>
            <th>
                @Html.DisplayNameFor(model => Model.Students[0].DepartmentId)
            </th>
            <th>
                DepartmentName
            </th>
                


                <th></th>
            </tr>

        
    
    </thead>



    <tbody>

        @foreach (var item in Model.Students)
        {
            <tr>
                <td>
                    @Html.DisplayFor(modelItem => item.StudentName)
                </td>
                <td>
                    @Html.DisplayFor(modelItem => item.Phone)
                </td>
                <td>
                    @Html.DisplayFor(modelItem => item.Email)
                </td>
                <td>
                    @Html.DisplayFor(modelItem => item.DepartmentId)
                </td>
                <td>
                    @Html.DisplayFor(modelItem => item.Department.Name)
                </td>
                <td>
                    <a asp-action="Edit" asp-route-id="@item.StudentId">Edit</a> |
                    <a asp-action="Details" asp-route-id="@item.StudentId">Details</a> |
                    <a asp-action="Delete" asp-route-id="@item.StudentId">Delete</a>
                </td>
            </tr>
        }
    </tbody>
</table>
```
