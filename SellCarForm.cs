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
    public partial class SellCarForm : Form
    {
        Inventory inventory;
        SalesManager salesManager;
        FileHandler fileHandler;
        public SellCarForm(Inventory _inventory, SalesManager _salesManager, FileHandler fileHandler)
        {
            this.fileHandler = fileHandler;
            this.inventory = _inventory;
            this.salesManager = _salesManager;
            InitializeComponent();
        }

        private void modelLabel_Click(object sender, EventArgs e)
        {

        }

        private void cancelButtonSellForm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void sellBCar_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale();
            Customer customer = new Customer();
            customer.Name = customerNameTextBox.Text;
            customer.Email = customerEmailTextBox.Text;
            customer.Phone = customerPhoneTextBox.Text;
            sale.Customer = customer;
            sale.Car = inventory.GetCarByVIN(vinTextBox.Text);
            if (sale.Car == null)
            {
                MessageBox.Show("Car not found in inventory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sale.SaleDate = DateTime.Now;
            salesManager.AddSale(sale);
            inventory.DeleteCar(sale.Car.VIN);
            customerEmailTextBox.Clear();
            customerPhoneTextBox.Clear();
            customerNameTextBox.Clear();
            vinTextBox.Clear();
            //MessageBox.Show("Sale added succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fileHandler.SaveInventoryToFile(inventory);
            return;

        }
    }
}
