namespace ProyectoWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Obtener el texto del textBox
            string textoTextBox = textBox1.Text;

            //Cambiar el texto del label segun el texto del texbox
            label1.Text = "Texto actual: " + textoTextBox;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cambiar texto del TextBox
            textBox1.Text = "Nombre cambiado";

            //Cambiar texto label1
            label1.Text = "Etiqueta Cambiada";
        }
    }
}
