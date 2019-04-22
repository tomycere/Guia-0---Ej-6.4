using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_0___Ej_6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool esdia = false;
            bool esmes = false;
            bool esaño = false;
            bool escorrecto = false;
            bool eshora = false;
            string ingresohora;
            string ingresodia;
            string ingresomes;
            string ingresoaño;
            var dia = 0;
            var año = 0;
            var mes = 0;
            var hora = 0;
            var minuto = 0;
            var segundo = 0;


            while (!escorrecto)
            {


                while (!esdia)
                {
                    Console.Write("Ingrese el día:");
                    ingresodia = Console.ReadLine();
                    if ((int.TryParse(ingresodia, out dia)) && (dia > 0 && dia < 31))
                    {
                        esdia = true;
                    }
                    else
                    {
                        Console.WriteLine("El día ingresado no es válido");
                    }

                }


                while (!esmes)
                {
                    Console.Write("Ingrese el mes:");
                    ingresomes = Console.ReadLine();
                    if ((int.TryParse(ingresomes, out mes)) && (mes > 0 && (mes <= 12)))
                    {
                        esmes = true;
                    }
                    else
                    {
                        Console.WriteLine("El mes ingresado no es válido");
                    }

                }


                while (!esaño)
                {
                    Console.Write("Ingrese el añp:");
                    ingresoaño = Console.ReadLine();
                    if ((int.TryParse(ingresoaño, out año)) && (año > 0))
                    {
                        esaño = true;
                    }
                    else
                    {
                        Console.WriteLine("El año ingresado no es válido");
                    }

                }

                while (!eshora)
                {
                    Console.Write("Ingrese la hora:");
                    ingresohora = Console.ReadLine();
                    if ((int.TryParse(ingresohora, out hora)) && (hora >= 14 && hora <= 16))
                    {
                        eshora = true;
                    }
                    else
                    {
                        Console.WriteLine("La hora debe estar entre las 14 y 16");
                    }

                }


                DateTime fecha = new DateTime(año, mes, dia, hora, minuto, segundo);

                Console.WriteLine(fecha.ToString("dd/MM/yyyy - hh"));

            }
        }
    }
}
