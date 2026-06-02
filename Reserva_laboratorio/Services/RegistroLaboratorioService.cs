using Reserva_laboratorio.Interfaces.Repositories;
using Reserva_laboratorio.Interfaces.Services;
using Reserva_laboratorio.Models;
using Reserva_laboratorio.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Reserva_laboratorio.Repositories.RegistroLaboratorioRepository;

namespace Reserva_laboratorio.Services
{
    public class RegistroLaboratorioService : IRegistroLaboratorioService
    {
        private readonly IRegistroLaboratorioRepository _laboratorioRepository;
        public RegistroLaboratorioService() {
            _laboratorioRepository = new RegistroLaboratorioRepository();
        }

        public async Task RegistrarLaboratorio(Laboratorio laboratorio)
        {
            if (string.IsNullOrWhiteSpace(laboratorio.Nombre))
            {
                throw new ArgumentException("El nombre del laboratorio es obligatorio.");
            }

            if (laboratorio.Capacidad <= 0)
            {
                throw new ArgumentException("La capacidad de estudiantes debe ser mayor a cero.");
            }

            if (string.IsNullOrWhiteSpace(laboratorio.Ubicacion))
            {
                throw new ArgumentException("Debe seleccionar una ubicación válida.");
            }

            bool existeNombre = _laboratorioRepository.ObtenerTodos()
                .Any(l => l.Nombre.Equals(laboratorio.Nombre, StringComparison.OrdinalIgnoreCase));

            if (existeNombre)
            {
                throw new InvalidOperationException($"Ya existe un laboratorio registrado con el nombre '{laboratorio.Nombre}'.");
            }

            _laboratorioRepository.Guardar(laboratorio);

            await Task.CompletedTask;
        }
        public List<Laboratorio> ObtenerTodosLosLaboratorios()
        {
            return _laboratorioRepository.ObtenerTodos();
        }
    }
}
