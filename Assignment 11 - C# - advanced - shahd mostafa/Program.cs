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
        }
    }
}
