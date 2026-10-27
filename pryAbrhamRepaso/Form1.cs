namespace pryAbrhamRepaso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

         int Codigo = Convert.ToInt32(txtCodigo.Text);
            string codigo;
            codigo = txtCodigo.Text;

            string nombre;
            nombre = txtNombre.Text;

            MessageBox.Show("Codigo: " + codigo + "\nNombre: " + nombre, "Datos Registrados", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }
    }
}
