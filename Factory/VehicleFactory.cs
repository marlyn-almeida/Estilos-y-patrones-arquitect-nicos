// Interfaces y clases que implementan el patrón Factory
public interface IVehicle {
    void Drive();
}

public class Car : IVehicle {
    public void Drive() {
        Console.WriteLine("Driving a car.");
    }
}

public class Bike : IVehicle {
    public void Drive() {
        Console.WriteLine("Riding a bike.");
    }
}

// Clase Factory para crear objetos IVehicle
public class VehicleFactory {
    public static IVehicle GetVehicle(string type) {
        if (type == "Car") return new Car();
        if (type == "Bike") return new Bike();
        return null;
    }
}

// Uso del patrón Factory
class Program {
    static void Main(string[] args) {
        IVehicle vehicle = VehicleFactory.GetVehicle("Car");
        vehicle.Drive();
    }
}
