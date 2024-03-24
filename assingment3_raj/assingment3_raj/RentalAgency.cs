using System;
using System.Collections.Generic;

public class RentalAgency
{
    // Fleet to store instances of vehicles
    private List<Vehicle> Fleet { get; set; }

    // Total revenue earned by the rental agency
    public decimal TotalRevenue { get; private set; }

    // Constructor
    public RentalAgency()
    {
        Fleet = new List<Vehicle>();
        TotalRevenue = 0;
    }

    // Method to add vehicles to the fleet
    public void AddVehicle(Vehicle vehicle)
    {
        Fleet.Add(vehicle);
    }

    // Method to remove vehicles from the fleet
    public void RemoveVehicle(Vehicle vehicle)
    {
        Fleet.Remove(vehicle);
    }

    // Method to rent a vehicle
    public void RentVehicle(Vehicle vehicle)
    {
        Console.WriteLine("Vehicle Rented:");
        vehicle.DisplayDetails();
        TotalRevenue += vehicle.RentalPrice;
        RemoveVehicle(vehicle);
    }

    // Method to display all vehicles in the fleet
    public void DisplayFleet()
    {
        Console.WriteLine("Rental Agency Fleet:");
        foreach (var vehicle in Fleet)
        {
            vehicle.DisplayDetails();
            Console.WriteLine();
        }
    }
}
