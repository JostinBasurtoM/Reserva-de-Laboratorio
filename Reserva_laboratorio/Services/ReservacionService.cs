using Reserva_laboratorio.Interfaces.Repositories;
using Reserva_laboratorio.Interfaces.Services;
using Reserva_laboratorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva_laboratorio.Services
{
    public class ReservacionService : IReservacionService
    {
        private readonly IReservacionRepository _reservacionRepository;
        private readonly IRegistroLaboratorioRepository _laboratorioRepository;


        public ReservacionService(
            IReservacionRepository reservacionRepository,
            IRegistroLaboratorioRepository laboratorioRepository)
        {
            _reservacionRepository = reservacionRepository;
            _laboratorioRepository = laboratorioRepository;
        }

        public List<Reservacion> ObtenerHistorialReservas()
        {
            return _reservacionRepository.ObtenerTodas();
        }

        public async Task Reservar(Reservacion reservacion)
        {
            if (reservacion.LaboratorioSeleccionado == null || string.IsNullOrWhiteSpace(reservacion.LaboratorioSeleccionado.Nombre))
            {
                throw new ArgumentException("Debe seleccionar un laboratorio válido para reservar.");
            }

            if (reservacion.ProfesorSolicitante == null || string.IsNullOrWhiteSpace(reservacion.ProfesorSolicitante.Cedula))
            {
                throw new ArgumentException("Debe seleccionar un profesor válido para la reserva.");
            }

            if (string.IsNullOrWhiteSpace(reservacion.HoraInicio) || string.IsNullOrWhiteSpace(reservacion.HoraFin))
            {
                throw new ArgumentException("Los rangos de hora de inicio y fin son obligatorios.");
            }

            if (string.Compare(reservacion.HoraInicio, reservacion.HoraFin) >= 0)
            {
                throw new ArgumentException("La hora de fin debe ser mayor a la hora de inicio.");
            }
            bool laboratorioOcupado = _reservacionRepository.ObtenerTodas().Any(r =>
                r.LaboratorioSeleccionado.Nombre.Equals(reservacion.LaboratorioSeleccionado.Nombre, StringComparison.OrdinalIgnoreCase) &&
                r.Fecha.Date == reservacion.Fecha.Date &&
                ((string.Compare(reservacion.HoraInicio, r.HoraInicio) >= 0 && string.Compare(reservacion.HoraInicio, r.HoraFin) < 0) ||
                 (string.Compare(reservacion.HoraFin, r.HoraInicio) > 0 && string.Compare(reservacion.HoraFin, r.HoraFin) <= 0)));

            if (laboratorioOcupado)
            {
                throw new InvalidOperationException($"El laboratorio '{reservacion.LaboratorioSeleccionado.Nombre}' ya se encuentra reservado en ese rango de horario.");
            }

            _reservacionRepository.Guardar(reservacion);


            var labMaestro = _laboratorioRepository.ObtenerTodos()
                .FirstOrDefault(l => l.Nombre.Equals(reservacion.LaboratorioSeleccionado.Nombre, StringComparison.OrdinalIgnoreCase));

            if (labMaestro != null)
            {
                labMaestro.Disponibilidad = false;
            }

            await Task.CompletedTask;
        }
    }
}


