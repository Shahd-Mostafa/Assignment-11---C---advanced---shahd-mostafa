using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11___C____advanced___shahd_mostafa.classes
{
    internal class Employee
    {
        public Employee() { }
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;
        protected virtual void OnEmployeeLayOff (LayOffCause cause)
        {
            EmployeeLayOff?.Invoke(this,new EmployeeLayOffEventArgs { Cause=cause});
        }
        public int EmployeeID { get; set; }
        private DateTime _BirthDate;
        private int _VacationStock;
        public DateTime BirthDate
        {
            get => _BirthDate;
            set => _BirthDate = value;
        }
        public int VacationStock
        {
            get => _VacationStock;
            set => _VacationStock = value;
        }

        public bool RequestVacation(DateTime From, DateTime To)
        {
            int vacationDays=(To-From).Days;
            if (VacationStock-vacationDays >0)
            {
                VacationStock-=vacationDays;
                return true;
            }
            return false;
        }
        public virtual void EndOfYearOperation()
        {
            if(VacationStock<0)
            {
                OnEmployeeLayOff(LayOffCause.vacationStockEmpty);
            }
            else if(DateTime.Now.Year - BirthDate.Year >60)
            {
                OnEmployeeLayOff(LayOffCause.employeeAgeExceeded);
            }
        }
    }
    public enum LayOffCause
    {
        vacationStockEmpty,
        employeeAgeExceeded,
        UnachievedTarget,
        resigned
    }
    public class EmployeeLayOffEventArgs
    {
        public LayOffCause Cause { get; set; }
        //public EmployeeLayOffEventArgs(LayOffCause cause)
        //{
        //    Cause = cause;
        //}
    }

}
