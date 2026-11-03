namespace FormularioBienvenida
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Mi primera aplicación en C#!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*
            string nombre = nombres;
            string textoEdad = edad;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Introduce tu nombre.");
                return;
            }
            */
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string textoEdad = txtEdad.Text;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Introduce tu nombre.");
                return;
            }

            if (!int.TryParse(textoEdad, out int edad) || edad < 18)
            {
                if (edad < 18)
                {
                    MessageBox.Show("Debes ser mayor de edad para continuar.");
                    return;

                }
                else
                {
                    MessageBox.Show("Introduce una edad válida.");
                    return;
                }
            }
            lblResultado.Text = $"Hola, {nombre}.\n Tienes {edad} años.";
        }

        private void lblCurso_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtEdad.Clear();
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
