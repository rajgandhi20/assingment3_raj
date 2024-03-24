using System;

class Program
{
    static void Main(string[] args)
    {
        RentalAgency agency = new RentalAgency();

        // Sample vehicles
        Car car1 = new Car("Toyota Camry", "Toyota", 2022, 50.0m, 5, "V6", "Automatic", false);
        Truck truck1 = new Truck("Ford F-150", "Ford", 2021, 70.0m, 4, "Pickup", true);
        Motorcycle bike1 = new Motorcycle("Honda CBR1000RR", "Honda", 2020, 100.0m, 1000, "Petrol", true);

        // Adding vehicles to the fleet
        agency.AddVehicle(car1);
        agency.AddVehicle(truck1);
        agency.AddVehicle(bike1);

        // Displaying fleet details
        agency.DisplayFleet();

        // Renting a vehicle
        Console.WriteLine("\nRenting a vehicle...");
        agency.RentVehicle(car1);
        Console.ReadLine();

        // Displaying updated fleet details and total revenue
        Console.WriteLine("\nUpdated Fleet After Renting:");
        agency.DisplayFleet();
        Console.WriteLine($"\nTotal Revenue: {agency.TotalRevenue:C}");
        Console.ReadLine();
    }
}
