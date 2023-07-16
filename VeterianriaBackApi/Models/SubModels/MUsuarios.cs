namespace VeterianriaBackApi.Models.SubModels
{
    public class MUsuarios
    {
        public int? iIDUsuario { get; set; }
        public int? iIDTipoIdentificacion { get; set; }
        public string? tNumeroIdentificacion { get; set; }
        public string? tPrimerNombre { get; set; }
        public string? tSegundoNombre { get; set; }
        public string? tPrimerApellido { get; set; }
        public string? tSegundoApellido { get; set; }
        public string? tNumeroTelefono { get; set; }
        public string? tDireccion { get; set; }
        public string? tCorreo { get; set; }
        public string? tContrasenna { get; set; }
        public int? iIDUsuarioCreacion { get; set; }
        public DateTime? dtFechaCreacion { get; set; }
        public int? iIDUsuarioModificacion { get; set; }
        public DateTime? dtFechaModificacion { get; set; }
        public int? iIDUsuarioInactivacion { get; set; }
        public DateTime? dtFechaInactivacion { get; set; }
        public bool? bActivo { get; set; }
        public int? iIDRol { get; set; }
    }
    public class MListaUsuarios
    {
        public int? iIDUsuario { get; set; }
        public int? iIDTipoIdentificacion { get; set; }
        public string? tTipoIdentificacion { get; set; }
        public string? tNumeroIdentificacion { get; set; }
        public string? tPrimerNombre { get; set; }
        public string? tSegundoNombre { get; set; }
        public string? tPrimerApellido { get; set; }
        public string? tSegundoApellido { get; set; }
        public string? tNumeroTelefono { get; set; }
        public string? tDireccion { get; set; }
        public string? tCorreo { get; set; }
        public int? iIDUsuarioCreacion { get; set; }
        public string? tUsuarioCreacion { get; set; }
        public DateTime? dtFechaCreacion { get; set; }    
        public int? iIDRol { get; set; }
        public string? tRol { get; set; }
    }
    public class UsuarioNombre
    {
        public string? tUsuarioNombre { get; set; }
    }
}
