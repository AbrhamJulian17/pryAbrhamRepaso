namespace pryAbrhamRepaso
{
    partial class Calculo
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
            cmbIVA = new ComboBox();
            lblMonto = new Label();
            lblIVA = new Label();
            txtMonto = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // cmbIVA
            // 
            cmbIVA.FormattingEnabled = true;
            cmbIVA.Items.AddRange(new object[] { "10", "21" });
            cmbIVA.Location = new Point(105, 113);
            cmbIVA.Name = "cmbIVA";
            cmbIVA.Size = new Size(127, 23);
            cmbIVA.TabIndex = 0;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.BackColor = SystemColors.ButtonFace;
            lblMonto.Location = new Point(36, 57);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 1;
            lblMonto.Text = "Monto";
            // 
            // lblIVA
            // 
            lblIVA.AutoSize = true;
            lblIVA.Location = new Point(46, 116);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(24, 15);
            lblIVA.TabIndex = 2;
            lblIVA.Text = "IVA";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(105, 54);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(127, 23);
            txtMonto.TabIndex = 3;
            txtMonto.TextChanged += txtMonto_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(157, 186);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(105, 234);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Resultado";
            // 
            // Calculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 363);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtMonto);
            Controls.Add(lblIVA);
            Controls.Add(lblMonto);
            Controls.Add(cmbIVA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Calculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbIVA;
        private Label lblMonto;
        private Label lblIVA;
        private TextBox txtMonto;
        private Button btnCalcular;
        private Label lblResultado;
    }
}