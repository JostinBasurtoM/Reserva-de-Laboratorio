namespace Reserva_laboratorio.Views
{
    partial class UcRegistroLaboratorio
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
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            nudCapacidad = new NumericUpDown();
            txtNombreLaboratorio = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtUbicacion = new Label();
            cmbUbicacion = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).BeginInit();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(443, 194);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(82, 22);
            btnLimpiar.TabIndex = 39;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(355, 194);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 22);
            btnEliminar.TabIndex = 38;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(268, 194);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(82, 22);
            btnEditar.TabIndex = 37;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(180, 194);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 22);
            btnGuardar.TabIndex = 36;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // nudCapacidad
            // 
            nudCapacidad.Location = new Point(134, 110);
            nudCapacidad.Margin = new Padding(3, 2, 3, 2);
            nudCapacidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCapacidad.Name = "nudCapacidad";
            nudCapacidad.Size = new Size(82, 23);
            nudCapacidad.TabIndex = 34;
            nudCapacidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtNombreLaboratorio
            // 
            txtNombreLaboratorio.Location = new Point(202, 83);
            txtNombreLaboratorio.Margin = new Padding(3, 2, 3, 2);
            txtNombreLaboratorio.Name = "txtNombreLaboratorio";
            txtNombreLaboratorio.Size = new Size(215, 23);
            txtNombreLaboratorio.TabIndex = 33;
            txtNombreLaboratorio.TextChanged += txtNombreLaboratorio_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 112);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 31;
            label4.Text = "Capacidad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 86);
            label3.Name = "label3";
            label3.Size = new Size(137, 15);
            label3.TabIndex = 30;
            label3.Text = "Nombre del Laboratorio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 58);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 29;
            label2.Text = "Datos del Laboratorio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(291, 32);
            label1.Name = "label1";
            label1.Size = new Size(162, 15);
            label1.TabIndex = 28;
            label1.Text = "REGISTRO DE LABORATORIOS";
            // 
            // txtUbicacion
            // 
            txtUbicacion.AutoSize = true;
            txtUbicacion.Location = new Point(48, 147);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(63, 15);
            txtUbicacion.TabIndex = 42;
            txtUbicacion.Text = "Ubicacion:";
            txtUbicacion.Click += label5_Click;
            // 
            // cmbUbicacion
            // 
            cmbUbicacion.FormattingEnabled = true;
            cmbUbicacion.Location = new Point(134, 147);
            cmbUbicacion.Name = "cmbUbicacion";
            cmbUbicacion.Size = new Size(121, 23);
            cmbUbicacion.TabIndex = 43;
            cmbUbicacion.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // UcRegistroLaboratorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cmbUbicacion);
            Controls.Add(txtUbicacion);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(nudCapacidad);
            Controls.Add(txtNombreLaboratorio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UcRegistroLaboratorio";
            Size = new Size(761, 396);
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
        private NumericUpDown nudCapacidad;
        private TextBox txtNombreLaboratorio;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label txtUbicacion;
        private ComboBox cmbUbicacion;
    }
}
