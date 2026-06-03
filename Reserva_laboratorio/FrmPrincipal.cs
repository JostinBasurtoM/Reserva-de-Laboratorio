using Reserva_laboratorio.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reserva_laboratorio.View
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            pctLogo.SizeMode = PictureBoxSizeMode.Zoom;

            try
            {
                string rutaImagen = Path.Combine(Application.StartupPath, "Assets", "Logo-UG-2016.png");

                if (File.Exists(rutaImagen))
                {
                    pctLogo.Image = System.Drawing.Image.FromFile(rutaImagen);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"No se pudo cargar el logo: {ex.Message}");
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            pnlContenido.Controls.Clear();

            UcListaLaboratorios vistaLista = new UcListaLaboratorios();

            vistaLista.Dock = DockStyle.Fill;
            pnlContenido.Controls.Add(vistaLista);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            pnlContenido.Controls.Clear();

            UcRegistroLaboratorio vistaRegistro = new UcRegistroLaboratorio();

            vistaRegistro.Dock = DockStyle.Fill;
            pnlContenido.Controls.Add(vistaRegistro);
        }

        private void btnReservacion_Click(object sender, EventArgs e)
        {
            pnlContenido.Controls.Clear();

            UcReservacion vistaReserva = new UcReservacion();

            vistaReserva.Dock = DockStyle.Fill;
            pnlContenido.Controls.Add(vistaReserva);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
