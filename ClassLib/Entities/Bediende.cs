using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Data
{
    public class Bediende : Werknemer
    {


        public decimal HourlyWage { get; set; }
        public decimal HoursWorked { get; set; }


        public Bediende(string firstName, string lastName, char type, decimal hourlyWage, decimal hoursWorked) : base(firstName, lastName, type)
        {
            this.HourlyWage = hourlyWage;
            this.HoursWorked = hoursWorked;
        }

        public override string Info()
        {
            return $"{Type} | {FirstName + " " + LastName,-15} - wedde: {HourlyWage:c} x {HoursWorked} = {Salary():c}";
        }

      

        public override decimal Salary()
        {
            decimal total = HourlyWage * HoursWorked;
            return total;
        }

        public override string ToString()
        {
            return $"{Info()}";
        }
    }
}
