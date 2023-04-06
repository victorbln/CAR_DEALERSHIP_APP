using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAR_DEALERSHIP.ModelsLibrary
{
    public class Car
    {

        public Car() {
            this.Name = this.Year = this.Producer = this.Description = string.Empty;
        }
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Year { get; set; }
        public string? Producer { get; set; }
        public int? Amount { get; set; } = 0;
    }
}
