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
    public partial class AddCarForm : Form
    {
        private Car car;
        Button addBCar;
        Button cancelButtonAddForm;
        Label makeLabel;
        Label modelLabel;
        TextBox makeTextBox;
        TextBox modelTextBox;
        Inventory inventory = new Inventory();
        FileHandler fileHandler;

        public AddCarForm(Inventory _inventory,FileHandler fileHandler)
        {
            this.fileHandler = fileHandler;
            this.inventory = _inventory;
            InitializeComponent();
        }




        private void AddButton_Click(object sender, EventArgs e)
        {
           
            car = new Car
            {
                Make = makeTextBox.Text,
                Model = modelTextBox.Text,
                Mileage= Convert.ToInt32(mileageTextBox.Text),
                Price=Convert.ToDecimal(priceTextBox.Text),    
                VIN= vinTextBox.Text,
                Color=colorTextBox.Text,
                Year = Convert.ToInt32(yearTextBox.Text)   
            };
            inventory.AddCar(car);
            //MessageBox.Show("Car added succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fileHandler.SaveInventoryToFile(inventory);
            makeTextBox.Clear();
            modelTextBox.Clear();
            mileageTextBox.Clear();
            priceTextBox.Clear();
            vinTextBox.Clear();
            yearTextBox.Clear();
            colorTextBox.Clear();
            return;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public Car GetCar()
        {
            return car;
        }

        private void modelLabel_Click(object sender, EventArgs e)
        {

        }

        private void vinTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void makeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
