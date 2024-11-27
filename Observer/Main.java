// Interfaz para los observadores
interface Observer {
    void update(String message);
}

// Clase concreta que implementa el observador
class User implements Observer {
    private String name;

    public User(String name) {
        this.name = name;
    }

    @Override
    public void update(String message) {
        System.out.println(name + " received: " + message);
    }
}

// Clase que implementa el sujeto observado
class NotificationService {
    private List<Observer> observers = new ArrayList<>();

    // Método para suscribir observadores
    public void subscribe(Observer observer) {
        observers.add(observer);
    }

    // Método para notificar a los observadores
    public void notifyObservers(String message) {
        for (Observer observer : observers) {
            observer.update(message);
        }
    }
}

// Uso del patrón Observer
public class Main {
    public static void main(String[] args) {
        NotificationService service = new NotificationService();
        service.subscribe(new User("Alice"));
        service.subscribe(new User("Bob"));

        service.notifyObservers("New update available!");
    }
}
