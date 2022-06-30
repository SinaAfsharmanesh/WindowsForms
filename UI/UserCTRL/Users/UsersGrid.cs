using WindowsForms.InternalDB;
using WindowsForms.Services;

namespace WindowsForms.UI.UserCTRL.Users
{
    public partial class UsersGrid : BaseCTRL
    {
        public UsersGrid()
        {
            InitializeComponent();
        }
        private Repo repo = Repo.Instance;


        private void UsersGrid_Load(object sender, EventArgs e)
        {
            UsersGridView.DataSource = Db.Instance.Users;
            UsersGridView.Refresh();
        }
    }
}
