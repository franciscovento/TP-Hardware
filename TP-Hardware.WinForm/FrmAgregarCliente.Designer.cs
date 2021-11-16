
namespace TP_Hardware.WinForm
{
    partial class FrmAgregarCliente
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
            this._txtNombre = new System.Windows.Forms.TextBox();
            this._txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._txtDNI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._btnAgregarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // _txtNombre
            // 
            this._txtNombre.Location = new System.Drawing.Point(164, 53);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(183, 22);
            this._txtNombre.TabIndex = 1;
            // 
            // _txtApellido
            // 
            this._txtApellido.Location = new System.Drawing.Point(164, 113);
            this._txtApellido.Name = "_txtApellido";
            this._txtApellido.Size = new System.Drawing.Size(183, 22);
            this._txtApellido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // _txtDNI
            // 
            this._txtDNI.Location = new System.Drawing.Point(164, 169);
            this._txtDNI.Name = "_txtDNI";
            this._txtDNI.Size = new System.Drawing.Size(183, 22);
            this._txtDNI.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "DNI";
            // 
            // _txtDireccion
            // 
            this._txtDireccion.Location = new System.Drawing.Point(164, 227);
            this._txtDireccion.Name = "_txtDireccion";
            this._txtDireccion.Size = new System.Drawing.Size(183, 22);
            this._txtDireccion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dirección";
            // 
            // _txtEmail
            // 
            this._txtEmail.Location = new System.Drawing.Point(164, 284);
            this._txtEmail.Name = "_txtEmail";
            this._txtEmail.Size = new System.Drawing.Size(183, 22);
            this._txtEmail.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // _txtTelefono
            // 
            this._txtTelefono.Location = new System.Drawing.Point(164, 346);
            this._txtTelefono.Name = "_txtTelefono";
            this._txtTelefono.Size = new System.Drawing.Size(183, 22);
            this._txtTelefono.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefono";
            // 
            // _btnAgregarCliente
            // 
            this._btnAgregarCliente.Location = new System.Drawing.Point(164, 379);
            this._btnAgregarCliente.Name = "_btnAgregarCliente";
            this._btnAgregarCliente.Size = new System.Drawing.Size(183, 44);
            this._btnAgregarCliente.TabIndex = 12;
            this._btnAgregarCliente.Text = "Agregar";
            this._btnAgregarCliente.UseVisualStyleBackColor = true;
            this._btnAgregarCliente.Click += new System.EventHandler(this._btnAgregarCliente_Click);
            // 
            // FrmAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 450);
            this.Controls.Add(this._btnAgregarCliente);
            this.Controls.Add(this._txtTelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._txtDireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._txtDNI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._txtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "FrmAgregarCliente";
            this.Text = "FrmAgregarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.TextBox _txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtDNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button _btnAgregarCliente;
    }
}