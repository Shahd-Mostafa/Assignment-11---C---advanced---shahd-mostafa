using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11___C____advanced___shahd_mostafa.classes
{
    internal class Club
    {
        public Club(int id,string Name)
        {
            ClubID = id;
            ClubName = Name;
            Members = new List<Employee>();
        }
        public int ClubID { get; set; }
        public String ClubName { get; set; }
        List<Employee> Members;
        public void AddMember(Employee E)
        {
            Members.Add(E);
            if (E is not BoardMember)
            {
                E.EmployeeLayOff += RemoveMember;
            }
        }
        public void RemoveMember
        (object sender, EmployeeLayOffEventArgs e)
        {
            if (sender is Employee emp)
            {
                if(e.Cause == LayOffCause.vacationStockEmpty)
                {
                    Console.WriteLine($"Employee {emp.EmployeeID} is removed from {ClubName} due to {e.Cause}");
                    emp.EmployeeLayOff -= RemoveMember;
                    Members.Remove(emp);
                }
                else if (e.Cause == LayOffCause.employeeAgeExceeded)
                {
                    Console.WriteLine($"Employee {emp.EmployeeID} remains in {ClubName} despite exceeding age limit");
                }
            }
        }
        public void display()
        {
            foreach (Employee E in Members)
            {
                Console.WriteLine($"- Employee ID: {E.EmployeeID} , Age: {DateTime.Now.Year - E.BirthDate.Year}, Vacation Stock: {E.VacationStock}");
            }
        }
    }
}
