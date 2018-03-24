namespace La_Liebre_y_La_Tortuga
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
            this.txtTodo = new System.Windows.Forms.TextBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTodo
            // 
            this.txtTodo.Location = new System.Drawing.Point(106, 106);
            this.txtTodo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTodo.Multiline = true;
            this.txtTodo.Name = "txtTodo";
            this.txtTodo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTodo.Size = new System.Drawing.Size(324, 262);
            this.txtTodo.TabIndex = 0;
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(201, 41);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(138, 42);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 414);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.txtTodo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTodo;
        private System.Windows.Forms.Button btnInicio;
    }
}

