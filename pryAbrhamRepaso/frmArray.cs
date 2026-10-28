using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryAbrhamRepaso
{
    public partial class frmArray : Form
    {
        string[] VectorGrupoA = new string[4];
        string[] VectorGrupoB = new string[3];
        string[] VectorGrupoC = new string[3];
        public frmArray()
        {
            InitializeComponent();
        }

        private void frmArray_Load(object sender, EventArgs e)
        {
            cmbGrupo.Items.Add("Grupo A");
            cmbGrupo.Items.Add("Grupo B");
            cmbGrupo.Items.Add("Grupo C");

            VectorGrupoA[0] = "Cpu";
            VectorGrupoA[1] = "Micro";
            VectorGrupoA[2] = "Placa";
            VectorGrupoA[3] = "Memoria";

            VectorGrupoB[0] = "Visual";
            VectorGrupoB[1] = "C#";
            VectorGrupoB[2] = "Desktop";

            VectorGrupoC[0] = "Server";
            VectorGrupoC[1] = "Aws";
            VectorGrupoC[2] = "Cloud";

            cmbGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void lstResultado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbGrupo.Text)
            {
                case "Grupo A":
                    lstResultado.Items.Clear();
                    lstResultado.Items.Add("Cpu");
                    lstResultado.Items.Add("Micro");
                    lstResultado.Items.Add("Placa");
                    lstResultado.Items.Add("Memoria");

                    //recorrer el vector de inicio a fin y mostrar el contenido

                    lstResultado.Items.Clear();
                    for (int indice = 0; indice < VectorGrupoA.Length; indice++)
                    {
                        lstResultado.Items.Add(VectorGrupoA[indice]);
                    }

                    break;
                case "Grupo B":
                    lstResultado.Items.Clear();
                    lstResultado.Items.Add("Visual");
                    lstResultado.Items.Add("C#");
                    lstResultado.Items.Add("Desktop");

                    lstResultado.Items.Clear();
                    for (int indice = 0; indice < VectorGrupoB.Length; indice++)
                    {
                        lstResultado.Items.Add(VectorGrupoB[indice]);
                    }
                    break;


                case "Grupo C":
                    lstResultado.Items.Clear();
                    lstResultado.Items.Add("Server");
                    lstResultado.Items.Add("Aws");
                    lstResultado.Items.Add("Cloud");

                    lstResultado.Items.Clear();
                    for (int indice = 0; indice < VectorGrupoC.Length; indice++)
                    {
                        lstResultado.Items.Add(VectorGrupoC[indice]);
                    }
                    break;

            }
        }

        private void lblGrupo_Click(object sender, EventArgs e)
        {

        }

        int indicegrabar = 0;
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            switch (cmbGrupo.Text)
            {
                case "Grupo A":
            VectorGrupoA[indicegrabar] = txtDato.Text;
                indicegrabar++;
                lblMensaje.Text = "Almacenamiento.. " + txtDato.Text;
                txtDato.Text = "";
                break;

                default:
                break;

            case "Grupo B":
                VectorGrupoB[indicegrabar] = txtDato.Text;
                indicegrabar++;
                lblMensaje.Text = "Almacenamiento.. " + txtDato.Text;
                txtDato.Text = "";
                break;

            case "Grupo C":
                VectorGrupoC[indicegrabar] = txtDato.Text;
                indicegrabar++;
                lblMensaje.Text = "Almacenamiento.. " + txtDato.Text;
                txtDato.Text = "";
                break;
            }
            
        }
    }
}


