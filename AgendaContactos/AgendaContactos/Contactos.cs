using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContactos
{
    public class Contactos
    {
        public string Nombre { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public Contactos() { 
        }

        public Contactos(string nombre, string telefono, string email)
        {
            Nombre = nombre;
            Telefono = telefono;
            Email = email;
        }

        List<Contactos> contactos = new List<Contactos>(20);

        #region metodos
        public void AgregarContacto(string nombre, string telefono, string email)
        {
            contactos.Add(new Contactos { Nombre = nombre, Telefono = telefono, Email = email });
            Console.WriteLine("\nEl contacto");

            if (contactos.Count > 0)
            {
                foreach (Contactos contacto in contactos)
                {
                    Console.WriteLine("\nNombre: {0}\nTeléfono: {1}\nEmail: {2}\nfue agregado con éxito.", contacto.Nombre, contacto.Telefono, contacto.Email);
                }
                Console.WriteLine("Contacto agregado con éxito.");
            }
            else
            {
                Console.WriteLine("no pudo ser agregado.");
            }
        }

        public void VerContacto(int orden)
        {
            List<Contactos> contactosNew = new List<Contactos>(contactos);

            if (contactosNew.Count > 0)
            {
                contactosNew.Sort(delegate (Contactos x, Contactos y) {
                    if (x.Nombre == null && y.Nombre == null) return 0;
                    else if (x.Nombre == null) return -1;
                    else if (y.Nombre == null) return 1;
                    else return x.Nombre.CompareTo(y.Nombre);
                });

                if (orden == 1)
                {
                    Console.WriteLine("*** Orden ascendente ***");

                    foreach (Contactos contacto in contactosNew)
                    {
                        Console.WriteLine("\nNombre: {0}\nTeléfono: {1}\nEmail: {2}", contacto.Nombre, contacto.Telefono, contacto.Email);
                    };
                }
                else if (orden == 2)
                {
                    Console.WriteLine("*** Orden descendente ***");
                    contactosNew.Reverse();
                    for (int i = 0; i < contactosNew.Count; i++)
                    {
                        Console.WriteLine("\nNombre: {0}\nTeléfono: {1}\nEmail: {2}", contactosNew[i].Nombre, contactosNew[i].Telefono, contactosNew[i].Email);
                    };
                }
            }
            else
            {
                Console.WriteLine("No existen contactos aún.");
            }

        }

        public void BorrarUltimoContacto()
        {
            contactos.Remove(contactos[contactos.Count - 1]);
        }

        public void Buscarcontacto(string nombre)
        {
            Console.WriteLine(contactos[0].Nombre.Contains(nombre));
            foreach (Contactos i in contactos)
            {
                if ((contactos[0].Nombre).ToLower() == nombre.ToLower())
                {
                    Console.WriteLine("\nNombre: {0}\nTeléfono: {1}\nEmail: {2}", i.Nombre, i.Telefono, i.Email);
                }
            };
        }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}", Nombre, Telefono, Email);
        }

        #endregion
    }
}
