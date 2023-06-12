using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta c = new Cuenta(1, "Jose Nolasco", 100); 

            ICuenta cuenta = new CuentaProxy();
            cuenta.mostrarSaldo(c);
            cuenta.retirarDinero(c, 50);
            cuenta.depositarDinero(c, 10);
            cuenta.mostrarSaldo(c);

            Console.WriteLine($"El saldo de la cuenta de {c.getUsuario()} es de {c.getSaldo()}");
            Console.ReadLine(); 
        }
    }
}
