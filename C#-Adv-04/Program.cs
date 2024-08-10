namespace C__Adv_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department dept = new Department { DeptID = 1, DeptName = "IT" };
            Club club = new Club { ClubID = 1, ClubName = "Club01" };
            Employee emp1 = new Employee { EmployeeID = 1, BirthDate = new DateTime(1999, 1, 1), VacationStock = -1 };
            Employee emp2 = new Employee { EmployeeID = 2, BirthDate = new DateTime(1994, 3, 1), VacationStock = 10 };
            dept.AddStaff(emp1);
            dept.AddStaff(emp2);
            club.AddMember(emp1);
            club.AddMember(emp2);
            emp1.EndOfYearOperation();
            emp2.EndOfYearOperation();
        }
    }
}
