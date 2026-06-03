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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            pnlContenedor = new Panel();
            button3 = new Button();
            btn_registro = new Button();
            btn_lista = new Button();
            pnlContenido = new Panel();
            pctLogo = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pnlContenedor.SuspendLayout();
            pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctLogo).BeginInit();
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
            pnlContenido.Controls.Add(pctLogo);
            pnlContenido.Controls.Add(label2);
            pnlContenido.Controls.Add(label1);
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(0, 27);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(800, 423);
            pnlContenido.TabIndex = 1;
            // 
            // pctLogo
            // 
            pctLogo.Location = new Point(482, 112);
            pctLogo.Name = "pctLogo";
            pctLogo.Size = new Size(212, 173);
            pctLogo.TabIndex = 2;
            pctLogo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(171, 34);
            label2.Name = "label2";
            label2.Size = new Size(455, 32);
            label2.TabIndex = 1;
            label2.Text = "SISTEMA DE RESERVA DE LABORATORIOS";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(56, 112);
            label1.Name = "label1";
            label1.Size = new Size(328, 173);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            label1.Click += label1_Click;
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
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContenedor;
        private Button button3;
        private Button btn_registro;
        private Button btn_lista;
        private Panel pnlContenido;
        private Label label1;
        private Label label2;
        private PictureBox pctLogo;
    }
}