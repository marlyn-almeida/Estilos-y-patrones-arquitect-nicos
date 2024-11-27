# Clase base para observadores
class Observer:
    def update(self, message):
        pass

# Clase concreta que implementa el observador
class User(Observer):
    def __init__(self, name):
        self.name = name

    def update(self, message):
        print(f"{self.name} received: {message}")

# Clase que implementa el sujeto observado
class NotificationService:
    def __init__(self):
        self.observers = []

    # Método para suscribir observadores
    def subscribe(self, observer):
        self.observers.append(observer)

    # Método para notificar a los observadores
    def notify_observers(self, message):
        for observer in self.observers:
            observer.update(message)

# Uso del patrón Observer
service = NotificationService()
service.subscribe(User("Alice"))
service.subscribe(User("Bob"))

service.notify_observers("New update available!")
