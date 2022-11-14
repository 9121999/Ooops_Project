using OopsProject.InventoryData;

namespace OopsConceptProject
{
    internal class Program
    {

        static string inventoryDataFilePath = @"D:\217.NetBatch\Ooops_Project\OopsProject\InventoryData\Inventory.json";

        static void Main(string[] args)
        {
            InventoryManagement inventory = new InventoryManagement();
            inventory.ReadJsonFile(inventoryDataFilePath);


        }
    }
}
