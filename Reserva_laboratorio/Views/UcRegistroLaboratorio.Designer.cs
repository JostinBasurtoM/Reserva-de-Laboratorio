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
            btnGuardar = new Button();
            nudCapacidad = new NumericUpDown();
            txtNombreLaboratorio = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtUbicacion = new Label();
            cmbUbicacion = new ComboBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(325, 291);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 39;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(158, 291);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 36;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // nudCapacidad
            // 
            nudCapacidad.Location = new Point(213, 137);
            nudCapacidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCapacidad.Name = "nudCapacidad";
            nudCapacidad.Size = new Size(94, 27);
            nudCapacidad.TabIndex = 34;
            nudCapacidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtNombreLaboratorio
            // 
            txtNombreLaboratorio.Location = new Point(213, 91);
            txtNombreLaboratorio.Name = "txtNombreLaboratorio";
            txtNombreLaboratorio.Size = new Size(245, 27);
            txtNombreLaboratorio.TabIndex = 33;
            txtNombreLaboratorio.TextChanged += txtNombreLaboratorio_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(109, 139);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 31;
            label4.Text = "Capacidad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 94);
            label3.Name = "label3";
            label3.Size = new Size(174, 20);
            label3.TabIndex = 30;
            label3.Text = "Nombre del Laboratorio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 49);
            label2.Name = "label2";
            label2.Size = new Size(155, 20);
            label2.TabIndex = 29;
            label2.Text = "Datos del Laboratorio";
            // 
            // txtUbicacion
            // 
            txtUbicacion.AutoSize = true;
            txtUbicacion.Location = new Point(114, 195);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(78, 20);
            txtUbicacion.TabIndex = 42;
            txtUbicacion.Text = "Ubicacion:";
            txtUbicacion.Click += label5_Click;
            // 
            // cmbUbicacion
            // 
            cmbUbicacion.FormattingEnabled = true;
            cmbUbicacion.Location = new Point(213, 195);
            cmbUbicacion.Margin = new Padding(3, 4, 3, 4);
            cmbUbicacion.Name = "cmbUbicacion";
            cmbUbicacion.Size = new Size(138, 28);
            cmbUbicacion.TabIndex = 43;
            cmbUbicacion.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(cmbUbicacion);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtUbicacion);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(txtNombreLaboratorio);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(nudCapacidad);
            groupBox1.Location = new Point(12, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(586, 385);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
            groupBox1.Text = "REGISTRO DE LABORATORIOS";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // UcRegistroLaboratorio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UcRegistroLaboratorio";
            Size = new Size(603, 404);
            Load += UcRegistroLaboratorio_Load_2;
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnLimpiar;
        private Button btnGuardar;
        private NumericUpDown nudCapacidad;
        private TextBox txtNombreLaboratorio;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label txtUbicacion;
        private ComboBox cmbUbicacion;
        private GroupBox groupBox1;




    }
}
