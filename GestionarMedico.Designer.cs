namespace IMC
{
    partial class GestionarMedico
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.nromatricula = new System.Windows.Forms.TextBox();
            this.agregar = new System.Windows.Forms.Button();
            this.dgmedicos = new System.Windows.Forms.DataGridView();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgmedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.telefono);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.nromatricula);
            this.groupBox1.Location = new System.Drawing.Point(15, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 140);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Telefono";
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
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nro. Matricula";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(96, 104);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(308, 20);
            this.email.TabIndex = 3;
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(96, 77);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(100, 20);
            this.telefono.TabIndex = 2;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(96, 51);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(308, 20);
            this.nombre.TabIndex = 1;
            // 
            // nromatricula
            // 
            this.nromatricula.Location = new System.Drawing.Point(96, 25);
            this.nromatricula.Name = "nromatricula";
            this.nromatricula.Size = new System.Drawing.Size(100, 20);
            this.nromatricula.TabIndex = 0;
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(8, 159);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 37);
            this.agregar.TabIndex = 0;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // dgmedicos
            // 
            this.dgmedicos.AutoGenerateColumns = false;
            this.dgmedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgmedicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgmedicos.DataSource = this.medicoBindingSource;
            this.dgmedicos.Location = new System.Drawing.Point(8, 202);
            this.dgmedicos.Name = "dgmedicos";
            this.dgmedicos.Size = new System.Drawing.Size(444, 276);
            this.dgmedicos.TabIndex = 1;
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
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
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // medicoBindingSource
            // 
            this.medicoBindingSource.DataSource = typeof(IMC.Medico);
            // 
            // GestionarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 490);
            this.Controls.Add(this.dgmedicos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GestionarMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionarMedico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgmedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox nromatricula;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.DataGridView dgmedicos;
        private System.Windows.Forms.BindingSource medicoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}