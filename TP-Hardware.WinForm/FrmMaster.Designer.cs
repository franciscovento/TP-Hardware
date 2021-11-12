
namespace TP_Hardware.WinForm
{
    partial class FrmMaster
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
            this._lblTituloTienda = new System.Windows.Forms.Label();
            this._btnConsultarClientes = new System.Windows.Forms.Button();
            this._btnConsultarProductos = new System.Windows.Forms.Button();
            this._btnConsultarVentas = new System.Windows.Forms.Button();
            this._btnConsultarProv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblTituloTienda
            // 
            this._lblTituloTienda.AutoSize = true;
            this._lblTituloTienda.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTituloTienda.Location = new System.Drawing.Point(107, 32);
            this._lblTituloTienda.Name = "_lblTituloTienda";
            this._lblTituloTienda.Size = new System.Drawing.Size(270, 28);
            this._lblTituloTienda.TabIndex = 0;
            this._lblTituloTienda.Text = "Springfield Hardware Store";
            // 
            // _btnConsultarClientes
            // 
            this._btnConsultarClientes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnConsultarClientes.Location = new System.Drawing.Point(135, 91);
            this._btnConsultarClientes.Name = "_btnConsultarClientes";
            this._btnConsultarClientes.Size = new System.Drawing.Size(195, 63);
            this._btnConsultarClientes.TabIndex = 1;
            this._btnConsultarClientes.Text = "Consultar clientes";
            this._btnConsultarClientes.UseVisualStyleBackColor = true;
            this._btnConsultarClientes.Click += new System.EventHandler(this.ButtonMainSender);
            // 
            // _btnConsultarProductos
            // 
            this._btnConsultarProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnConsultarProductos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnConsultarProductos.Location = new System.Drawing.Point(135, 173);
            this._btnConsultarProductos.Name = "_btnConsultarProductos";
            this._btnConsultarProductos.Size = new System.Drawing.Size(195, 63);
            this._btnConsultarProductos.TabIndex = 2;
            this._btnConsultarProductos.Tag = "";
            this._btnConsultarProductos.Text = "Consultar productos";
            this._btnConsultarProductos.UseVisualStyleBackColor = true;
            this._btnConsultarProductos.Click += new System.EventHandler(this.ButtonMainSender);
            // 
            // _btnConsultarVentas
            // 
            this._btnConsultarVentas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnConsultarVentas.Location = new System.Drawing.Point(135, 258);
            this._btnConsultarVentas.Name = "_btnConsultarVentas";
            this._btnConsultarVentas.Size = new System.Drawing.Size(195, 63);
            this._btnConsultarVentas.TabIndex = 3;
            this._btnConsultarVentas.Text = "Consultar ventas";
            this._btnConsultarVentas.UseVisualStyleBackColor = true;
            this._btnConsultarVentas.Click += new System.EventHandler(this.ButtonMainSender);
            // 
            // _btnConsultarProv
            // 
            this._btnConsultarProv.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnConsultarProv.Location = new System.Drawing.Point(135, 345);
            this._btnConsultarProv.Name = "_btnConsultarProv";
            this._btnConsultarProv.Size = new System.Drawing.Size(195, 63);
            this._btnConsultarProv.TabIndex = 4;
            this._btnConsultarProv.Text = "Consultar proveedores";
            this._btnConsultarProv.UseVisualStyleBackColor = true;
            this._btnConsultarProv.Click += new System.EventHandler(this.ButtonMainSender);
            // 
            // FrmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this._btnConsultarProv);
            this.Controls.Add(this._btnConsultarVentas);
            this.Controls.Add(this._btnConsultarProductos);
            this.Controls.Add(this._btnConsultarClientes);
            this.Controls.Add(this._lblTituloTienda);
            this.Name = "FrmMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido al sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblTituloTienda;
        private System.Windows.Forms.Button _btnConsultarClientes;
        private System.Windows.Forms.Button _btnConsultarProductos;
        private System.Windows.Forms.Button _btnConsultarVentas;
        private System.Windows.Forms.Button _btnConsultarProv;
    }
}

