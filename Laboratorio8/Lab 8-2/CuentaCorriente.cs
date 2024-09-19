using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_2
{
    public class CuentaCorriente : Cuenta
    {
        public CuentaCorriente(string prmtIdCuenta) : base(prmtIdCuenta)
        {
        }

        public override void CalcularIntereses()
        {
            System.Console.WriteLine("CuentaAhorro.CalcularIntereses() efectuado para " + "la cuenta {0}", getIdCuenta());
        }
    }

}