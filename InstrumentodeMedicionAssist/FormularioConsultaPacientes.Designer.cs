
namespace InstrumentodeMedicionAssist
{
    partial class FormularioConsultaPacientes
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
            this.components = new System.ComponentModel.Container();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.btnVerPaciente = new System.Windows.Forms.Button();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numeroIdentificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Regimen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.AutoGenerateColumns = false;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroIdentificacionDataGridViewTextBoxColumn,
            this.nombreCompletoDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.epsDataGridViewTextBoxColumn,
            this.Regimen});
            this.dgvPacientes.DataSource = this.pacienteBindingSource;
            this.dgvPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPacientes.Location = new System.Drawing.Point(0, 0);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.RowHeadersWidth = 51;
            this.dgvPacientes.RowTemplate.Height = 24;
            this.dgvPacientes.Size = new System.Drawing.Size(791, 433);
            this.dgvPacientes.TabIndex = 0;
            // 
            // btnVerPaciente
            // 
            this.btnVerPaciente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnVerPaciente.Location = new System.Drawing.Point(0, 385);
            this.btnVerPaciente.Name = "btnVerPaciente";
            this.btnVerPaciente.Size = new System.Drawing.Size(791, 48);
            this.btnVerPaciente.TabIndex = 1;
            this.btnVerPaciente.Text = "Ver Paciente";
            this.btnVerPaciente.UseVisualStyleBackColor = true;
            this.btnVerPaciente.Click += new System.EventHandler(this.btnVerPaciente_Click);
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataSource = typeof(Entidades.Paciente);
            // 
            // numeroIdentificacionDataGridViewTextBoxColumn
            // 
            this.numeroIdentificacionDataGridViewTextBoxColumn.DataPropertyName = "NumeroIdentificacion";
            this.numeroIdentificacionDataGridViewTextBoxColumn.HeaderText = "Número Identificación";
            this.numeroIdentificacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroIdentificacionDataGridViewTextBoxColumn.Name = "numeroIdentificacionDataGridViewTextBoxColumn";
            this.numeroIdentificacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroIdentificacionDataGridViewTextBoxColumn.Width = 175;
            // 
            // nombreCompletoDataGridViewTextBoxColumn
            // 
            this.nombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "NombreCompleto";
            this.nombreCompletoDataGridViewTextBoxColumn.HeaderText = "Nombre Completo";
            this.nombreCompletoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreCompletoDataGridViewTextBoxColumn.Name = "nombreCompletoDataGridViewTextBoxColumn";
            this.nombreCompletoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreCompletoDataGridViewTextBoxColumn.Width = 160;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha Nacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            this.fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaNacimientoDataGridViewTextBoxColumn.Width = 155;
            // 
            // epsDataGridViewTextBoxColumn
            // 
            this.epsDataGridViewTextBoxColumn.DataPropertyName = "Eps";
            this.epsDataGridViewTextBoxColumn.HeaderText = "Eps";
            this.epsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.epsDataGridViewTextBoxColumn.Name = "epsDataGridViewTextBoxColumn";
            this.epsDataGridViewTextBoxColumn.ReadOnly = true;
            this.epsDataGridViewTextBoxColumn.Width = 125;
            // 
            // Regimen
            // 
            this.Regimen.DataPropertyName = "Regimen";
            this.Regimen.HeaderText = "Regimen";
            this.Regimen.MinimumWidth = 6;
            this.Regimen.Name = "Regimen";
            this.Regimen.ReadOnly = true;
            this.Regimen.Width = 125;
            // 
            // FormularioConsultaPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 433);
            this.Controls.Add(this.btnVerPaciente);
            this.Controls.Add(this.dgvPacientes);
            this.Name = "FormularioConsultaPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Pacientes";
            this.Load += new System.EventHandler(this.FormularioConsultaPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private System.Windows.Forms.Button btnVerPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroIdentificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn epsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Regimen;
    }
}