// Clase que implementa el patrón Singleton
public class DatabaseConnection {
    // Única instancia de la clase
    private static DatabaseConnection instance;

    // Constructor privado para evitar instancias externas
    private DatabaseConnection() { }

    // Método estático para obtener la instancia única
    public static DatabaseConnection getInstance() {
        if (instance == null) {
            instance = new DatabaseConnection();
        }
        return instance;
    }

    // Método de ejemplo que representa una acción de la conexión
    public void connect() {
        System.out.println("Connecting to the database...");
    }
}

// Uso del patrón Singleton
public class Main {
    public static void main(String[] args) {
        DatabaseConnection connection = DatabaseConnection.getInstance();
        connection.connect();
    }
}
