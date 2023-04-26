namespace Ejemplo_2
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

        private void btnVer_Click(object sender, EventArgs e)
        {
            foreach (string item in lstbMiLista.SelectedItems)
            {
                MessageBox.Show(item);
            }

        }

        private void lstbMiLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.GreenYellow;

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void lstbMiLista_Enter(object sender, EventArgs e)
        {
            lstbMiLista.BackColor = Color.Red;
        }

        private void lstbMiLista_Leave(object sender, EventArgs e)
        {
            lstbMiLista.BackColor = Color.White;
          
        }
    }
}