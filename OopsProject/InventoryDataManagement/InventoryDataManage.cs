using Newtonsoft.Json;
using Oops;
using OopsDay11.InventoryDataManagment;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOps.InventoryDataManagement
{
    internal class InventoryDataManage
    {
        InventoryData inventories;
        List<Inventory> RiceList;
        List<Inventory> PulseList;
        List<Inventory> WheatList;
        public void ReadJsonFile(string file)
        {
            var jsonData = File.ReadAllText(file);
            inventories = JsonConvert.DeserializeObject<InventoryData>(jsonData);
            RiceList = inventories.Rice;
            Display(RiceList);
            PulseList = inventories.Pulse;
            Display(RiceList);
             WheatList = inventories.Wheat;
            Display(RiceList);

        }
        public void Display(List<Inventory> inventories)
        {
            foreach (var data in inventories)
            {
                Console.WriteLine(data.Name + " " + data.Weight + " " + data.Price);

            }
            Console.WriteLine();
        }
    }
}