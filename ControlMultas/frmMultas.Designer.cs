namespace ControlMultas
{
    partial class frmMultas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMultasTransito = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecga = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtVelocidad = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lvMultas = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMultasTransito
            // 
            this.lblMultasTransito.AutoSize = true;
            this.lblMultasTransito.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMultasTransito.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMultasTransito.Location = new System.Drawing.Point(219, 23);
            this.lblMultasTransito.Name = "lblMultasTransito";
            this.lblMultasTransito.Size = new System.Drawing.Size(332, 18);
            this.lblMultasTransito.TabIndex = 0;
            this.lblMultasTransito.Text = "CONTROL DE REGISTRO DE MULTAS DE TRANSITO";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(550, 69);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(91, 15);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "FECHA ACTUAL";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(550, 116);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(87, 15);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "HORA ACTUAL";
            // 
            // lblFecga
            // 
            this.lblFecga.AutoSize = true;
            this.lblFecga.Location = new System.Drawing.Point(683, 69);
            this.lblFecga.Name = "lblFecga";
            this.lblFecga.Size = new System.Drawing.Size(38, 15);
            this.lblFecga.TabIndex = 3;
            this.lblFecga.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(683, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(28, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "NUMERO DE PLACA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(11, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "INGRESE VELOCIDAD(Km-h)";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(173, 86);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 23);
            this.txtPlaca.TabIndex = 7;
            // 
            // txtVelocidad
            // 
            this.txtVelocidad.Location = new System.Drawing.Point(173, 139);
            this.txtVelocidad.Name = "txtVelocidad";
            this.txtVelocidad.Size = new System.Drawing.Size(100, 23);
            this.txtVelocidad.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(330, 143);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(612, 405);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lvMultas
            // 
            this.lvMultas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvMultas.Location = new System.Drawing.Point(51, 188);
            this.lvMultas.Name = "lvMultas";
            this.lvMultas.Size = new System.Drawing.Size(645, 167);
            this.lvMultas.TabIndex = 13;
            this.lvMultas.UseCompatibleStateImageBehavior = false;
            this.lvMultas.View = System.Windows.Forms.View.Details;
            this.lvMultas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvMultas_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Primera Placa";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fecha";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hora";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Velocidad Km-h";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Multa";
            this.columnHeader5.Width = 120;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(489, 402);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmMultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lvMultas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtVelocidad);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFecga);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblMultasTransito);
            this.Name = "frmMultas";
            this.Text = "Control de registros de multas de transito";
            this.Load += new System.EventHandler(this.frmMultas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMultasTransito;
        private Label lblFecha;
        private Label lblHora;
        private Label lblFecga;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtPlaca;
        private TextBox txtVelocidad;
        private Button btnRegistrar;
        private Button btnSalir;
        private ListView lvMultas;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button btnEliminar;
    }
}