/*10. Suponga que tiene una tienda y desea registrar sus ventas por medio de una computadora. 
 * Diseñe un programa que lea por cada cliente:
a).-el monto de la venta,
b).-calcule e imprima el ITBIS ,
c).-calcule e imprima el total a pagar,
d).-lea la cantidad con que paga el cliente,
e).-calcule e imprime el cambio.
       Al final del día deberá imprimir la cantidad de dinero que debe haber en la caja

a.Debe tener al menos 1 bucle.
b.	Debe tener al menos 3 variables.
c.	Debe tener al menos 2 decisiones.
d.	Debe pedir al menos 2 valores por teclado.
e.	Debe imprimir las matrículas y nombres de los integrantes del equipo y al menos un valor.
*/
using System;
using System.Numerics;

namespace ProyectoFinal
{
    class Proyecto
    {

        public static void Main(String[] args)
        {
            double venta = 0, ventasTotales = 0, itbis = 0, total = 0, cambio = 0, precio = 0;
            int pago = 0, cantidad = 0;
            bool correr = true;

            Console.WriteLine("\n---------------Bienvenido al sistema de registro de compras-------------------");

            do
            {
                Console.WriteLine("\nBienvenido al sistema de registro de compras");

                Console.Write("Ingrese el precio del producto: ");
                precio = double.Parse(Console.ReadLine());

                Console.Write("Ingrese la cantidad del producto: ");
                cantidad = int.Parse(Console.ReadLine());

                venta = precio * cantidad;

                itbis = venta * 0.18;

                venta += itbis;

                Console.Write("\nEl monto de su venta asciende a: " + venta);
                ventasTotales += venta;
                Console.Write("Ingrese el monto pagado: ");
                pago = int.Parse(Console.ReadLine());

                Console.Write("Su cambio es: " + (pago - venta));


                Console.WriteLine("\nDesea: " +
                    "\n1. Agregar otra compra" +
                    "\n2. Ver dinero en caja y salir: ");
                int desicion = int.Parse(Console.ReadLine());


                if (desicion == 1)
                {
                    correr = true;
                    continue;
                }

                if (desicion == 2)
                {
                    correr = false;
                    break;
                }

            } while (correr == true);

            Console.WriteLine("\nEl dinero en caja es: " + ventasTotales);
            Console.WriteLine("\nMatricula: 16–sin-1-173" +
                "\nNombre: Felix Mateo");

        }

    }
}
