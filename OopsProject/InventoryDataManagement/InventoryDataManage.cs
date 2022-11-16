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
            WheatList = inventories.Wheat;
            Display(WheatList);
            PulseList = inventories.Pulse;
            Display(PulseList);

        }
        public void Display(List<Inventory> inventories)
        {
            foreach (var data in inventories)
            {
                Console.WriteLine(data.Name + " " + data.Weight + " " + data.Price);

            }
            Console.WriteLine();
        }
        public void EditData(string name,string option)
        {
            Console.WriteLine("Name");
            switch (option)
            {
                 
                case "Rice":
                    Console.WriteLine("Rice");
                    foreach (var data in RiceList)
                    {
                        if (data.Name == name)
                        {
                            data.Name = "K";
                            data.Price = 12.0;
                            data.Weight = 21;
                        }
                    }
                    break;

                case "Wheat":
                    Console.WriteLine("Wheat");
                    foreach (var data in WheatList)
                    {
                        if (data.Name == name)
                        {
                            data.Name = "P";
                            data.Price = 10.0;
                            data.Weight = 11;
                        }
                    }
                    break;
                 case "Pulse":
                    Console.WriteLine("Pulse");

                    foreach (var pulse in PulseList)
                    {
                        
                        Console.Write("enter name : ");
                        string nameRice = Console.ReadLine();
                        Console.WriteLine( pulse.Name.Equals(nameRice));
                        if  (pulse.Name.Equals(nameRice))
                        {
                            Console.WriteLine("Pulses here");
                            pulse.Name = "V";
                            pulse.Price = 12.0;
                            pulse.Weight = 21;

                        }
                    }
                    break;            
            }
            

        }
        public void DeleteData(string name, string option)
        {
            
            switch (option)
            {

                case "Rice":
                    try
                    {
                        foreach (var rice in RiceList)
                        {
                            if (rice.Name.Equals(name))
                            {
                                RiceList.Remove(rice);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;




                case "Wheat":
                        try
                        {
                            foreach (var Wheat in WheatList)
                            {
                                if (Wheat.Name.Equals(name))
                                {
                                    WheatList.Remove(Wheat);
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                case "Pulse":
                    try
                    {
                        foreach (var Pulse in PulseList)
                        {
                            if (Pulse.Name.Equals(name))
                            {
                                WheatList.Remove(Pulse);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;

            }


        }
        public void AddData(string inventoryName)
        {
            Inventory inventory = new Inventory();
            switch (inventoryName)
            {
                case "Rice":
                    
                    inventory.Name = Console.ReadLine();
                    inventory.Weight = Convert.ToInt32(Console.ReadLine());
                    inventory.Price = Convert.ToDouble(Console.ReadLine());
                    RiceList.Add(inventory);
                    break;
                case "Wheat":
                    
                    inventory.Name = Console.ReadLine();
                    inventory.Weight = Convert.ToInt32(Console.ReadLine());
                    inventory.Price = Convert.ToDouble(Console.ReadLine());
                    WheatList.Add(inventory);
                    break;
                case "Pulse":
                   
                    inventory.Name = Console.ReadLine();
                    inventory.Weight = Convert.ToInt32(Console.ReadLine());
                    inventory.Price = Convert.ToDouble(Console.ReadLine());
                    PulseList.Add(inventory);
                    break;
            }
        }

        public void WriteJsonFile(string file)
        {
            var json = JsonConvert.SerializeObject(inventories);
            File.WriteAllText(file, json);
        }
    }
}