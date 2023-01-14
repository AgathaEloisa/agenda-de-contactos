using System;

namespace ProyectoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacto c1 = new Contacto("Agatha", "555322461", "agatha.saez@outlook.cl");
            Console.WriteLine(c1);

            Console.WriteLine("Menú");
            int opcion = Convert.ToInt32(Console.ReadLine());
            #region
            if (opcion == 1)
            {
                c1.VerContacto();
            } else if (opcion == 2)
            {
                c1.AgregarContacto();
            }
            else if (opcion == 3)
            {
                c1.BorrarUltimoContacto();
            }
            else if (opcion == 4)
            {
                c1.Buscarcontacto();
            } else if (opcion == 5)
            {

            } else
            {
                Console.WriteLine("La opción ingresada no está en el menú");
            }
            #endregion
        }
    }
}
