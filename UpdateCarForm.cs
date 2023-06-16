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
    public partial class UpdateCarForm : Form
    {
        Inventory inventory;
        FileHandler fileHandler;
        public UpdateCarForm(Inventory inventory, FileHandler fileHandler)
        {
            this.fileHandler = fileHandler;
            this.inventory = inventory;

            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string make = makeTextBox.Text;
            string model = modelTextBox.Text;
            string VIN = vinTextBox.Text;
            string price = priceTextBox.Text;
            string vin = vinTextBox.Text;
            string color = colorTextBox.Text;
            string year = yearTextBox.Text;
            string mileage = mileageTextBox.Text;
            // Validate input
            if (string.IsNullOrEmpty(vin))
            {
                MessageBox.Show("Please enter a vin of the car.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Car carToUpdate = inventory.GetCarByVIN(VIN);
            if(carToUpdate==null)
            {
                MessageBox.Show("Car not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (make.Length > 0)
            {
                carToUpdate.Make = make;
            }
            if (model.Length > 0)
            {
                carToUpdate.Model = model;
            }
            if (year.Length > 0)
            {
                carToUpdate.Year = Convert.ToInt32(year);
            }
            if (mileage.Length > 0)
            {
                carToUpdate.Mileage = Convert.ToInt32(mileage);
            }
            if (price.Length > 0)
            {
                carToUpdate.Price = Convert.ToDecimal(price);
            }
            if (color.Length > 0)
            {
                carToUpdate.Color = color;
            }
            if (vin.Length > 0)
            {
                carToUpdate.VIN = vin;
            }
            inventory.UpdateCar(VIN, carToUpdate);
            makeTextBox.Clear();
            modelTextBox.Clear();
            mileageTextBox.Clear();
            priceTextBox.Clear();
            vinTextBox.Clear();
            yearTextBox.Clear();
            colorTextBox.Clear();

            //MessageBox.Show("Car updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fileHandler.SaveInventoryToFile(inventory);
        }

        private void cancelButtonUpdateForm_Click(object sender, EventArgs e)
        {
            // Close the form without performing any action
            this.Close();
        }
    }
}
