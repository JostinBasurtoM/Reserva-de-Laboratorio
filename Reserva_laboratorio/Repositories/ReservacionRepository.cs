using Reserva_laboratorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva_laboratorio.Repositories
{
    public class ReservacionRepository
    {
            private static readonly List<Reservacion> _reservaciones = new List<Reservacion>();
    
            public void Guardar(Reservacion reservacion)
            {
                _reservaciones.Add(reservacion);
            }

            public List<Reservacion> ObtenerTodas()
            {
                return _reservaciones;
            }

    }
}
