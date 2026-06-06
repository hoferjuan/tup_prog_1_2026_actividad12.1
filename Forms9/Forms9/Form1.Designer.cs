namespace Forms9
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Número = new System.Windows.Forms.Label();
            this.btnIngresarNumero = new System.Windows.Forms.Button();
            this.btnVerAcumulado = new System.Windows.Forms.Button();
            this.btnVerCantidad = new System.Windows.Forms.Button();
            this.btnVerPromedio = new System.Windows.Forms.Button();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Número
            // 
            this.Número.AutoSize = true;
            this.Número.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Número.Location = new System.Drawing.Point(215, 77);
            this.Número.Name = "Número";
            this.Número.Size = new System.Drawing.Size(103, 29);
            this.Número.TabIndex = 0;
            this.Número.Text = "Número";
            // 
            // btnIngresarNumero
            // 
            this.btnIngresarNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarNumero.Location = new System.Drawing.Point(116, 184);
            this.btnIngresarNumero.Name = "btnIngresarNumero";
            this.btnIngresarNumero.Size = new System.Drawing.Size(139, 36);
            this.btnIngresarNumero.TabIndex = 2;
            this.btnIngresarNumero.Text = "Ingresar  Número";
            this.btnIngresarNumero.UseVisualStyleBackColor = true;
            this.btnIngresarNumero.Click += new System.EventHandler(this.btnIngresarNumero_Click);
            // 
            // btnVerAcumulado
            // 
            this.btnVerAcumulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerAcumulado.Location = new System.Drawing.Point(280, 184);
            this.btnVerAcumulado.Name = "btnVerAcumulado";
            this.btnVerAcumulado.Size = new System.Drawing.Size(139, 36);
            this.btnVerAcumulado.TabIndex = 3;
            this.btnVerAcumulado.Text = "Ver Acumulados";
            this.btnVerAcumulado.UseVisualStyleBackColor = true;
            this.btnVerAcumulado.Click += new System.EventHandler(this.btnVerAcumulado_Click);
            // 
            // btnVerCantidad
            // 
            this.btnVerCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCantidad.Location = new System.Drawing.Point(116, 247);
            this.btnVerCantidad.Name = "btnVerCantidad";
            this.btnVerCantidad.Size = new System.Drawing.Size(139, 36);
            this.btnVerCantidad.TabIndex = 4;
            this.btnVerCantidad.Text = "Ver Cantidad";
            this.btnVerCantidad.UseVisualStyleBackColor = true;
            this.btnVerCantidad.Click += new System.EventHandler(this.btnVerCantidad_Click);
            // 
            // btnVerPromedio
            // 
            this.btnVerPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPromedio.Location = new System.Drawing.Point(280, 247);
            this.btnVerPromedio.Name = "btnVerPromedio";
            this.btnVerPromedio.Size = new System.Drawing.Size(139, 36);
            this.btnVerPromedio.TabIndex = 5;
            this.btnVerPromedio.Text = "Ver Promedio";
            this.btnVerPromedio.UseVisualStyleBackColor = true;
            this.btnVerPromedio.Click += new System.EventHandler(this.btnVerPromedio_Click);
            // 
            // tbNumero
            // 
            this.tbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero.Location = new System.Drawing.Point(203, 118);
            this.tbNumero.Multiline = true;
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(125, 48);
            this.tbNumero.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 357);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.btnVerPromedio);
            this.Controls.Add(this.btnVerCantidad);
            this.Controls.Add(this.btnVerAcumulado);
            this.Controls.Add(this.btnIngresarNumero);
            this.Controls.Add(this.Número);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Número;
        private System.Windows.Forms.Button btnIngresarNumero;
        private System.Windows.Forms.Button btnVerAcumulado;
        private System.Windows.Forms.Button btnVerCantidad;
        private System.Windows.Forms.Button btnVerPromedio;
        private System.Windows.Forms.TextBox tbNumero;
    }
}

