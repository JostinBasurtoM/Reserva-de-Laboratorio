using System;
using System.Windows.Forms;
using Reserva_laboratorio.Interfaces.Services;
using Reserva_laboratorio.Services;
using Reserva_laboratorio.Models;

namespace Reserva_laboratorio.Views
{
    public partial class UcListaLaboratorios : UserControl
    {
        private readonly IRegistroLaboratorioService _service;
        private Laboratorio laboratorioSeleccionado;

        public UcListaLaboratorios()
        {
            InitializeComponent();
            _service = new RegistroLaboratorioService();


            btnEliminar.Click += btnEliminar_Click;
            btnEditar.Click += btnEditar_Click;

            dataGridViewListaLaboratorio.CellClick += dataGridViewListaLaboratorio_CellClick;
        }

        private void UcListaLaboratorios_Load(object sender, EventArgs e)
        {
            CargarLaboratorios();
        }

        private void CargarLaboratorios()
        {
            dataGridViewListaLaboratorio.DataSource = null;
            dataGridViewListaLaboratorio.DataSource = _service.ObtenerTodosLosLaboratorios();

            dataGridViewListaLaboratorio.AutoGenerateColumns = true;
            dataGridViewListaLaboratorio.ReadOnly = true;
            dataGridViewListaLaboratorio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void dataGridViewListaLaboratorio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                laboratorioSeleccionado =
                    (Laboratorio)dataGridViewListaLaboratorio.Rows[e.RowIndex].DataBoundItem;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (laboratorioSeleccionado == null)
            {
                MessageBox.Show("Selecciona un laboratorio");
                return;
            }

            UcRegistroLaboratorio uc = new UcRegistroLaboratorio(laboratorioSeleccionado);

            // 🔥 ESTO ES LO CORRECTO
            uc.Dock = DockStyle.Fill;

            Form contenedor = new Form();
            contenedor.Text = "Editar Laboratorio";
            contenedor.StartPosition = FormStartPosition.CenterScreen;
            contenedor.Size = new Size(650, 500); // tamaño fijo bonito
            contenedor.FormBorderStyle = FormBorderStyle.FixedDialog;
            contenedor.MaximizeBox = false;

            contenedor.Controls.Add(uc);

            uc.OnLaboratorioGuardado += CargarLaboratorios;

            contenedor.ShowDialog();
        }


        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (laboratorioSeleccionado == null)
            {
                MessageBox.Show("Selecciona un laboratorio");
                return;
            }

            var confirm = MessageBox.Show(
                "¿Seguro que deseas eliminar este laboratorio?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                await _service.EliminarLaboratorio(laboratorioSeleccionado.Id);

                MessageBox.Show("Eliminado correctamente");

                CargarLaboratorios();
                laboratorioSeleccionado = null;
            }
        }

        private void GroupLaboratorio_Enter_1(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {

        }
    }
}