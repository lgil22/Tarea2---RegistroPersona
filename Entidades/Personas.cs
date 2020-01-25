using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RegistroPersona.Entidades
{
    public class Personas
    {

        [Key]
        public int PersonaId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Personas()
        {
            PersonaId = 0;
            Nombre = string.Empty;
            Apellidos = string.Empty;
            Telefono = string.Empty;
            Cedula = string.Empty;
            Direccion = string.Empty;
            FechaNacimiento = DateTime.Now;
        }

        public Personas(int personaid, string nombre, string apellidos, string telefono, string cedula, string direccion, DateTime fechanacimiento)
        {
            PersonaId = personaid;
            Nombre = nombre;
            Apellidos = apellidos;
            Telefono = telefono;
            Cedula = cedula;
            Direccion = direccion;
            FechaNacimiento = fechanacimiento;
        }

    }
}



