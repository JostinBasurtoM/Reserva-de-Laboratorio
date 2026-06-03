using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva_laboratorio.Models
{
    public class Reservacion
    {
        public Guid Id { get; set; } 
        public Laboratorio LaboratorioSeleccionado { get; set; }
        public Profesor ProfesorSolicitante { get; set; }
        public DateTime Fecha { get; set; }
        public string HoraInicio { get; set; } 
        public string HoraFin { get; set; }
    }
}
