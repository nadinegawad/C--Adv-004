using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Adv_04
{
    public class Club
    {
        public int ClubID { get; set; }
        public string ClubName { get; set; }

        private List<Employee> members = new List<Employee>();

        public void AddMember(Employee e)
        {
            members.Add(e);
            e.LayOffNotification += HandleLayOff;
        }

        private void HandleLayOff(LayOffCause cause)
        {
            if (cause == LayOffCause.VacationStockNegative)
            {
                List<Employee> employeesToRemove = new List<Employee>();

                foreach (Employee member in members)
                {
                    if (member.VacationStock < 0)
                    {
                        employeesToRemove.Add(member);
                    }
                }

                foreach (Employee employee in employeesToRemove)
                {
                    members.Remove(employee);
                }
            }
            
        }
    }
}
