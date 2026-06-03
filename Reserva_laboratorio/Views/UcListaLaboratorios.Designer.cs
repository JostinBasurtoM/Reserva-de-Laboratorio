namespace Reserva_laboratorio.Views
{
    partial class UcListaLaboratorios
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
            components = new System.ComponentModel.Container();
            GroupLaboratorio = new GroupBox();
            btnEditar = new Button();
            btnEliminar = new Button();
            dataGridViewListaLaboratorio = new DataGridView();
            registroLaboratorioRepositoryBindingSource = new BindingSource(components);
            GroupLaboratorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaLaboratorio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)registroLaboratorioRepositoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // GroupLaboratorio
            // 
            GroupLaboratorio.Controls.Add(btnEditar);
            GroupLaboratorio.Controls.Add(btnEliminar);
            GroupLaboratorio.Controls.Add(dataGridViewListaLaboratorio);
            GroupLaboratorio.Location = new Point(34, 29);
            GroupLaboratorio.Name = "GroupLaboratorio";
            GroupLaboratorio.Size = new Size(901, 457);
            GroupLaboratorio.TabIndex = 0;
            GroupLaboratorio.TabStop = false;
            GroupLaboratorio.Text = "LABORATORIOS";
            GroupLaboratorio.Enter += GroupLaboratorio_Enter_1;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(163, 81);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(35, 81);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewListaLaboratorio
            // 
            dataGridViewListaLaboratorio.AutoGenerateColumns = false;
            dataGridViewListaLaboratorio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListaLaboratorio.DataSource = registroLaboratorioRepositoryBindingSource;
            dataGridViewListaLaboratorio.Location = new Point(35, 152);
            dataGridViewListaLaboratorio.Name = "dataGridViewListaLaboratorio";
            dataGridViewListaLaboratorio.RowHeadersWidth = 51;
            dataGridViewListaLaboratorio.Size = new Size(824, 234);
            dataGridViewListaLaboratorio.TabIndex = 0;
            // 
            // registroLaboratorioRepositoryBindingSource
            // 
            registroLaboratorioRepositoryBindingSource.DataSource = typeof(Repositories.RegistroLaboratorioRepository);
            // 
            // UcListaLaboratorios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GroupLaboratorio);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UcListaLaboratorios";
            Size = new Size(1008, 548);
            Load += UcListaLaboratorios_Load;
            GroupLaboratorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaLaboratorio).EndInit();
            ((System.ComponentModel.ISupportInitialize)registroLaboratorioRepositoryBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupLaboratorio;
        private DataGridView dataGridViewListaLaboratorio;
        private BindingSource registroLaboratorioRepositoryBindingSource;
        private Button btnEliminar;
        private Button btnEditar;
    }
}
