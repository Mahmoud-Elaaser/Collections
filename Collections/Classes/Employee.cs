using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Classes
{
    internal class Employee
    {
        public int EmployeeNo { get; set; }
        public string FullName { get; set; }
        public string Job { get; set; }
        public decimal StartSalary { get; set; }
        public int WorkingHoursPerWeek { get; set; }
        public Contract contract { get; set; }
        public Employee(int EmployeeNo, string FullName, string Job, decimal StartSalary, int WorkingHoursPerWeek, Contract contract)
        {
            this.EmployeeNo = EmployeeNo;
            this.FullName = FullName;
            this.Job = Job;
            this.StartSalary = StartSalary;
            this.WorkingHoursPerWeek = WorkingHoursPerWeek;
            this.contract = contract;
        }
        public Employee()
        {

        }

    }
    public enum Contract
    {
        FullTime,
        PartTime,
        Casual,
        Freelance
    }

}
