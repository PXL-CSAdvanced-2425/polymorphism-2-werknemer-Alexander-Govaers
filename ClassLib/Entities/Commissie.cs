using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Data
{
    public class Commissie : Werknemer
    {
        private decimal _comm;



        public decimal CommissionPercentage => _comm;

        public decimal Turnover { get; set; }
        public decimal Wage { get; set; }

        public override string Info()
        {
            return $"{Type} | {FirstName + LastName,-15} wedde (incl. comm.): {CommissionPercentage:c} + {Wage:c} = {Salary():c}";
        }

        public override decimal Salary()
        {
            
            return Wage * CommissionPercentage;
        }

        public Commissie(string firstName, string lastName, char type, decimal percentage, decimal turnOver, decimal wage) : base(firstName, lastName, type)
        {
            this.Turnover = turnOver;
            this.Wage = wage;
            this._comm = percentage;

        }

        public override string ToString()
        {
            return $"{Info()}";
        }
    }
}
