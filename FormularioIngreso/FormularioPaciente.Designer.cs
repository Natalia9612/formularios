namespace FormularioIngreso
{
    partial class FormularioPaciente
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
            this.lblprimernombre = new System.Windows.Forms.Label();
            this.lblsegundonombre = new System.Windows.Forms.Label();
            this.lblprimerapellido = new System.Windows.Forms.Label();
            this.lblsegundoapellido = new System.Windows.Forms.Label();
            this.txtprimernombre = new System.Windows.Forms.TextBox();
            this.txtsegundonombre = new System.Windows.Forms.TextBox();
            this.txtprimerapellido = new System.Windows.Forms.TextBox();
            this.txtsegundoapellido = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblprimernombre
            // 
            this.lblprimernombre.AutoSize = true;
            this.lblprimernombre.Location = new System.Drawing.Point(167, 106);
            this.lblprimernombre.Name = "lblprimernombre";
            this.lblprimernombre.Size = new System.Drawing.Size(89, 15);
            this.lblprimernombre.TabIndex = 0;
            this.lblprimernombre.Text = "Primer Nombre";
            // 
            // lblsegundonombre
            // 
            this.lblsegundonombre.AutoSize = true;
            this.lblsegundonombre.Location = new System.Drawing.Point(167, 143);
            this.lblsegundonombre.Name = "lblsegundonombre";
            this.lblsegundonombre.Size = new System.Drawing.Size(101, 15);
            this.lblsegundonombre.TabIndex = 1;
            this.lblsegundonombre.Text = "Segundo Nombre";
            // 
            // lblprimerapellido
            // 
            this.lblprimerapellido.AutoSize = true;
            this.lblprimerapellido.Location = new System.Drawing.Point(167, 187);
            this.lblprimerapellido.Name = "lblprimerapellido";
            this.lblprimerapellido.Size = new System.Drawing.Size(89, 15);
            this.lblprimerapellido.TabIndex = 2;
            this.lblprimerapellido.Text = "Primer Apellido";
            // 
            // lblsegundoapellido
            // 
            this.lblsegundoapellido.AutoSize = true;
            this.lblsegundoapellido.Location = new System.Drawing.Point(167, 240);
            this.lblsegundoapellido.Name = "lblsegundoapellido";
            this.lblsegundoapellido.Size = new System.Drawing.Size(101, 15);
            this.lblsegundoapellido.TabIndex = 3;
            this.lblsegundoapellido.Text = "Segundo Apellido";
            // 
            // txtprimernombre
            // 
            this.txtprimernombre.Location = new System.Drawing.Point(312, 103);
            this.txtprimernombre.Name = "txtprimernombre";
            this.txtprimernombre.Size = new System.Drawing.Size(100, 23);
            this.txtprimernombre.TabIndex = 4;
            // 
            // txtsegundonombre
            // 
            this.txtsegundonombre.Location = new System.Drawing.Point(312, 143);
            this.txtsegundonombre.Name = "txtsegundonombre";
            this.txtsegundonombre.Size = new System.Drawing.Size(100, 23);
            this.txtsegundonombre.TabIndex = 5;
            // 
            // txtprimerapellido
            // 
            this.txtprimerapellido.Location = new System.Drawing.Point(312, 179);
            this.txtprimerapellido.Name = "txtprimerapellido";
            this.txtprimerapellido.Size = new System.Drawing.Size(100, 23);
            this.txtprimerapellido.TabIndex = 6;
            // 
            // txtsegundoapellido
            // 
            this.txtsegundoapellido.Location = new System.Drawing.Point(312, 232);
            this.txtsegundoapellido.Name = "txtsegundoapellido";
            this.txtsegundoapellido.Size = new System.Drawing.Size(100, 23);
            this.txtsegundoapellido.TabIndex = 7;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(295, 303);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(253, 35);
            this.btncancelar.TabIndex = 8;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(295, 377);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(253, 38);
            this.btnguardar.TabIndex = 9;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // FormularioPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.txtsegundoapellido);
            this.Controls.Add(this.txtprimerapellido);
            this.Controls.Add(this.txtsegundonombre);
            this.Controls.Add(this.txtprimernombre);
            this.Controls.Add(this.lblsegundoapellido);
            this.Controls.Add(this.lblprimerapellido);
            this.Controls.Add(this.lblsegundonombre);
            this.Controls.Add(this.lblprimernombre);
            this.Name = "FormularioPaciente";
            this.Text = "FormularioPaciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblprimernombre;
        private Label lblsegundonombre;
        private Label lblprimerapellido;
        private Label lblsegundoapellido;
        private TextBox txtprimernombre;
        private TextBox txtsegundonombre;
        private TextBox txtprimerapellido;
        private TextBox txtsegundoapellido;
        private Button btncancelar;
        private Button btnguardar;
    }
}