using Reserva_laboratorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva_laboratorio.Interfaces.Services
{
    public interface IReservacionService
    {
        Task Reservar(Reservacion reservacion);
    }
}
