namespace P520231_JosephGF.Formularios
{
    partial class FrmProveedorGestion
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.DgLista = new System.Windows.Forms.DataGridView();
            this.CProveedorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProveedorNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProveedorCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProveedorEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProveedorTipoDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbTipoProveedor = new System.Windows.Forms.ComboBox();
            this.TxtProveedorDireccion = new System.Windows.Forms.TextBox();
            this.TxtProveedorNotas = new System.Windows.Forms.TextBox();
            this.TxtProveedorEmail = new System.Windows.Forms.TextBox();
            this.TxtProveedorCedula = new System.Windows.Forms.TextBox();
            this.TxtProveedorNombre = new System.Windows.Forms.TextBox();
            this.TxtProveedorID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.CboxVerActivos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.ForeColor = System.Drawing.Color.DarkGreen;
            this.TxtBuscar.Location = new System.Drawing.Point(216, 12);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(256, 20);
            this.TxtBuscar.TabIndex = 1;
            this.TxtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DgLista
            // 
            this.DgLista.AllowUserToAddRows = false;
            this.DgLista.AllowUserToDeleteRows = false;
            this.DgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CProveedorID,
            this.CProveedorNombre,
            this.CProveedorCedula,
            this.CProveedorEmail,
            this.CProveedorTipoDescripcion});
            this.DgLista.Location = new System.Drawing.Point(12, 38);
            this.DgLista.MultiSelect = false;
            this.DgLista.Name = "DgLista";
            this.DgLista.ReadOnly = true;
            this.DgLista.RowHeadersVisible = false;
            this.DgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgLista.Size = new System.Drawing.Size(689, 246);
            this.DgLista.TabIndex = 2;
            this.DgLista.VirtualMode = true;
            this.DgLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgLista_CellClick);
            this.DgLista.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgLista_DataBindingComplete);
            // 
            // CProveedorID
            // 
            this.CProveedorID.DataPropertyName = "ProveedorID";
            this.CProveedorID.HeaderText = "Codigo";
            this.CProveedorID.Name = "CProveedorID";
            this.CProveedorID.ReadOnly = true;
            // 
            // CProveedorNombre
            // 
            this.CProveedorNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CProveedorNombre.DataPropertyName = "ProveedorNombre";
            this.CProveedorNombre.HeaderText = "Nombre";
            this.CProveedorNombre.Name = "CProveedorNombre";
            this.CProveedorNombre.ReadOnly = true;
            // 
            // CProveedorCedula
            // 
            this.CProveedorCedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CProveedorCedula.DataPropertyName = "ProveedorCedula";
            this.CProveedorCedula.HeaderText = "Cedula";
            this.CProveedorCedula.Name = "CProveedorCedula";
            this.CProveedorCedula.ReadOnly = true;
            this.CProveedorCedula.Width = 120;
            // 
            // CProveedorEmail
            // 
            this.CProveedorEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CProveedorEmail.DataPropertyName = "ProveedorEmail";
            this.CProveedorEmail.HeaderText = "Email";
            this.CProveedorEmail.Name = "CProveedorEmail";
            this.CProveedorEmail.ReadOnly = true;
            this.CProveedorEmail.Width = 150;
            // 
            // CProveedorTipoDescripcion
            // 
            this.CProveedorTipoDescripcion.DataPropertyName = "ProveedorTipoDescripcion";
            this.CProveedorTipoDescripcion.HeaderText = "Tipo Proveedor";
            this.CProveedorTipoDescripcion.Name = "CProveedorTipoDescripcion";
            this.CProveedorTipoDescripcion.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbTipoProveedor);
            this.groupBox1.Controls.Add(this.TxtProveedorDireccion);
            this.groupBox1.Controls.Add(this.TxtProveedorNotas);
            this.groupBox1.Controls.Add(this.TxtProveedorEmail);
            this.groupBox1.Controls.Add(this.TxtProveedorCedula);
            this.groupBox1.Controls.Add(this.TxtProveedorNombre);
            this.groupBox1.Controls.Add(this.TxtProveedorID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 193);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Proveedor";
            // 
            // CbTipoProveedor
            // 
            this.CbTipoProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipoProveedor.FormattingEnabled = true;
            this.CbTipoProveedor.Location = new System.Drawing.Point(485, 125);
            this.CbTipoProveedor.Name = "CbTipoProveedor";
            this.CbTipoProveedor.Size = new System.Drawing.Size(197, 21);
            this.CbTipoProveedor.TabIndex = 13;
            // 
            // TxtProveedorDireccion
            // 
            this.TxtProveedorDireccion.Location = new System.Drawing.Point(456, 20);
            this.TxtProveedorDireccion.Multiline = true;
            this.TxtProveedorDireccion.Name = "TxtProveedorDireccion";
            this.TxtProveedorDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtProveedorDireccion.Size = new System.Drawing.Size(226, 78);
            this.TxtProveedorDireccion.TabIndex = 12;
            // 
            // TxtProveedorNotas
            // 
            this.TxtProveedorNotas.Location = new System.Drawing.Point(121, 154);
            this.TxtProveedorNotas.Name = "TxtProveedorNotas";
            this.TxtProveedorNotas.Size = new System.Drawing.Size(237, 20);
            this.TxtProveedorNotas.TabIndex = 11;
            // 
            // TxtProveedorEmail
            // 
            this.TxtProveedorEmail.Location = new System.Drawing.Point(121, 118);
            this.TxtProveedorEmail.Name = "TxtProveedorEmail";
            this.TxtProveedorEmail.Size = new System.Drawing.Size(237, 20);
            this.TxtProveedorEmail.TabIndex = 10;
            // 
            // TxtProveedorCedula
            // 
            this.TxtProveedorCedula.Location = new System.Drawing.Point(121, 85);
            this.TxtProveedorCedula.Name = "TxtProveedorCedula";
            this.TxtProveedorCedula.Size = new System.Drawing.Size(237, 20);
            this.TxtProveedorCedula.TabIndex = 9;
            // 
            // TxtProveedorNombre
            // 
            this.TxtProveedorNombre.Location = new System.Drawing.Point(121, 50);
            this.TxtProveedorNombre.Name = "TxtProveedorNombre";
            this.TxtProveedorNombre.Size = new System.Drawing.Size(237, 20);
            this.TxtProveedorNombre.TabIndex = 8;
            // 
            // TxtProveedorID
            // 
            this.TxtProveedorID.Location = new System.Drawing.Point(121, 17);
            this.TxtProveedorID.Name = "TxtProveedorID";
            this.TxtProveedorID.ReadOnly = true;
            this.TxtProveedorID.Size = new System.Drawing.Size(237, 20);
            this.TxtProveedorID.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(392, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tipo Proveedor :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Direccion :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Notas :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cedula :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre Proveedor :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo Proveedor :";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(111, 489);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(134, 35);
            this.BtnAgregar.TabIndex = 4;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(289, 489);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(134, 35);
            this.BtnLimpiar.TabIndex = 5;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Brown;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(475, 489);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(134, 35);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // CboxVerActivos
            // 
            this.CboxVerActivos.AutoSize = true;
            this.CboxVerActivos.Checked = true;
            this.CboxVerActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CboxVerActivos.Location = new System.Drawing.Point(479, 13);
            this.CboxVerActivos.Name = "CboxVerActivos";
            this.CboxVerActivos.Size = new System.Drawing.Size(80, 17);
            this.CboxVerActivos.TabIndex = 7;
            this.CboxVerActivos.Text = "checkBox1";
            this.CboxVerActivos.UseVisualStyleBackColor = true;
            // 
            // FrmProveedorGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 536);
            this.Controls.Add(this.CboxVerActivos);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgLista);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmProveedorGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Proveedores";
            this.Load += new System.EventHandler(this.FrmProveedorGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridView DgLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtProveedorNotas;
        private System.Windows.Forms.TextBox TxtProveedorEmail;
        private System.Windows.Forms.TextBox TxtProveedorCedula;
        private System.Windows.Forms.TextBox TxtProveedorNombre;
        private System.Windows.Forms.TextBox TxtProveedorID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtProveedorDireccion;
        private System.Windows.Forms.ComboBox CbTipoProveedor;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProveedorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProveedorNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProveedorCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProveedorEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProveedorTipoDescripcion;
        private System.Windows.Forms.CheckBox CboxVerActivos;
    }
}