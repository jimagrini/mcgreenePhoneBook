using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact friend = new Contact("George");//ocp y creator?
            Contact owner = new Contact("Juan");
            Phonebook phBook= new Phonebook(owner);
            phBook.Add(friend);
 
            // Crear el contacto dueño

            // Crear la lista de contactos

            // Agregar contactos a la lista

            // Enviar un correo a algunos contactos

            // Enviar un WhatsApp a algunos contactos

            // Enviar un SMS a algunos contactos
        }
    }
}
