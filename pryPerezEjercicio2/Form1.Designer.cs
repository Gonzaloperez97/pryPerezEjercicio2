namespace pryPerezEjercicio2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblDistancia = new Label();
            lblCantidad = new Label();
            txtDistancia = new TextBox();
            nudCantidad = new NumericUpDown();
            btnCancelar = new Button();
            btnCalcular = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblDistancia
            // 
            lblDistancia.AutoSize = true;
            lblDistancia.Location = new Point(50, 61);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(55, 15);
            lblDistancia.TabIndex = 0;
            lblDistancia.Text = "Distancia";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(45, 115);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(80, 15);
            lblCantidad.TabIndex = 1;
            lblCantidad.Text = "Cantidad Días";
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(144, 58);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(100, 23);
            txtDistancia.TabIndex = 2;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(144, 113);
            nudCantidad.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(100, 23);
            nudCantidad.TabIndex = 3;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(61, 174);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Red;
            btnCalcular.ForeColor = SystemColors.ButtonHighlight;
            btnCalcular.Location = new Point(157, 174);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 261);
            Controls.Add(btnCalcular);
            Controls.Add(btnCancelar);
            Controls.Add(nudCantidad);
            Controls.Add(txtDistancia);
            Controls.Add(lblCantidad);
            Controls.Add(lblDistancia);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Boletos Ferro";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDistancia;
        private Label lblCantidad;
        private TextBox txtDistancia;
        private NumericUpDown nudCantidad;
        private Button btnCancelar;
        private Button btnCalcular;
    }
}
