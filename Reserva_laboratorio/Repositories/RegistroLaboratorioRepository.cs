using Reserva_laboratorio.Interfaces.Repositories;
using Reserva_laboratorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Reserva_laboratorio.Repositories.RegistroLaboratorioRepository;

namespace Reserva_laboratorio.Repositories
{
    public class RegistroLaboratorioRepository : IRegistroLaboratorioRepository
    {
        
            private static readonly List<Laboratorio> _laboratorios = new List<Laboratorio>();

            public void Guardar(Laboratorio laboratorio)
            {
                _laboratorios.Add(laboratorio);
            }

            public List<Laboratorio> ObtenerTodos()
            {
                return _laboratorios;
            }
        }
    }

