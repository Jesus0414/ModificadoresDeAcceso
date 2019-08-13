using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresDeAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = "Jesus";
            cliente.Telefono = "(644)4477007";

            Console.WriteLine("Nombre: " + cliente.Nombre);
            Console.WriteLine("Telélefono: " + cliente.Telefono);

            try
            {
                cliente.Curp = "123456789123456789";
                Console.WriteLine("Curp:" + cliente.Curp);
            }
            catch (Exception e)
            {
                Console.WriteLine("La CURP debe de ser de 18 caracteres");
            }

            //

            Cuenta cuenta = new Cuenta();
            cuenta.Propietario = cliente;
            cuenta.Saldo = 25;

            Console.WriteLine("Curp: " + cuenta.Propietario.Curp);
            Console.WriteLine("Saldo: " + cuenta.Saldo);

            try
            {
                cuenta.Identificador = "98765432100";
                Console.WriteLine("Identificador: " + cuenta.Identificador);
            }
            catch(Exception f)
            {
                Console.WriteLine("El identidicador debe tener entre 10 y 14 caracteres");
            }

            Console.Read();
        }
    }
}
