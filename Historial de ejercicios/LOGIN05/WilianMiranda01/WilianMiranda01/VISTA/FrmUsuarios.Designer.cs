
namespace WilianMiranda01.VISTA
{
    partial class FrmUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtgListaUsuarios = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminarRegistros = new System.Windows.Forms.Button();
            this.btnActualizarRegistros = new System.Windows.Forms.Button();
            this.btnAgregarRegistro = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaUsuarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(0, 122);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 45, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(175, 61);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(0, 0);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(175, 61);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtgListaUsuarios
            // 
            this.dtgListaUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgListaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgListaUsuarios.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgListaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgListaUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dtgListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtgListaUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgListaUsuarios.EnableHeadersVisualStyles = false;
            this.dtgListaUsuarios.GridColor = System.Drawing.Color.Teal;
            this.dtgListaUsuarios.Location = new System.Drawing.Point(42, 79);
            this.dtgListaUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dtgListaUsuarios.Name = "dtgListaUsuarios";
            this.dtgListaUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListaUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.dtgListaUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dtgListaUsuarios.Size = new System.Drawing.Size(801, 159);
            this.dtgListaUsuarios.TabIndex = 12;
            this.dtgListaUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListaUsuarios_CellClick);
            this.dtgListaUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NOMBRE";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "APELLIDO";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "EDAD";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "PASSWORD";
            this.Column5.Name = "Column5";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActualizar.Location = new System.Drawing.Point(0, 61);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 45, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(175, 61);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Controls.Add(this.txtEdad);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.lblEdad);
            this.panel1.Controls.Add(this.lblPass);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(38, 280);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 220);
            this.panel1.TabIndex = 14;
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.Location = new System.Drawing.Point(119, 12);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 10);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(442, 26);
            this.txtId.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(4, 15);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 19);
            this.lblId.TabIndex = 20;
            this.lblId.Text = "ID";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContraseña.Location = new System.Drawing.Point(119, 172);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4, 4, 4, 29);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(442, 26);
            this.txtContraseña.TabIndex = 19;
            // 
            // txtEdad
            // 
            this.txtEdad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEdad.Location = new System.Drawing.Point(119, 132);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 10);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(442, 26);
            this.txtEdad.TabIndex = 18;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellido.Location = new System.Drawing.Point(119, 92);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 10);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(442, 26);
            this.txtApellido.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(119, 52);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 10);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(442, 26);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged_1);
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(4, 95);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(63, 19);
            this.lblApellido.TabIndex = 15;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblEdad
            // 
            this.lblEdad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(4, 135);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(44, 19);
            this.lblEdad.TabIndex = 14;
            this.lblEdad.Text = "Edad:";
            // 
            // lblPass
            // 
            this.lblPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(4, 175);
            this.lblPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(81, 19);
            this.lblPass.TabIndex = 13;
            this.lblPass.Text = "Contraseña:";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(4, 55);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 19);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btnEliminarRegistros);
            this.panel2.Controls.Add(this.btnActualizarRegistros);
            this.panel2.Controls.Add(this.btnAgregarRegistro);
            this.panel2.Controls.Add(this.btnAtras);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.btnActualizar);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(648, 280);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 220);
            this.panel2.TabIndex = 15;
            // 
            // btnEliminarRegistros
            // 
            this.btnEliminarRegistros.BackColor = System.Drawing.Color.Red;
            this.btnEliminarRegistros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminarRegistros.ForeColor = System.Drawing.Color.White;
            this.btnEliminarRegistros.Location = new System.Drawing.Point(0, 305);
            this.btnEliminarRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarRegistros.Name = "btnEliminarRegistros";
            this.btnEliminarRegistros.Size = new System.Drawing.Size(175, 61);
            this.btnEliminarRegistros.TabIndex = 17;
            this.btnEliminarRegistros.Text = "EliminarRegistros";
            this.btnEliminarRegistros.UseVisualStyleBackColor = false;
            this.btnEliminarRegistros.Visible = false;
            this.btnEliminarRegistros.Click += new System.EventHandler(this.btnEliminarRegistros_Click);
            // 
            // btnActualizarRegistros
            // 
            this.btnActualizarRegistros.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnActualizarRegistros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActualizarRegistros.Location = new System.Drawing.Point(0, 244);
            this.btnActualizarRegistros.Margin = new System.Windows.Forms.Padding(4, 4, 45, 4);
            this.btnActualizarRegistros.Name = "btnActualizarRegistros";
            this.btnActualizarRegistros.Size = new System.Drawing.Size(175, 61);
            this.btnActualizarRegistros.TabIndex = 16;
            this.btnActualizarRegistros.Text = "ActualizarRegistros";
            this.btnActualizarRegistros.UseVisualStyleBackColor = false;
            this.btnActualizarRegistros.Visible = false;
            this.btnActualizarRegistros.Click += new System.EventHandler(this.btnActualizarRegistros_Click);
            // 
            // btnAgregarRegistro
            // 
            this.btnAgregarRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregarRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnAgregarRegistro.Location = new System.Drawing.Point(0, 183);
            this.btnAgregarRegistro.Margin = new System.Windows.Forms.Padding(4, 4, 45, 4);
            this.btnAgregarRegistro.Name = "btnAgregarRegistro";
            this.btnAgregarRegistro.Size = new System.Drawing.Size(175, 61);
            this.btnAgregarRegistro.TabIndex = 15;
            this.btnAgregarRegistro.Text = "Agregar registro";
            this.btnAgregarRegistro.UseVisualStyleBackColor = false;
            this.btnAgregarRegistro.Visible = false;
            this.btnAgregarRegistro.Click += new System.EventHandler(this.btnAgregarRegistro_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAtras.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAtras.Location = new System.Drawing.Point(0, 366);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4, 4, 45, 4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(175, 61);
            this.btnAtras.TabIndex = 14;
            this.btnAtras.Text = "Regresar";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Visible = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(245, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "TABLA DE USUARIOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(882, 541);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgListaUsuarios);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUsuarios";
            this.Padding = new System.Windows.Forms.Padding(38, 37, 38, 37);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmUsuarios_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaUsuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dtgListaUsuarios;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAgregarRegistro;
        private System.Windows.Forms.Button btnActualizarRegistros;
        private System.Windows.Forms.Button btnEliminarRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}