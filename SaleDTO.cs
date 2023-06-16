

namespace CarDealership
{
    public class SaleDTO
    {
        public SaleDTO(Sale sale) {
            CarVIN = sale.Car.VIN;
            CustomerEmail = sale.Customer.Email;
            CustomerName = sale.Customer.Name;  
            CustomerPhone = sale.Customer.Phone;
            SaleDate = sale.SaleDate;   
        }
        public string CarVIN { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
