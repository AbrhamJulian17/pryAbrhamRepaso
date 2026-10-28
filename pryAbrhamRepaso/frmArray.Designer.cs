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
            lblGrupete = new Label();
            lblDato = new Label();
            txtDato = new TextBox();
            cboGrupoResultado = new ComboBox();
            btnGrabar = new Button();
            btnArray = new Button();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.Location = new Point(32, 22);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(46, 15);
            lblGrupo.TabIndex = 0;
            lblGrupo.Text = "GRUPO";
            lblGrupo.Click += lblGrupo_Click;
            // 
            // cmbGrupo
            // 
            cmbGrupo.FormattingEnabled = true;
            cmbGrupo.Location = new Point(98, 19);
            cmbGrupo.Name = "cmbGrupo";
            cmbGrupo.Size = new Size(121, 23);
            cmbGrupo.TabIndex = 1;
            cmbGrupo.SelectedIndexChanged += cmbGrupo_SelectedIndexChanged;
            // 
            // lstResultado
            // 
            lstResultado.BackColor = SystemColors.InactiveCaption;
            lstResultado.FormattingEnabled = true;
            lstResultado.Location = new Point(98, 62);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(121, 94);
            lstResultado.TabIndex = 2;
            lstResultado.SelectedIndexChanged += lstResultado_SelectedIndexChanged;
            // 
            // lblGrupete
            // 
            lblGrupete.AutoSize = true;
            lblGrupete.Location = new Point(64, 235);
            lblGrupete.Name = "lblGrupete";
            lblGrupete.Size = new Size(40, 15);
            lblGrupete.TabIndex = 3;
            lblGrupete.Text = "Grupo";
            // 
            // lblDato
            // 
            lblDato.AutoSize = true;
            lblDato.Location = new Point(66, 279);
            lblDato.Name = "lblDato";
            lblDato.Size = new Size(32, 15);
            lblDato.TabIndex = 4;
            lblDato.Text = "Dato";
            // 
            // txtDato
            // 
            txtDato.Location = new Point(110, 279);
            txtDato.Name = "txtDato";
            txtDato.Size = new Size(109, 23);
            txtDato.TabIndex = 5;
            // 
            // cboGrupoResultado
            // 
            cboGrupoResultado.FormattingEnabled = true;
            cboGrupoResultado.Location = new Point(110, 235);
            cboGrupoResultado.Name = "cboGrupoResultado";
            cboGrupoResultado.Size = new Size(109, 23);
            cboGrupoResultado.TabIndex = 6;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(144, 330);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 7;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnArray
            // 
            btnArray.BackColor = Color.Gainsboro;
            btnArray.Location = new Point(32, 171);
            btnArray.Name = "btnArray";
            btnArray.Size = new Size(187, 23);
            btnArray.TabIndex = 8;
            btnArray.Text = "Sobreescribir a Array";
            btnArray.UseVisualStyleBackColor = false;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(118, 392);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(38, 15);
            lblMensaje.TabIndex = 9;
            lblMensaje.Text = "label1";
            // 
            // frmArray
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(263, 442);
            Controls.Add(lblMensaje);
            Controls.Add(btnArray);
            Controls.Add(btnGrabar);
            Controls.Add(cboGrupoResultado);
            Controls.Add(txtDato);
            Controls.Add(lblDato);
            Controls.Add(lblGrupete);
            Controls.Add(lstResultado);
            Controls.Add(cmbGrupo);
            Controls.Add(lblGrupo);
            Name = "frmArray";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmArray";
            WindowState = FormWindowState.Minimized;
            Load += frmArray_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGrupo;
        private ComboBox cmbGrupo;
        private ListBox lstResultado;
        private Label lblGrupete;
        private Label lblDato;
        private TextBox txtDato;
        private ComboBox cboGrupoResultado;
        private Button btnGrabar;
        private Button btnArray;
        private Label lblMensaje;
    }
}