namespace Ejercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            FormPrincipal frmPrincipal = new FormPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }
    }
}