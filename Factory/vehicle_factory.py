# Clases que representan productos (Car y Bike)
class Car:
    def drive(self):
        print("Driving a car.")

class Bike:
    def drive(self):
        print("Riding a bike.")

# Clase Factory para crear objetos
class VehicleFactory:
    @staticmethod
    def get_vehicle(vehicle_type):
        if vehicle_type == "Car":
            return Car()
        elif vehicle_type == "Bike":
            return Bike()

# Uso del patrón Factory
vehicle = VehicleFactory.get_vehicle("Car")
vehicle.drive()
