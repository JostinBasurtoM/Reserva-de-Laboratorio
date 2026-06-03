using Reserva_laboratorio.Interfaces.Repositories;
using Reserva_laboratorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva_laboratorio.Repositories
{
    public class ProfesorRepository : IProfesorRepository
    {
        private static readonly List<Profesor> _profesores = new List<Profesor>();
        public ProfesorRepository()
        {
                _profesores.Add(new Profesor { Cedula = "0911111111", Nombre = "Ing. Azucena Hurtado", Materias = "Inteligencia de Negocio" });
                _profesores.Add(new Profesor { Cedula = "0922222222", Nombre = "Ing. Adrian Siavichay", Materias = "Programacion Orientada a Objectos" });
                _profesores.Add(new Profesor { Cedula = "0933333333", Nombre = "Ing. Diego Cedeno", Materias = "Desarrollo Web Avanzado" });
                _profesores.Add(new Profesor { Cedula = "0944444444", Nombre = "Ing. Jose Sanchez", Materias = "Desarrollo Web" });
                _profesores.Add(new Profesor { Cedula = "0955555555", Nombre = "Ing. Angel Zambrano", Materias = "Programacion Orientada a Eventos" });

        }
        public void Guardar(Profesor profesor)
        {
            _profesores.Add(profesor);
        }
        public List<Profesor> ObtenerProfesores()
        {
            return _profesores;
        }
    }
}
