namespace pryTaborda_ControlesInt
{
    partial class FrmBotonera
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
            btnAtras = new Button();
            btnSiguiente = new Button();
            lblNombre = new Label();
            SuspendLayout();
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(168, 177);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(101, 47);
            btnAtras.TabIndex = 0;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(354, 177);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(101, 47);
            btnSiguiente.TabIndex = 1;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(188, 111);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(81, 25);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // FrmBotonera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(653, 355);
            Controls.Add(lblNombre);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAtras);
            Name = "FrmBotonera";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtras;
        private Button btnSiguiente;
        private Label lblNombre;
    }
}