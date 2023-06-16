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
    public partial class salesForm : Form
    {
        SalesManager salesManager;
        public salesForm(SalesManager salesManager)
        {
            InitializeComponent();
            this.salesManager = salesManager;
            loadSales();
        }
        public void loadSales()
        {
            salesDataGrid.DataSource = null;
            List<Sale> sales = salesManager.GetAllSales();
            List<SaleDTO> saleDTOs = new List<SaleDTO>();
            foreach (Sale s in sales)
            {
                saleDTOs.Add(new SaleDTO(s));
            }
            salesDataGrid.DataSource = saleDTOs;
        }

    }
}
