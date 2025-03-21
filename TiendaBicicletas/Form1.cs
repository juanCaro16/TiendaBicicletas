namespace TiendaBicicletas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroVentas registroVentas = new RegistroVentas();
            registroVentas.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 ventanaPrincipal = new Form1();
            ventanaPrincipal.Show();
            this.Close();
        }
    }
}
