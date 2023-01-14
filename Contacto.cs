using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal
{
    class Contacto
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }   

        public Contacto() { }

        public Contacto(string nombre, string telefono, string email)
        {
            Nombre = nombre;
            Telefono = telefono;
            Email = email;
        }

        string[] contactos = { };

        #region metodos
        public void AgregarContacto()
        {
            string[] contactos = new string[] { Nombre, Telefono, Email };
            Console.WriteLine("El contacto\nNombre: {0}\nTeléfono: {1}\nEmail: {2}",Nombre,Telefono,Email);
            if (contactos.Length > 0)
            {
                Console.WriteLine("fue agregado con éxito.");
            } else
            {
                Console.WriteLine("no pudo ser agregado.");
            }
        }

        public void VerContacto()
        {
            if (contactos.Length > 0)
            {
                foreach (string i in contactos)
                {
                    Console.WriteLine(i);
                };
            } else {
                Console.WriteLine("No existen contactos aún.");
            }

        }

        public void BorrarUltimoContacto()
        {
            
            Console.WriteLine("Borrar contacto funciona");
        }

        public void Buscarcontacto()
        {
            Console.WriteLine("Buscar contacto funciona");
        }

        public void orden()
        {
            Console.WriteLine("orden funciona");
            // Array.Sort(Contactos);
        }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}", Nombre, Telefono, Email);
        }

        #endregion
    }
}
