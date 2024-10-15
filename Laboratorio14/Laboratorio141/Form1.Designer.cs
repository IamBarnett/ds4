namespace Laboratorio141
{
    partial class Form1
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
            this.tstId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tsbBuscar = new System.Windows.Forms.Button();
            this.tsbEliminar = new System.Windows.Forms.Button();
            this.tsbCancelar = new System.Windows.Forms.Button();
            this.tsbGuardar = new System.Windows.Forms.Button();
            this.tsbNuevo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tstId
            // 
            this.tstId.Location = new System.Drawing.Point(307, 30);
            this.tstId.Name = "tstId";
            this.tstId.Size = new System.Drawing.Size(219, 22);
            this.tstId.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar por id:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.Image = global::Laboratorio141.Properties.Resources.buscar;
            this.tsbBuscar.Location = new System.Drawing.Point(582, 12);
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(67, 74);
            this.tsbBuscar.TabIndex = 6;
            this.tsbBuscar.UseVisualStyleBackColor = true;
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Image = global::Laboratorio141.Properties.Resources.eliminar;
            this.tsbEliminar.Location = new System.Drawing.Point(150, 12);
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(40, 40);
            this.tsbEliminar.TabIndex = 3;
            this.tsbEliminar.UseVisualStyleBackColor = true;
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.Image = global::Laboratorio141.Properties.Resources.cancelar;
            this.tsbCancelar.Location = new System.Drawing.Point(104, 12);
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(40, 40);
            this.tsbCancelar.TabIndex = 2;
            this.tsbCancelar.UseVisualStyleBackColor = true;
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tsbGuardar.Image = global::Laboratorio141.Properties.Resources.guardar;
            this.tsbGuardar.Location = new System.Drawing.Point(58, 12);
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(40, 40);
            this.tsbGuardar.TabIndex = 1;
            this.tsbGuardar.UseVisualStyleBackColor = true;
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.AccessibleDescription = "tsbNuevo";
            this.tsbNuevo.Image = global::Laboratorio141.Properties.Resources.nuevo;
            this.tsbNuevo.Location = new System.Drawing.Point(12, 12);
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(40, 40);
            this.tsbNuevo.TabIndex = 0;
            this.tsbNuevo.UseVisualStyleBackColor = true;
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Stock";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(84, 331);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(47, 146);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(205, 146);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(537, 22);
            this.txtNombre.TabIndex = 13;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(47, 241);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 14;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(205, 241);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(193, 22);
            this.txtStock.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tsbBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tstId);
            this.Controls.Add(this.tsbEliminar);
            this.Controls.Add(this.tsbCancelar);
            this.Controls.Add(this.tsbGuardar);
            this.Controls.Add(this.tsbNuevo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tsbNuevo;
        private System.Windows.Forms.Button tsbGuardar;
        private System.Windows.Forms.Button tsbCancelar;
        private System.Windows.Forms.Button tsbEliminar;
        private System.Windows.Forms.TextBox tstId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tsbBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
    }
}

