
namespace TP_Hardware.WinForm
{
    partial class FrmConsultarClientes
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
            this._lstClientes = new System.Windows.Forms.ListBox();
            this._lblCodigoProd = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._btnBuscarCliente = new System.Windows.Forms.Button();
            this._btnVolver = new System.Windows.Forms.Button();
            this._lblTituloTienda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lstClientes
            // 
            this._lstClientes.FormattingEnabled = true;
            this._lstClientes.ItemHeight = 16;
            this._lstClientes.Location = new System.Drawing.Point(296, 148);
            this._lstClientes.Name = "_lstClientes";
            this._lstClientes.Size = new System.Drawing.Size(455, 228);
            this._lstClientes.TabIndex = 0;
            // 
            // _lblCodigoProd
            // 
            this._lblCodigoProd.AutoSize = true;
            this._lblCodigoProd.Location = new System.Drawing.Point(38, 148);
            this._lblCodigoProd.Name = "_lblCodigoProd";
            this._lblCodigoProd.Size = new System.Drawing.Size(132, 17);
            this._lblCodigoProd.TabIndex = 1;
            this._lblCodigoProd.Text = "Código de producto";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(41, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 22);
            this.textBox1.TabIndex = 2;
            // 
            // _btnBuscarCliente
            // 
            this._btnBuscarCliente.Location = new System.Drawing.Point(91, 196);
            this._btnBuscarCliente.Name = "_btnBuscarCliente";
            this._btnBuscarCliente.Size = new System.Drawing.Size(134, 36);
            this._btnBuscarCliente.TabIndex = 3;
            this._btnBuscarCliente.Text = "Buscar cliente";
            this._btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // _btnVolver
            // 
            this._btnVolver.Location = new System.Drawing.Point(666, 391);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(85, 29);
            this._btnVolver.TabIndex = 4;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = true;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // _lblTituloTienda
            // 
            this._lblTituloTienda.AutoSize = true;
            this._lblTituloTienda.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTituloTienda.Location = new System.Drawing.Point(291, 36);
            this._lblTituloTienda.Name = "_lblTituloTienda";
            this._lblTituloTienda.Size = new System.Drawing.Size(179, 28);
            this._lblTituloTienda.TabIndex = 5;
            this._lblTituloTienda.Text = "Todos los clientes";
            // 
            // FrmConsultarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._lblTituloTienda);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._btnBuscarCliente);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._lblCodigoProd);
            this.Controls.Add(this._lstClientes);
            this.Name = "FrmConsultarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Clientes";
            this.Load += new System.EventHandler(this.FrmConsultarClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox _lstClientes;
        private System.Windows.Forms.Label _lblCodigoProd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button _btnBuscarCliente;
        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.Label _lblTituloTienda;
    }
}