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
                Top +=  (e.Y -PosY);
                Left +=  (e.X-PosX);

            }


        }
    }
}
