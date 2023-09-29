using System;
using Microsoft.EntityFrameworkCore;
namespace PC1AbantoFreyre.Database
{
    public class AlumnosEntity
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public int Celular { get; set; }
        public string NombreContacto { get; set; }
        public int TelefonoContacto { get; set; }
        public string Estado { get; set; }
    }
}
