using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Data
{
    public class Kader : Werknemer
    {
     

        public decimal Wage { get; set; }

        public override string Info()
        {
            return $"{Type} | {FirstName + "" + LastName,-25} - Wedde: {Salary():c}";
        }

        public override decimal Salary()
        {
            return Wage;
        }

        public Kader(string firstName, string lastName, char type, decimal wage) : base(firstName, lastName, type)
        {
            this.Wage = wage;
        }

        public override string ToString()
        {
            return $"{Info()}";
        }
    }
}
