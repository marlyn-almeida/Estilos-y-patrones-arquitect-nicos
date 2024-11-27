// Interfaces y clases que implementan el patrón Factory
interface Vehicle {
    void drive();
}

class Car implements Vehicle {
    public void drive() {
        System.out.println("Driving a car.");
    }
}

class Bike implements Vehicle {
    public void drive() {
        System.out.println("Riding a bike.");
    }
}

// Clase Factory para crear objetos Vehicle
class VehicleFactory {
    public static Vehicle getVehicle(String type) {
        if (type.equalsIgnoreCase("Car")) {
            return new Car();
        } else if (type.equalsIgnoreCase("Bike")) {
            return new Bike();
        }
        return null;
    }
}

// Uso del patrón Factory
public class Main {
    public static void main(String[] args) {
        Vehicle car = VehicleFactory.getVehicle("Car");
        car.drive();
    }
}
