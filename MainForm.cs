namespace CarDealership
{
    public partial class MainForm : Form
    {
        public Inventory inventory;
        public SalesManager salesManager;
        public UserManager userManager;
        public DataGridView datagrid;
        public FileHandler fileHandler;
        // UI Controls
        public DataGridView inventoryGridView;
        public DataGridView salesGridView;
        public ComboBox monthComboBox;
        public ComboBox yearComboBox;
        public Button filterButton;

        public MainForm()
        {
            inventory = new Inventory();
            salesManager = new SalesManager();
            userManager = new UserManager();
            fileHandler = new FileHandler(inventory);
            LoadSales();
            InitializeComponent();
        }

        private void LoadSales()
        {
            salesManager.LoadSalesFromFile();
        }


        private void addCarButton_Click(object sender, EventArgs e)
        {
            appContent.Controls.Clear();
            AddCarForm addCarForm = new AddCarForm(inventory,fileHandler);
            addCarForm.TopLevel = false;
            appContent.Controls.Add(addCarForm);
            addCarForm.BringToFront();
            addCarForm.Show();
        }

        private void sellCarButton_Click(object sender, EventArgs e)
        {
            appContent.Controls.Clear();
            SellCarForm sellCarForm = new SellCarForm(inventory, salesManager,fileHandler);
            sellCarForm.TopLevel = false;
            appContent.Controls.Add(sellCarForm);
            sellCarForm.BringToFront();
            sellCarForm.Show();
        }

        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            appContent.Controls.Clear();
            DeleteCarForm deleteCarForm = new DeleteCarForm(inventory, fileHandler);
            deleteCarForm.TopLevel = false;
            appContent.Controls.Add(deleteCarForm);
            deleteCarForm.BringToFront();
            deleteCarForm.Show();
        }

        private void updateButton_Click_1(object sender, EventArgs e)
        {
            appContent.Controls.Clear();
            UpdateCarForm updateCarForm = new UpdateCarForm(inventory, fileHandler);
            updateCarForm.TopLevel = false;
            appContent.Controls.Add(updateCarForm);
            updateCarForm.BringToFront();
            updateCarForm.Show();
        }

        private void seeInventoryButton_Click(object sender, EventArgs e)
        {
            appContent.Controls.Clear();
            InventoryForm inventoryForm = new InventoryForm(inventory);
            inventoryForm.TopLevel = false;
            appContent.Controls.Add(inventoryForm);
            inventoryForm.BringToFront();
            inventoryForm.Show();
        }

        private void viewMonthSales_Click(object sender, EventArgs e)
        {

        }

        private void viewAllSales_Click(object sender, EventArgs e)
        {
            appContent.Controls.Clear();
            salesForm salesForm = new salesForm(salesManager);
            salesForm.TopLevel = false;
            appContent.Controls.Add(salesForm);
            salesForm.BringToFront();
            salesForm.Show();
        }
    }
}