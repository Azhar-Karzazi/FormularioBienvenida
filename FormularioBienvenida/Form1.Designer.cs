namespace FormularioBienvenida
{
    partial class frmPrincipal
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            lblEdad = new Label();
            btnAceptar = new Button();
            lblResultado = new Label();
            lblCurso = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(30, 20);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(30, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(187, 38);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 5;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(187, 20);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(36, 15);
            lblEdad.TabIndex = 6;
            lblEdad.Text = "Edad:";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(120, 90);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(82, 137);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(150, 15);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "Aquí aparecerá el resultado";
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.ForeColor = SystemColors.ActiveCaption;
            lblCurso.Location = new Point(142, 177);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(166, 15);
            lblCurso.TabIndex = 9;
            lblCurso.Text = "Desarrollo de Interfaces · DAM";
            lblCurso.Click += lblCurso_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 201);
            Controls.Add(lblCurso);
            Controls.Add(lblResultado);
            Controls.Add(btnAceptar);
            Controls.Add(lblEdad);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario de bienvenida";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private Label lblEdad;
        private Button btnAceptar;
        private Label lblResultado;
        private Label lblCurso;
    }
}
