using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Adv_04
{
    public class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }

        private List<Employee> staff = new List<Employee>();

        public void AddStaff(Employee e)
        {
            staff.Add(e);
            e.LayOffNotification += HandleLayOff;
        }

        private void HandleLayOff(LayOffCause cause)
        {
            List<Employee> employeesToRemove = new List<Employee>();

            foreach (Employee employee in staff)
            {
                if (cause == LayOffCause.VacationStockNegative || cause == LayOffCause.AgeExceedsLimit)
                {
                    employeesToRemove.Add(employee);
                }
            }

            foreach (Employee employee in employeesToRemove)
            {
                staff.Remove(employee);
            }
        }
    }
}
