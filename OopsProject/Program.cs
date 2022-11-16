
using OOps.InventoryDataManagement;
using OopsDay11.InventoryDataManagment;

namespace OopsProject
{
    internal class Program
    {
        static string inventoryDataFilePath = @"D:\217.NetBatch\Ooops_Project\OopsProject\InventoryDataManagement\InventoryData.Json";
        static void Main(string[] args)
        {
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Enter 1.InventoryData 2.InventoryDataManage 3.Edit 4.Delete " +
                    "5.Add" );
                int option = Convert.ToInt32(Console.ReadLine());
                //InventoryData  inventoryMang = new InventoryData();
                InventoryDataManage inventoryDataMange = new InventoryDataManage();
                switch (option)
                {
                    case 1:
                        inventoryDataMange.ReadJsonFile(inventoryDataFilePath);
                        
                        break;
                    case 2:
                        inventoryDataMange.ReadJsonFile(inventoryDataFilePath);
                        Console.WriteLine("enter name");
                        string food = Console.ReadLine();
                        inventoryDataMange.AddData(food);
                        inventoryDataMange.WriteJsonFile(inventoryDataFilePath);
                        break;
                    case 4:
                        inventoryDataMange.ReadJsonFile(inventoryDataFilePath);
                        Console.WriteLine("enter name");
                        string name  = Console.ReadLine();
                        Console.WriteLine("enter food");
                        string food1 = Console.ReadLine();
                        inventoryDataMange.EditData( name, food1);
                        inventoryDataMange.WriteJsonFile(inventoryDataFilePath);
                        break;

                    default:

                        flag = false;
                        break;
                }
            }
        }
    }
}
             
            
            
           /* InventoryDataManage inventoryData = new InventoryDataManage();
            inventoryData.ReadJsonFile(inventoryDataFilePath);
            Console.WriteLine("Enter Name");
            //string name = Console.ReadLine();
            Console.WriteLine("Enter Food Name");
            string food = Console.ReadLine();
            
            inventoryData.AddData(food);
            inventoryData.WriteJsonFile(inventoryDataFilePath);
            inventoryData.ReadJsonFile(inventoryDataFilePath);*/
            

       