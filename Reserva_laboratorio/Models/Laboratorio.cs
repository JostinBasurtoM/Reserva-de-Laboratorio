using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva_laboratorio.Models
{
    public class Laboratorio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public string Ubicacion { get; set; }
        public bool Disponibilidad { get; set; }
       
    }
}
