namespace pryTaborda_ControlesInt
{
    partial class Form1
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
            btnBotonera = new Button();
            SuspendLayout();
            // 
            // btnBotonera
            // 
            btnBotonera.Location = new Point(22, 32);
            btnBotonera.Name = "btnBotonera";
            btnBotonera.Size = new Size(75, 23);
            btnBotonera.TabIndex = 0;
            btnBotonera.Text = "Botonera";
            btnBotonera.UseVisualStyleBackColor = true;
            btnBotonera.Click += btnBotonera_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(298, 396);
            Controls.Add(btnBotonera);
            Name = "Form1";
            Text = "FrmBotonera";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBotonera;
    }
}
