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
        private Laboratorio laboratorioEditando;
        private bool esEdicion = false;
        private readonly IRegistroLaboratorioService _laboratorioService;
        public event Action OnLaboratorioGuardado;
        public UcRegistroLaboratorio()
        {
            InitializeComponent();
            _laboratorioService = new RegistroLaboratorioService();
            CargarUbicaciones();
            btnLimpiar.Click += btnLimpiar_Click;
        }

        public UcRegistroLaboratorio(Laboratorio lab)
        {
            InitializeComponent();
            _laboratorioService = new RegistroLaboratorioService();
            CargarUbicaciones();
            laboratorioEditando = lab;
            esEdicion = true;


            txtNombreLaboratorio.Text = lab.Nombre;
            nudCapacidad.Value = lab.Capacidad;
            cmbUbicacion.SelectedItem = lab.Ubicacion;
        }
        private void CargarUbicaciones()
        {
      
            cmbUbicacion.Items.Clear();

       
            string[] ubicacionesNormadas = {
        "Bloque 1 - Planta Alta",
        "Bloque 1 - Planta Baja",
        "Bloque 2 - Laboratorios Computo",
        "Bloque Redes",
        "Edificio Central - Aula Magna"
    };

      
            cmbUbicacion.Items.AddRange(ubicacionesNormadas);

     
            cmbUbicacion.SelectedIndex = -1;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (esEdicion && laboratorioEditando != null)
                {
                   
                    laboratorioEditando.Nombre = txtNombreLaboratorio.Text.Trim();
                    laboratorioEditando.Capacidad = (int)nudCapacidad.Value;
                    laboratorioEditando.Ubicacion = cmbUbicacion.SelectedItem?.ToString() ?? string.Empty;

                    await _laboratorioService.ActualizarLaboratorio(laboratorioEditando);

                    MessageBox.Show("Laboratorio actualizado correctamente",

                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ParentForm.Close();
                    OnLaboratorioGuardado?.Invoke();
                }
                else
                {
              
                    Laboratorio nuevoLaboratorio = new Laboratorio
                    {
                        Nombre = txtNombreLaboratorio.Text.Trim(),
                        Capacidad = (int)nudCapacidad.Value,
                        Ubicacion = cmbUbicacion.SelectedItem?.ToString() ?? string.Empty,
                        Disponibilidad = true
                    };

                    await _laboratorioService.RegistrarLaboratorio(nuevoLaboratorio);

                    MessageBox.Show("Laboratorio registrado exitosamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LimpiarFormulario();

              
                esEdicion = false;
                laboratorioEditando = null;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Datos Incompletos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error de Duplicidad",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}",
                    "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            txtNombreLaboratorio.Clear();
            nudCapacidad.Value = 1;
            cmbUbicacion.SelectedIndex = -1;

            esEdicion = false;
            laboratorioEditando = null;
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

        private void UcRegistroLaboratorio_Load(object sender, EventArgs e)
        {

        }

        private void UcRegistroLaboratorio_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void UcRegistroLaboratorio_Load_2(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}

