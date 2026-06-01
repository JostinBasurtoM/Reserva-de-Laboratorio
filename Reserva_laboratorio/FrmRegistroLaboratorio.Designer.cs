namespace Reserva_laboratorio
{
    partial class FrmRegistroLaboratorio
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombreLaboratorio = new TextBox();
            nudCapacidad = new NumericUpDown();
            chkActivo = new CheckBox();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            label6 = new Label();
            dgvLaboratorios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLaboratorios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 9);
            label1.Name = "label1";
            label1.Size = new Size(208, 20);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO DE LABORATORIOS";
            label1.Click += this.label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 33);
            label2.Name = "label2";
            label2.Size = new Size(155, 20);
            label2.TabIndex = 1;
            label2.Text = "Datos del Laboratorio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 71);
            label3.Name = "label3";
            label3.Size = new Size(174, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre del Laboratorio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 101);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 3;
            label4.Text = "Capacidad:";
            label4.Click += this.label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 130);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 4;
            label5.Text = "Estado:";
            label5.Click += this.label5_Click;
            // 
            // txtNombreLaboratorio
            // 
            txtNombreLaboratorio.Location = new Point(192, 66);
            txtNombreLaboratorio.Name = "txtNombreLaboratorio";
            txtNombreLaboratorio.Size = new Size(245, 27);
            txtNombreLaboratorio.TabIndex = 5;
            // 
            // nudCapacidad
            // 
            nudCapacidad.Location = new Point(101, 99);
            nudCapacidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCapacidad.Name = "nudCapacidad";
            nudCapacidad.Size = new Size(94, 27);
            nudCapacidad.TabIndex = 6;
            nudCapacidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Checked = true;
            chkActivo.CheckState = CheckState.Checked;
            chkActivo.Location = new Point(75, 129);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(73, 24);
            chkActivo.TabIndex = 7;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(183, 175);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(283, 175);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(383, 175);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(483, 175);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(300, 228);
            label6.Name = "label6";
            label6.Size = new Size(214, 20);
            label6.TabIndex = 12;
            label6.Text = "LABORATORIOS REGISTRADOS";
            // 
            // dgvLaboratorios
            // 
            dgvLaboratorios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaboratorios.Location = new Point(28, 267);
            dgvLaboratorios.Name = "dgvLaboratorios";
            dgvLaboratorios.RowHeadersWidth = 51;
            dgvLaboratorios.Size = new Size(752, 150);
            dgvLaboratorios.TabIndex = 13;
            // 
            // FrmRegistroLaboratorio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvLaboratorios);
            Controls.Add(label6);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(chkActivo);
            Controls.Add(nudCapacidad);
            Controls.Add(txtNombreLaboratorio);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegistroLaboratorio";
            Text = "Registro de Laboratorio";
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLaboratorios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombreLaboratorio;
        private NumericUpDown nudCapacidad;
        private CheckBox chkActivo;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Label label6;
        private DataGridView dgvLaboratorios;
    }
}