using Reserva_laboratorio.Interfaces.Services;
using Reserva_laboratorio.Models;
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
    public partial class UcRegistroLaboratorio : UserControl
    {
        private readonly IRegistroLaboratorioService _laboratorioService;
        public UcRegistroLaboratorio()
        {
            InitializeComponent();
            _laboratorioService = new RegistroLaboratorioService();
            CargarUbicaciones();
        }
        private void CargarUbicaciones()
        {
            // Limpiamos por si acaso
            cmbUbicacion.Items.Clear();

            // Agrega aquí los bloques o aulas normadas de tu universidad
            string[] ubicacionesNormadas = {
        "Bloque 1 - Planta Alta",
        "Bloque 1 - Planta Baja",
        "Bloque 2 - Laboratorios Computo",
        "Bloque Redes",
        "Edificio Central - Aula Magna"
    };

            // Los inyectamos al ComboBox
            cmbUbicacion.Items.AddRange(ubicacionesNormadas);

            // Opcional: dejamos seleccionado ninguno por defecto
            cmbUbicacion.SelectedIndex = -1;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Laboratorio nuevoLaboratorio = new Laboratorio
                {
                    Nombre = txtNombreLaboratorio.Text.Trim(),

                    Capacidad = (int)nudCapacidad.Value,

                    Ubicacion = cmbUbicacion.SelectedItem?.ToString() ?? string.Empty,

                    Disponibilidad = true
                };

                _laboratorioService.RegistrarLaboratorio(nuevoLaboratorio);

                MessageBox.Show("Laboratorio registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error de Duplicidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            txtNombreLaboratorio.Clear();
            nudCapacidad.Value = 1;
            cmbUbicacion.SelectedIndex = -1;
        }


        private void txtNombreLaboratorio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

