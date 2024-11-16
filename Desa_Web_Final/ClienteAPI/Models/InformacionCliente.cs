namespace ClienteAPI.Models  // Asegúrate de que el espacio de nombres sea el correcto
{
    public class InformacionCliente
    {
        public int ID { get; set; }  // ID de la información del cliente (clave primaria)
        public string TipoInformacion { get; set; }  // Tipo de información (dirección, contacto, etc.)
        public DateTime FechaCreacion { get; set; }  // Fecha de creación de la información
        public DateTime FechaActualizacion { get; set; }  // Fecha de la última actualización
        public string UsuarioCreador { get; set; }  // Usuario que creó la información
        public string EstadoInformacion { get; set; }  // Estado de la información (activo, inactivo, etc.)
        
        // Relación con Cliente
        public int ClienteID { get; set; }  // Relacionado con el cliente
        public Cliente Cliente { get; set; }  // Objeto Cliente relacionado
    }
}
