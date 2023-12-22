using AppBureau.Models;

namespace AppBureau
{
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();
        }

        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            using(RadonContext db =  new RadonContext())
            {
                Utilisateur user = db.Utilisateurs.SingleOrDefault(u => u.Login == TxtLogin.Text && u.Password == TxtPass.Text && u.EstTechnicien == false);
                if (user == null)
                {
                    MessageBox.Show("Login ou mot de passe incorrect !");
                }
                else
                {
                    FrmAccueil frmAccueil = new FrmAccueil();
                    frmAccueil.ShowDialog();
                }
            }
        }
    }
}
