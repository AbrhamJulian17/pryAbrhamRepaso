namespace pryAbrhamRepaso
{
    partial class frmArray
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
            lblGrupo = new Label();
            cmbGrupo = new ComboBox();
            lstResultado = new ListBox();
            SuspendLayout();
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.Location = new Point(88, 71);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(40, 15);
            lblGrupo.TabIndex = 0;
            lblGrupo.Text = "Grupo";
            // 
            // cmbGrupo
            // 
            cmbGrupo.FormattingEnabled = true;
            cmbGrupo.Location = new Point(207, 71);
            cmbGrupo.Name = "cmbGrupo";
            cmbGrupo.Size = new Size(121, 23);
            cmbGrupo.TabIndex = 1;
            cmbGrupo.SelectedIndexChanged += cmbGrupo_SelectedIndexChanged;
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.Location = new Point(223, 175);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(120, 94);
            lstResultado.TabIndex = 2;
            lstResultado.SelectedIndexChanged += lstResultado_SelectedIndexChanged;
            // 
            // frmArray
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstResultado);
            Controls.Add(cmbGrupo);
            Controls.Add(lblGrupo);
            Name = "frmArray";
            Text = "frmArray";
            Load += frmArray_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGrupo;
        private ComboBox cmbGrupo;
        private ListBox lstResultado;
    }
}