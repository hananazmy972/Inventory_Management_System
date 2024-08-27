namespace Inventory_Management__System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void CategoryIcon_Click(object sender, EventArgs e)
        {
            CategoryForm categories = new CategoryForm();
            categories.Show();
            this.Hide();
        }
        //product
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ProductForm products = new ProductForm();
            products.Show();
            this.Hide();
        }
        //inventroy
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            InventoryForm inventory = new InventoryForm();
            inventory.Show();
            this.Hide();
        }

        //transaction
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm();
            transactionForm.Show();
            this.Hide();
        }
    }
}
