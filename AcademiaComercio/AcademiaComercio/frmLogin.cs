namespace AcademiaComercio
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            frmMenu fM = new frmMenu();
            fM.ShowDialog();
        }
    }
}
