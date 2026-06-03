namespace Reserva_laboratorio.Views
{
    partial class UcReservacion
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cmbProfesor = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cmbLaboratorio = new ComboBox();
            label4 = new Label();
            dtpFecha = new DateTimePicker();
            mtbHoraInicio = new MaskedTextBox();
            label5 = new Label();
            label6 = new Label();
            mtbHoraFin = new MaskedTextBox();
            btnReservar = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(197, 17);
            label1.Name = "label1";
            label1.Size = new Size(340, 37);
            label1.TabIndex = 0;
            label1.Text = "Reservacion de Laboratorio";
            label1.Click += label1_Click;
            // 
            // cmbProfesor
            // 
            cmbProfesor.FormattingEnabled = true;
            cmbProfesor.Location = new Point(325, 80);
            cmbProfesor.Name = "cmbProfesor";
            cmbProfesor.Size = new Size(121, 23);
            cmbProfesor.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(122, 78);
            label2.Name = "label2";
            label2.Size = new Size(155, 21);
            label2.TabIndex = 2;
            label2.Text = "Seleccionar Profesor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(100, 129);
            label3.Name = "label3";
            label3.Size = new Size(177, 21);
            label3.TabIndex = 3;
            label3.Text = "Seleccionar Laboratorio:";
            // 
            // cmbLaboratorio
            // 
            cmbLaboratorio.FormattingEnabled = true;
            cmbLaboratorio.Location = new Point(325, 129);
            cmbLaboratorio.Name = "cmbLaboratorio";
            cmbLaboratorio.Size = new Size(121, 23);
            cmbLaboratorio.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(224, 176);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 5;
            label4.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(325, 174);
            dtpFecha.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            dtpFecha.MinDate = new DateTime(2026, 6, 2, 0, 0, 0, 0);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(118, 23);
            dtpFecha.TabIndex = 6;
            // 
            // mtbHoraInicio
            // 
            mtbHoraInicio.Location = new Point(325, 217);
            mtbHoraInicio.Mask = "00:00";
            mtbHoraInicio.Name = "mtbHoraInicio";
            mtbHoraInicio.Size = new Size(100, 23);
            mtbHoraInicio.TabIndex = 7;
            mtbHoraInicio.ValidatingType = typeof(DateTime);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(211, 217);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 8;
            label5.Text = "Hora Inicio:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(224, 260);
            label6.Name = "label6";
            label6.Size = new Size(72, 21);
            label6.TabIndex = 9;
            label6.Text = "Hora Fin:";
            // 
            // mtbHoraFin
            // 
            mtbHoraFin.Location = new Point(325, 262);
            mtbHoraFin.Mask = "00:00";
            mtbHoraFin.Name = "mtbHoraFin";
            mtbHoraFin.Size = new Size(100, 23);
            mtbHoraFin.TabIndex = 10;
            mtbHoraFin.ValidatingType = typeof(DateTime);
            // 
            // btnReservar
            // 
            btnReservar.Location = new Point(224, 336);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(75, 23);
            btnReservar.TabIndex = 11;
            btnReservar.Text = "Reservar";
            btnReservar.UseVisualStyleBackColor = true;
            btnReservar.Click += btnReservar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(419, 336);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += button1_Click;
            // 
            // UcReservacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnLimpiar);
            Controls.Add(btnReservar);
            Controls.Add(mtbHoraFin);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(mtbHoraInicio);
            Controls.Add(dtpFecha);
            Controls.Add(label4);
            Controls.Add(cmbLaboratorio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbProfesor);
            Controls.Add(label1);
            Name = "UcReservacion";
            Size = new Size(702, 395);
            Load += UcReservacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbProfesor;
        private Label label2;
        private Label label3;
        private ComboBox cmbLaboratorio;
        private Label label4;
        private DateTimePicker dtpFecha;
        private MaskedTextBox mtbHoraInicio;
        private Label label5;
        private Label label6;
        private MaskedTextBox mtbHoraFin;
        private Button btnReservar;
        private Button btnLimpiar;
    }
}
