using System.Security.Policy;
using System.Windows.Forms.Design;

namespace login_git
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        int PosX = 0;
        int PosY = 0;
        private void PnlBarraAccion_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                PosX = e.X;
                PosY = e.Y;

            }
            else
            {
                Top += (e.Y - PosY);
                Left += (e.X - PosX);

            }


        }

        private void PtbCerrarVentana_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PtbMinimizarVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            bool UsuarioValido= false;
            bool Contrase�aValida = false;
            string UsuarioIngresado = Convert.ToString(TxtUsuario.Text);
            string Contrase�aIngresada = Convert.ToString(TxtContrase�a.Text);


            if (UsuarioIngresado=="Oscar")
            { 

                UsuarioValido = true;
            }

            if (Contrase�aIngresada == "PacoMerte")
            {

                Contrase�aValida = true;
            }

            if (UsuarioValido==true&Contrase�aValida==true)
            {
                MessageBox.Show("Acceso autorizado","Autorizado",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Acceso denegado", "Error", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

         

        }
    }
}
