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
    public class ProfesorService : IProfesorService
    {
        private readonly IProfesorRepository _profesorRepository;

        public ProfesorService(IProfesorRepository profesorRepository)
        {
            _profesorRepository = profesorRepository;
        }

        public List<Profesor> ObtenerProfesores()
        {
            return _profesorRepository.ObtenerProfesores();
        }
        public async Task RegistrarProfesor(Profesor profesor)
        {
            if (string.IsNullOrWhiteSpace(profesor.Cedula))
            {
                throw new ArgumentException("La cédula del profesor es obligatoria.");
            }

            if (profesor.Cedula.Length < 10) 
            {
                throw new ArgumentException("La cédula debe tener al menos 10 dígitos.");
            }

            if (string.IsNullOrWhiteSpace(profesor.Nombre))
            {
                throw new ArgumentException("El nombre del profesor es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(profesor.Materias))
            {
                throw new ArgumentException("Debe especificar la facultad o carrera del profesor.");
            }

            bool existeCedula = _profesorRepository.ObtenerProfesores()
                .Any(p => p.Cedula.Equals(profesor.Cedula.Trim()));

            if (existeCedula)
            {
                throw new InvalidOperationException($"Ya existe un profesor registrado con la cédula '{profesor.Cedula}'.");
            }

            _profesorRepository.Guardar(profesor);

            await Task.CompletedTask;
        }
    }
}
