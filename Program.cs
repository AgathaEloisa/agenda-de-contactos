using System;

namespace ProyectoFinal
{
    class Program
    {
        static void Main(string[] args)
        {

            Contacto c1 = new Contacto();
            bool volver = true;
            //string volverMensaje = "¿Desea volver al menú? (S/N)";

            //while (volver == true)
            //{
            //    Console.WriteLine(volverMensaje);
            //}



            string[] opciones = { "Ver contactos", "agregar contacto", "Borrar último contacto", "Buscar contacto por nombre", "Salir" };
            string[] opciones2 = { "Orden ascendente", "Orden descendente" };

            Console.WriteLine("*** Menú ***\n");
            do
            {
                for (int i = 0; i < opciones.Length; i++)
                {
                    Console.WriteLine("\n{0}: {1}", i + 1, opciones[i]);
                }
                int opcion = Convert.ToInt32(Console.ReadLine());
                try
                {
                    #region Menu
                    if (opcion == 1)
                    {
                        bool PreguntarDenuevo = false;
                        do
                        {
                            for (int i = 0; i < opciones2.Length; i++)
                            {
                                Console.WriteLine("\n{0}: {1}", i + 1, opciones2[i]);
                            }
                            int orden = Convert.ToInt32(Console.ReadLine());

                            if (orden == 1 || orden == 2)
                            {
                                c1.VerContacto(orden);
                            }
                            else
                            {
                                Console.WriteLine("Seleccione una opción");
                                PreguntarDenuevo = true;
                            }
                        } while (PreguntarDenuevo == true);
                    }
                    else if (opcion == 2)
                    {
                        Console.Write("Nombre: ");
                        string NuevoNombre = Console.ReadLine();
                        Console.Write("\nTeléfono: ");
                        string NuevoTelefono = Console.ReadLine();
                        Console.Write("\nEmail: ");
                        string NuevoEmail = Console.ReadLine();
                        c1.AgregarContacto(NuevoNombre, NuevoTelefono, NuevoEmail);
                    }
                    else if (opcion == 3)
                    {
                        c1.BorrarUltimoContacto();
                    }
                    else if (opcion == 4)
                    {
                        Console.WriteLine("Ingrese nombre del contacto");
                        string nombre = Console.ReadLine();
                        c1.Buscarcontacto(nombre);
                    }
                    else if (opcion == 5)
                    {
                        volver = false;
                        return;
                    }
                    else
                    {
                        Console.WriteLine("La opción ingresada no está en el menú");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Ha ocurrido un error");
                }

            }
            while (volver == true);
            #endregion
        }
    }
}
