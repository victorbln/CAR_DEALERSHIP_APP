using CAR_DEALERSHIP.ModelsLibrary;

using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Xml;

namespace CAR_DEALERSHIP.DataStorageLevel
{
    public class CarsInventoryStorageManager
    {
        private string storageFile;

        public CarsInventoryStorageManager(string storageFile)
        {
            this.storageFile = storageFile;
        }
        //implementation of saving inventory in file, reading inventory from file,and all aditional stuff that this class needs to have 
        //to be a fully implemented data storage manipulation class
        public void SaveInventory(List<Car> cars)
        {
            string json = JsonConvert.SerializeObject(cars, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(storageFile, json);
        }

        public List<Car> LoadInventory()
        {
            if (File.Exists(storageFile))
            {
                string json = File.ReadAllText(storageFile);
                return JsonConvert.DeserializeObject<List<Car>>(json);
            }
            return new List<Car>();
        }

    }
}
