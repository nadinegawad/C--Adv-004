using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Adv_04
{
    public class Employee
    {
        // Define the action for layoff notifications
        public Action<LayOffCause> LayOffNotification;

        protected void NotifyLayOff(LayOffCause cause)
        {
            LayOffNotification?.Invoke(cause);
        }

        public int EmployeeID { get; set; }

        private DateTime birthDate;
        public DateTime BirthDate
        {
            get => birthDate;
            set => birthDate = value;
        }

        private int vacationStock;
        public int VacationStock
        {
            get => vacationStock;
            set
            {
                vacationStock = value;
                if (VacationStock < 0)
                {
                    NotifyLayOff(LayOffCause.VacationStockNegative);
                }
            }
        }

        public bool RequestVacation(DateTime from, DateTime to)
        {
            // Simplified vacation request logic
            return VacationStock >= 0;
        }

        public virtual void EndOfYearOperation()
        {
            
        }

    }
}


