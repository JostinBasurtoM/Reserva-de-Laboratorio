using Reserva_laboratorio.Interfaces.Services;
using Reserva_laboratorio.Models;
using Reserva_laboratorio.Repositories;
using Reserva_laboratorio.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reserva_laboratorio.Views
{
    public partial class UcReservacion : UserControl
    {
        private readonly IReservacionService _reservacionService;
        private readonly IRegistroLaboratorioService _laboratorioService;
        private readonly IProfesorService _profesorService;
        public UcReservacion()
        {
            InitializeComponent();
            var reservacionRepo = new RegistroLaboratorioRepository(); 
            var profesorRepo = new ProfesorRepository();
            var historialRepo = new ReservacionRepository();

            _laboratorioService = new RegistroLaboratorioService(); 
            _profesorService = new ProfesorService(profesorRepo);

            _reservacionService = new ReservacionService(historialRepo, reservacionRepo);

            ConfigurarControlesIniciales();
            CargarCombos();
        }
        private void ConfigurarControlesIniciales()
        {
            dtpFecha.Format = DateTimePickerFormat.Short;

            mtbHoraInicio.Clear();
            mtbHoraFin.Clear();
        }
        private void CargarCombos()
        {
            try
            {
                var profesores = _profesorService.ObtenerProfesores();
                cmbProfesor.DataSource = null;
                cmbProfesor.DataSource = profesores;
                cmbProfesor.DisplayMember = "Nombre";
                cmbProfesor.SelectedIndex = -1;

                var laboratoriosDisponibles = _laboratorioService.ObtenerTodosLosLaboratorios()
                    .Where(l => l.Disponibilidad == true)
                    .ToList();

                cmbLaboratorio.DataSource = null;
                cmbLaboratorio.DataSource = laboratoriosDisponibles;
                cmbLaboratorio.DisplayMember = "Nombre";
                cmbLaboratorio.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos en los selectores: {ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void UcReservacion_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            cmbProfesor.SelectedIndex = -1;
            cmbLaboratorio.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
            mtbHoraInicio.Clear();
            mtbHoraFin.Clear();
        }
        private async void btnReservar_Click(object sender, EventArgs e)
        {
            try
            {
              
                var nuevaReservacion = new Reservacion
                {
                    ProfesorSolicitante = cmbProfesor.SelectedItem as Profesor,
                    LaboratorioSeleccionado = cmbLaboratorio.SelectedItem as Laboratorio,
                    Fecha = dtpFecha.Value.Date,
                    HoraInicio = mtbHoraInicio.Text.Trim(),
                    HoraFin = mtbHoraFin.Text.Trim()
                };

                await _reservacionService.Reservar(nuevaReservacion);

                MessageBox.Show("¡Laboratorio reservado de forma exitosa!", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarCombos();
                LimpiarFormulario();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Conflicto de Horario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
