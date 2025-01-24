using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11___C____advanced___shahd_mostafa.classes
{
    internal class Department
    {
        public Department(int id,string name)
        {
            DeptID= id;
            DeptName= name;
            Staff = new List<Employee>();
        }
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        List<Employee> Staff;
        public void AddStaff(Employee E)
        {
            Staff.Add(E);
            E.EmployeeLayOff += RemoveStaff;
            
        }
        public void RemoveStaff(object sender,
        EmployeeLayOffEventArgs e)
        {
            if(sender is Employee emp)
            {
                if (e.Cause == LayOffCause.vacationStockEmpty || e.Cause == LayOffCause.employeeAgeExceeded)
                {
                    Console.WriteLine($"Employee {emp.EmployeeID} was removed from {DeptName} due to {e.Cause}");
                    emp.EmployeeLayOff -= RemoveStaff;
                    Staff.Remove(emp);
                }
            }
        }
        public void Display()
        {
            foreach (Employee E in Staff)
            {
                Console.WriteLine($"- Employee ID: {E.EmployeeID} , Age: {DateTime.Now.Year - E.BirthDate.Year}, Vacation Stock: {E.VacationStock}");
            }
        }
    }
}
