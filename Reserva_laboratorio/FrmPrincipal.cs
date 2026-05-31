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
    }
}
