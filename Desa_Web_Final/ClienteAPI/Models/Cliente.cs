namespace ClienteAPI.Models  // Asegúrate de que el espacio de nombres sea el correcto
{
    public class Cliente
    {
        public int ID { get; set; }  // ID del cliente (clave primaria)
        public string Nombres { get; set; }  // Nombre del cliente
        public string Apellidos { get; set; }  // Apellido del cliente
        public string Genero { get; set; }  // Género del cliente
        public DateTime FechaNacimiento { get; set; }  // Fecha de nacimiento
        public string Estado { get; set; }  // Estado del cliente (activo, inactivo, etc.)
    }
}
