using WindowsForms.InternalDB;
using WindowsForms.Services;

namespace WindowsForms.UI.UserCTRL.Products
{
    public partial class ProductsGrid : BaseCTRL
    {
        public ProductsGrid()
        {
            InitializeComponent();
        }
        private Repo repo = Repo.Instance;

        private void ProductsGrid_Load(object sender, EventArgs e)
        {
            ProductsGridView.DataSource = Db.Instance.Products;
            ProductsGridView.Refresh();
        }
    }
}
