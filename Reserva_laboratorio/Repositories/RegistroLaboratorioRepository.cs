using Reserva_laboratorio.Interfaces.Repositories;
using Reserva_laboratorio.Models;
using System.Collections.Generic;
using System.Linq;

namespace Reserva_laboratorio.Repositories
{
    public class RegistroLaboratorioRepository : IRegistroLaboratorioRepository
    {
        private static readonly List<Laboratorio> _laboratorios = new List<Laboratorio>();
        private static int _nextId = 1;

        public void Guardar(Laboratorio laboratorio)
        {
            laboratorio.Id = _nextId++;
            _laboratorios.Add(laboratorio);
        }

        public List<Laboratorio> ObtenerTodos()
        {
            return _laboratorios;
        }

        public void Actualizar(Laboratorio laboratorio)
        {
            var labExistente = _laboratorios.FirstOrDefault(x => x.Id == laboratorio.Id);

            if (labExistente != null)
            {
                labExistente.Nombre = laboratorio.Nombre;
                labExistente.Capacidad = laboratorio.Capacidad;
                labExistente.Disponibilidad = laboratorio.Disponibilidad;
            }
        }

        public void Eliminar(int id)
        {
            var labExistente = _laboratorios.FirstOrDefault(x => x.Id == id);

            if (labExistente != null)
            {
                _laboratorios.Remove(labExistente);
            }
        }
    }
}