// Clase que implementa el patrón Singleton
public sealed class DatabaseConnection {
    // Instancia única de la clase
    private static DatabaseConnection instance = null;
    private static readonly object padlock = new object();

    // Constructor privado para evitar instancias externas
    private DatabaseConnection() { }

    // Propiedad estática para obtener la instancia única
    public static DatabaseConnection Instance {
        get {
            lock (padlock) {
                if (instance == null) {
                    instance = new DatabaseConnection();
                }
                return instance;
            }
        }
    }

    // Método de ejemplo que representa una acción de la conexión
    public void Connect() {
        Console.WriteLine("Connecting to the database...");
    }
}

// Uso del patrón Singleton
class Program {
    static void Main(string[] args) {
        DatabaseConnection connection = DatabaseConnection.Instance;
        connection.Connect();
    }
}
