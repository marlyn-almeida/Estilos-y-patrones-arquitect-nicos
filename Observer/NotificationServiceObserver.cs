using System;
using System.Collections.Generic;

// Interfaz para los observadores
public interface IObserver {
    void Update(string message);
}

// Clase concreta que implementa el observador
public class User : IObserver {
    private string name;

    public User(string name) {
        this.name = name;
    }

    public void Update(string message) {
        Console.WriteLine($"{name} received: {message}");
    }
}

// Clase que implementa el sujeto observado
public class NotificationService {
    private List<IObserver> observers = new List<IObserver>();

    // Método para suscribir observadores
    public void Subscribe(IObserver observer) {
        observers.Add(observer);
    }

    // Método para notificar a los observadores
    public void NotifyObservers(string message) {
        foreach (var observer in observers) {
            observer.Update(message);
        }
    }
}

// Uso del patrón Observer
class Program {
    static void Main(string[] args) {
        NotificationService service = new NotificationService();
        service.Subscribe(new User("Alice"));
        service.Subscribe(new User("Bob"));

        service.NotifyObservers("New update available!");
    }
}
