namespace Reserva_laboratorio.View
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlContenedor = new Panel();
            button3 = new Button();
            btn_registro = new Button();
            btn_lista = new Button();
            pnlContenido = new Panel();
            pnlContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContenedor
            // 
            pnlContenedor.Controls.Add(button3);
            pnlContenedor.Controls.Add(btn_registro);
            pnlContenedor.Controls.Add(btn_lista);
            pnlContenedor.Dock = DockStyle.Top;
            pnlContenedor.Location = new Point(0, 0);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(800, 27);
            pnlContenedor.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(207, 4);
            button3.Name = "button3";
            button3.Size = new Size(80, 23);
            button3.TabIndex = 2;
            button3.Text = "Reservación";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnReservacion_Click;
            // 
            // btn_registro
            // 
            btn_registro.Location = new Point(111, 3);
            btn_registro.Name = "btn_registro";
            btn_registro.Size = new Size(75, 23);
            btn_registro.TabIndex = 1;
            btn_registro.Text = "Registro";
            btn_registro.UseVisualStyleBackColor = true;
            btn_registro.Click += btnRegistro_Click;
            // 
            // btn_lista
            // 
            btn_lista.Location = new Point(19, 3);
            btn_lista.Name = "btn_lista";
            btn_lista.Size = new Size(75, 23);
            btn_lista.TabIndex = 0;
            btn_lista.Text = "Lista";
            btn_lista.UseVisualStyleBackColor = true;
            btn_lista.Click += btnLista_Click;
            // 
            // pnlContenido
            // 
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(0, 27);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(800, 423);
            pnlContenido.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlContenido);
            Controls.Add(pnlContenedor);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            pnlContenedor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContenedor;
        private Button button3;
        private Button btn_registro;
        private Button btn_lista;
        private Panel pnlContenido;
    }
}