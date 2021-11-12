
namespace TP_Hardware.WinForm
{
    partial class FrmConsultarProveedores
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
            this._btnVolver = new System.Windows.Forms.Button();
            this._btnBuscarCliente = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._lblCodigoProd = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // _lblTituloTienda
            // 
            this._lblTituloTienda.AutoSize = true;
            this._lblTituloTienda.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTituloTienda.Location = new System.Drawing.Point(297, 33);
            this._lblTituloTienda.Name = "_lblTituloTienda";
            this._lblTituloTienda.Size = new System.Drawing.Size(223, 28);
            this._lblTituloTienda.TabIndex = 11;
            this._lblTituloTienda.Text = "Todos los proveedores";
            // 
            // _btnVolver
            // 
            this._btnVolver.Location = new System.Drawing.Point(672, 388);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(85, 29);
            this._btnVolver.TabIndex = 10;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = true;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // _btnBuscarCliente
            // 
            this._btnBuscarCliente.Location = new System.Drawing.Point(97, 193);
            this._btnBuscarCliente.Name = "_btnBuscarCliente";
            this._btnBuscarCliente.Size = new System.Drawing.Size(134, 36);
            this._btnBuscarCliente.TabIndex = 9;
            this._btnBuscarCliente.Text = "Buscar cliente";
            this._btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(47, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 22);
            this.textBox1.TabIndex = 8;
            // 
            // _lblCodigoProd
            // 
            this._lblCodigoProd.AutoSize = true;
            this._lblCodigoProd.Location = new System.Drawing.Point(44, 145);
            this._lblCodigoProd.Name = "_lblCodigoProd";
            this._lblCodigoProd.Size = new System.Drawing.Size(132, 17);
            this._lblCodigoProd.TabIndex = 7;
            this._lblCodigoProd.Text = "Código de producto";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(302, 145);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(455, 228);
            this.listBox1.TabIndex = 6;
            // 
            // FrmConsultarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._lblTituloTienda);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._btnBuscarCliente);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._lblCodigoProd);
            this.Controls.Add(this.listBox1);
            this.Name = "FrmConsultarProveedores";
            this.Text = "FrmConsultarProveedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblTituloTienda;
        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.Button _btnBuscarCliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label _lblCodigoProd;
        private System.Windows.Forms.ListBox listBox1;
    }
}