# Clase que implementa el patrón Singleton
class DatabaseConnection:
    _instance = None

    # Método mágico para controlar la creación de instancias
    def __new__(cls):
        if cls._instance is None:
            cls._instance = super(DatabaseConnection, cls).__new__(cls)
        return cls._instance

    # Método de ejemplo que representa una acción de la conexión
    def connect(self):
        print("Connecting to the database...")

# Uso del patrón Singleton
connection = DatabaseConnection()
connection.connect()
