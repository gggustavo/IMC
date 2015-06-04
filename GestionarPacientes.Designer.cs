namespace IMC
{
    partial class GestionarPacientes
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
            this.label6 = new System.Windows.Forms.Label();
            this.sexo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Nac = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.domicilio = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.dni = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agregar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.sexo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Nac);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.telefono);
            this.groupBox1.Controls.Add(this.domicilio);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.dni);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 198);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Sexo";
            // 
            // sexo
            // 
            this.sexo.FormattingEnabled = true;
            this.sexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.sexo.Location = new System.Drawing.Point(96, 154);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(121, 21);
            this.sexo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nac.";
            // 
            // Nac
            // 
            this.Nac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Nac.Location = new System.Drawing.Point(96, 101);
            this.Nac.Name = "Nac";
            this.Nac.Size = new System.Drawing.Size(200, 20);
            this.Nac.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Domicilio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Dni";
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(96, 128);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(100, 20);
            this.telefono.TabIndex = 4;
            // 
            // domicilio
            // 
            this.domicilio.Location = new System.Drawing.Point(96, 77);
            this.domicilio.Name = "domicilio";
            this.domicilio.Size = new System.Drawing.Size(308, 20);
            this.domicilio.TabIndex = 2;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(96, 51);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(308, 20);
            this.nombre.TabIndex = 1;
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(96, 25);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(100, 20);
            this.dni.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dniDataGridViewTextBoxColumn,
            this.domicilioDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pacienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(552, 179);
            this.dataGridView1.TabIndex = 1;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "Dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "Dni";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            // 
            // domicilioDataGridViewTextBoxColumn
            // 
            this.domicilioDataGridViewTextBoxColumn.DataPropertyName = "Domicilio";
            this.domicilioDataGridViewTextBoxColumn.HeaderText = "Domicilio";
            this.domicilioDataGridViewTextBoxColumn.Name = "domicilioDataGridViewTextBoxColumn";
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "FechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataSource = typeof(IMC.Paciente);
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(12, 216);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 37);
            this.agregar.TabIndex = 0;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // GestionarPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "GestionarPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionarPacientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox domicilio;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Nac;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sexo;
    }
}