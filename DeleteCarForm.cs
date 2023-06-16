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
    public partial class DeleteCarForm : Form
    {
        Inventory inventory;
        FileHandler fileHandler;
        public DeleteCarForm(Inventory _inventory, FileHandler fileHandler)
        {
            this.fileHandler = fileHandler;
            this.inventory = _inventory;
            InitializeComponent();
        }

        private void vinLabel_Click(object sender, EventArgs e)
        {

        }

        private void deleteCar_Click(object sender, EventArgs e)
        {
            if (vinDeleteCar.Text.Length > 0)
            {
                inventory.DeleteCar(vinDeleteCar.Text);
            }
            else
            {
                MessageBox.Show("Please enter vin", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            vinDeleteCar.Clear();
            fileHandler.SaveInventoryToFile(inventory);
            return;
        }
    }
}
