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
        static void DisplayEmployeeDetails(Employee emp)
        {
            Console.WriteLine($"- Employee ID: {emp.EmployeeID},Age: {DateTime.Now.Year - emp.BirthDate.Year}, Type: {emp.GetType().Name}");
        }
        static void Main(string[] args)
        {
            #region Q1
            Employee employee1 = new Employee() { EmployeeID = 11, BirthDate = new DateTime(2002, 5, 2), VacationStock = 5 };
            Employee employee2 = new Employee() { EmployeeID = 13, BirthDate = new DateTime(2003, 3, 5), VacationStock = -1 };
            Employee employee3 = new Employee() { EmployeeID = 14, BirthDate = new DateTime(1940, 4, 8), VacationStock = 7 };

            Console.WriteLine("Employees before layoff: ");
            DisplayEmployeeDetails(employee1);
            DisplayEmployeeDetails(employee2);
            DisplayEmployeeDetails(employee3);
            Console.WriteLine();

            employee1.EmployeeLayOff += EmployeeLaidOffHandler;
            employee2.EmployeeLayOff += EmployeeLaidOffHandler;
            employee3.EmployeeLayOff += EmployeeLaidOffHandler;

            employee1.EndOfYearOperation();
            employee2.EndOfYearOperation();
            employee3.EndOfYearOperation();

            Console.WriteLine("Employees after layoff: ");
            #endregion

            Console.WriteLine("============================");

            #region Q2
            Department dept = new Department(10, "ITdepartement");
            dept.AddStaff(employee1);
            dept.AddStaff(employee2);
            dept.AddStaff(employee3);

            Console.WriteLine("Staff before layoff: ");
            dept.Display();
            Console.WriteLine();
            employee1.EmployeeLayOff -= EmployeeLaidOffHandler;
            employee2.EmployeeLayOff -= EmployeeLaidOffHandler;
            employee3.EmployeeLayOff -= EmployeeLaidOffHandler;

            employee1.EndOfYearOperation();
            employee2.EndOfYearOperation();
            employee3.EndOfYearOperation();
            Console.WriteLine();

            Console.WriteLine("Staff after layoff: ");
            dept.Display();
            #endregion

            Console.WriteLine("============================");

            #region Q3
            Club club= new Club(10,"Elite Club");
            club.AddMember(employee1);
            club.AddMember(employee2);
            club.AddMember(employee3);

            Console.WriteLine("Club members before layoff");
            club.display();
            Console.WriteLine();


            employee1.EndOfYearOperation();
            employee2.EndOfYearOperation();
            employee3.EndOfYearOperation();
            Console.WriteLine();

            Console.WriteLine("Club members after layoff: ");
            club.display();
            #endregion

            Console.WriteLine("============================");

            #region Q4
            Employee normalEmployee = new Employee() { EmployeeID = 1, BirthDate = new DateTime(2003, 3, 5), VacationStock = -1 };
            SalesPerson salesperson = new SalesPerson { EmployeeID = 2, BirthDate = new DateTime(1990, 7, 15), AchievedTarget = 50 };
            BoardMember boardMember = new BoardMember { EmployeeID = 3, BirthDate = new DateTime(1950, 8, 10) };

            club.AddMember(normalEmployee);
            club.AddMember(salesperson);
            club.AddMember(boardMember);

            dept.AddStaff(normalEmployee);
            dept.AddStaff(salesperson);
            dept.AddStaff(boardMember);

            normalEmployee.EmployeeLayOff+= EmployeeLaidOffHandler;
            salesperson.EmployeeLayOff += EmployeeLaidOffHandler;
            boardMember.EmployeeLayOff -= EmployeeLaidOffHandler;

            Console.WriteLine("Employees before layoff:");
            DisplayEmployeeDetails(normalEmployee);
            DisplayEmployeeDetails(salesperson);
            DisplayEmployeeDetails(boardMember);

            Console.WriteLine();

            Console.WriteLine("after end of year operation: ");
            normalEmployee.EndOfYearOperation();
            salesperson.EndOfYearOperation();
            boardMember.EndOfYearOperation();
            Console.WriteLine();

            Console.WriteLine("Employees after layoff:");
            Console.WriteLine("Board member was not laid off but he has resigned");
            boardMember.Resign();
            #endregion
        }
    }
}
