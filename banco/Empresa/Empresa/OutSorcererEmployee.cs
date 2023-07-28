using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    internal class OutSorcererEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutSorcererEmployee()
        {

        }
        public OutSorcererEmployee(string nome, int hours, double valuePerHour, double  additionalCharge) :base (nome, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
          
        }
        public override double Payment()
        {
            return base.Payment()*1.1+AdditionalCharge;  
        }

    }
}
