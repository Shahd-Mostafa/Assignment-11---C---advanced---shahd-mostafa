using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11___C____advanced___shahd_mostafa.classes
{
    class SalesPerson : Employee
    {
        public int AchievedTarget { get; set; }
        public bool CheckTarget(int Quota)
        {
            return AchievedTarget >= Quota;
        }
        public override void EndOfYearOperation()
        {
            if (!CheckTarget(100)) 
            {
                OnEmployeeLayOff(LayOffCause.UnachievedTarget);
            }
        }
    }
    class BoardMember : Employee
    {
        public override void EndOfYearOperation()
        {
            // board member will never be laid off so i left it empty
        }
        public void Resign()
        {
            OnEmployeeLayOff(LayOffCause.resigned);
        }
    }
}
