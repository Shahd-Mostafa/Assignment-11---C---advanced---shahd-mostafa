using Assignment_11___C____advanced___shahd_mostafa.classes;

namespace Assignment_11___C____advanced___shahd_mostafa
{
    internal class Program
    {
        static void EmployeeLaidOffHandler(object sender, EmployeeLayOffEventArgs e)
        {
            Employee? emp = sender as Employee;
            Console.WriteLine($"Employee {emp?.EmployeeID} is laid of due to {e.Cause}");
        }
        static void Main(string[] args)
        {
            #region Q1
            Employee employee1 = new Employee() { EmployeeID = 11, BirthDate = new DateTime(2002, 5, 2), VacationStock = 5 };
            Employee employee2 = new Employee() { EmployeeID = 13, BirthDate = new DateTime(2003, 3, 5), VacationStock = -1 };
            Employee employee3 = new Employee() { EmployeeID = 14, BirthDate = new DateTime(1940, 4, 8), VacationStock = 7 };

            employee1.EmployeeLayOff += EmployeeLaidOffHandler;
            employee2.EmployeeLayOff += EmployeeLaidOffHandler;
            employee3.EmployeeLayOff += EmployeeLaidOffHandler;

            employee1.EndOfYearOperation();
            employee2.EndOfYearOperation();
            employee3.EndOfYearOperation();
            #endregion

            Console.WriteLine("============================");

            #region Q2
            Department dept = new Department(10, "ITdepartement");
            dept.AddStaff(employee1);
            dept.AddStaff(employee2);
            dept.AddStaff(employee3);

            Console.WriteLine("Staff before removal: ");
            dept.Display();
            Console.WriteLine();
            employee1.EmployeeLayOff -= EmployeeLaidOffHandler;
            employee2.EmployeeLayOff -= EmployeeLaidOffHandler;
            employee3.EmployeeLayOff -= EmployeeLaidOffHandler;

            employee1.EndOfYearOperation();
            employee2.EndOfYearOperation();
            employee3.EndOfYearOperation();
            Console.WriteLine();

            Console.WriteLine("Staff after removal: ");
            dept.Display();
            #endregion

            Console.WriteLine("============================");

            #region Q3
            Club club= new Club(10,"Elite Club");
            club.AddMember(employee1);
            club.AddMember(employee2);
            club.AddMember(employee3);

            Console.WriteLine("Club members before removal");
            club.display();
            Console.WriteLine();


            employee1.EndOfYearOperation();
            employee2.EndOfYearOperation();
            employee3.EndOfYearOperation();
            Console.WriteLine();

            Console.WriteLine("Club members after removal: ");
            club.display();
            #endregion
        }
    }
}
