using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PC1AbantoFreyre.Models
{
    public class AlumnosListViewModel
    {
        public List<AlumnosViewModel> List { get; set; }

        public AlumnosListViewModel()
        {
            List = new List<AlumnosViewModel>();
        }
    }

    public class AlumnosViewModel
    {
        public int ID { get; set; }
        public int? DNI { get; set; }
        public string Estado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public int? Celular { get; set; }
        public string NombreContacto { get; set; }
        public int? TelefonoContacto { get; set; }
    }
}
