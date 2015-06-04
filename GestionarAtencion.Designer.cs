namespace IMC
{
    partial class GestionarAtencion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Nac = new System.Windows.Forms.DateTimePicker();
            this.paciente = new System.Windows.Forms.ComboBox();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medico = new System.Windows.Forms.ComboBox();
            this.medicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.TextBox();
            this.peso = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.atencionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agregar = new System.Windows.Forms.Button();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atencionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Nac);
            this.groupBox1.Controls.Add(this.paciente);
            this.groupBox1.Controls.Add(this.medico);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.altura);
            this.groupBox1.Controls.Add(this.peso);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 202);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "KG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "m";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nac.";
            // 
            // Nac
            // 
            this.Nac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Nac.Location = new System.Drawing.Point(97, 88);
            this.Nac.Name = "Nac";
            this.Nac.Size = new System.Drawing.Size(200, 20);
            this.Nac.TabIndex = 20;
            // 
            // paciente
            // 
            this.paciente.DataSource = this.pacienteBindingSource;
            this.paciente.DisplayMember = "Nombre";
            this.paciente.FormattingEnabled = true;
            this.paciente.Location = new System.Drawing.Point(97, 59);
            this.paciente.Name = "paciente";
            this.paciente.Size = new System.Drawing.Size(121, 21);
            this.paciente.TabIndex = 19;
            this.paciente.ValueMember = "Nombre";
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataSource = typeof(IMC.Paciente);
            // 
            // medico
            // 
            this.medico.DataSource = this.medicoBindingSource;
            this.medico.DisplayMember = "Nombre";
            this.medico.FormattingEnabled = true;
            this.medico.Location = new System.Drawing.Point(97, 32);
            this.medico.Name = "medico";
            this.medico.Size = new System.Drawing.Size(121, 21);
            this.medico.TabIndex = 18;
            this.medico.ValueMember = "Nombre";
            // 
            // medicoBindingSource
            // 
            this.medicoBindingSource.DataSource = typeof(IMC.Medico);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Peso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Medico";
            // 
            // altura
            // 
            this.altura.Location = new System.Drawing.Point(97, 145);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(100, 20);
            this.altura.TabIndex = 13;
            // 
            // peso
            // 
            this.peso.Location = new System.Drawing.Point(97, 114);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(100, 20);
            this.peso.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn,
            this.nombrePacienteDataGridViewTextBoxColumn,
            this.pesoDataGridViewTextBoxColumn,
            this.estaturaDataGridViewTextBoxColumn,
            this.iMCDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.atencionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(552, 154);
            this.dataGridView1.TabIndex = 11;
            // 
            // atencionBindingSource
            // 
            this.atencionBindingSource.DataSource = typeof(IMC.DisplayAtencion);
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(12, 232);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 37);
            this.agregar.TabIndex = 12;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // nombrePacienteDataGridViewTextBoxColumn
            // 
            this.nombrePacienteDataGridViewTextBoxColumn.DataPropertyName = "NombrePaciente";
            this.nombrePacienteDataGridViewTextBoxColumn.HeaderText = "NombrePaciente";
            this.nombrePacienteDataGridViewTextBoxColumn.Name = "nombrePacienteDataGridViewTextBoxColumn";
            // 
            // pesoDataGridViewTextBoxColumn
            // 
            this.pesoDataGridViewTextBoxColumn.DataPropertyName = "Peso";
            this.pesoDataGridViewTextBoxColumn.HeaderText = "Peso";
            this.pesoDataGridViewTextBoxColumn.Name = "pesoDataGridViewTextBoxColumn";
            // 
            // estaturaDataGridViewTextBoxColumn
            // 
            this.estaturaDataGridViewTextBoxColumn.DataPropertyName = "Estatura";
            this.estaturaDataGridViewTextBoxColumn.HeaderText = "Estatura";
            this.estaturaDataGridViewTextBoxColumn.Name = "estaturaDataGridViewTextBoxColumn";
            // 
            // iMCDataGridViewTextBoxColumn
            // 
            this.iMCDataGridViewTextBoxColumn.DataPropertyName = "IMC";
            this.iMCDataGridViewTextBoxColumn.HeaderText = "IMC";
            this.iMCDataGridViewTextBoxColumn.Name = "iMCDataGridViewTextBoxColumn";
            // 
            // GestionarAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 441);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestionarAtencion";
            this.Text = "GestionarAtencion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atencionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox medico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox altura;
        private System.Windows.Forms.TextBox peso;
        private System.Windows.Forms.ComboBox paciente;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private System.Windows.Forms.BindingSource medicoBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource atencionBindingSource;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Nac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMCDataGridViewTextBoxColumn;
    }
}