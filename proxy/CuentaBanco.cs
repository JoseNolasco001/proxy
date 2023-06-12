using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy
{
    internal class CuentaBanco : ICuenta
    {
        public Cuenta depositarDinero(Cuenta cuenta, double monto)
        {
            double saldoActual = cuenta.getSaldo() + monto;
            cuenta.setSaldo(saldoActual);
            Console.WriteLine($"\nSe deposito {monto} a la cuenta {cuenta.getIdCuenta()}\nEl saldo actual de la cuenta {cuenta.getIdCuenta()} es de ${saldoActual}");
            return cuenta;
        }

        public Cuenta retirarDinero(Cuenta cuenta, double monto)
        {
            double saldoActual = cuenta.getSaldo() - monto;
            cuenta.setSaldo(saldoActual);
            Console.WriteLine($"\nSe retiro {monto} de la cuenta {cuenta.getIdCuenta()}\nEl saldo actual de la cuenta {cuenta.getIdCuenta()} es de ${saldoActual}");
            return cuenta;
        }

        public void mostrarSaldo(Cuenta cuenta)
        {
            Console.WriteLine($"\nEl saldo actual de la cuenta {cuenta.getIdCuenta()} es de ${cuenta.getSaldo()}");
        }

    }
}
