using CAR_DEALERSHIP.ModelsLibrary;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAR_DEALERSHIP.DataStorageLevel
{
    public class CarsInventoryManager
    {
        private string storageFile;

        public CarsInventoryManager(string storageFile)
        {
            this.storageFile = storageFile;
        }

        internal void AddCars(Car car)
        {
            return;
        }

        internal void GetCars(out int nrStudenti)
        {
            nrStudenti = 1;
            return;
        }
    }
}
