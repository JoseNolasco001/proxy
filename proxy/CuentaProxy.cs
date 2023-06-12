using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace proxy
{
    internal class CuentaProxy : ICuenta
    {
        private CuentaBanco cuentaReal;

        public Cuenta depositarDinero(Cuenta cuenta, double monto)
        {
            if(cuentaReal == null)
            {
                cuentaReal = new CuentaBanco();
                return cuentaReal.depositarDinero(cuenta, monto);
            }
            else
            {
                return cuentaReal.depositarDinero(cuenta, monto);
            }
        }

        public Cuenta retirarDinero(Cuenta cuenta, double monto)
        {
            if (cuentaReal == null)
            {
                cuentaReal = new CuentaBanco();
                return cuentaReal.retirarDinero(cuenta, monto);
            }
            else
            {
                return cuentaReal.retirarDinero(cuenta, monto);
            }
        }

        public void mostrarSaldo(Cuenta cuenta)
        {
            if (cuentaReal == null)
            {
                cuentaReal = new CuentaBanco();
                cuentaReal.mostrarSaldo(cuenta);
            }
            else
            {
                cuentaReal.mostrarSaldo(cuenta);
            }
        }
    }
}
