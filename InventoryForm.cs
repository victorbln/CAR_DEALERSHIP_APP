using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealership
{
    public partial class InventoryForm : Form
    {
        Inventory inventory;
        public InventoryForm(Inventory _inventory)
        {
            InitializeComponent();
            this.inventory = _inventory;
            LoadInventory();
        }
        public void LoadInventory()
        {
            inventoryDataGrid.DataSource = null;
            List<Car> cars = inventory.GetAllCars();
            inventoryDataGrid.DataSource = cars;
        }

        private void inventoryDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
