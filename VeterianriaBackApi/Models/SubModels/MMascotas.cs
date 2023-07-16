namespace VeterianriaBackApi.Models.SubModels
{
    public class MMascotas
    {
        public int? iIDMascota { get; set; }
        public string? tNombreMascota { get; set; }
        public string? tEspecie { get; set; }
        public string? tRaza { get; set; }
        public DateTime? dtFechaNacimiento { get; set; }
        public int? iIDDuenno { get; set; }
        public int? iIDUsuarioCreacion { get; set; }
        public DateTime? dtFechaCreacion { get; set; }
        public int? iIDUsuarioModificacion { get; set; }
        public DateTime? dtFechaModificacion { get; set; }
        public int? iIDUsuarioInactivacion { get; set; }
        public DateTime? dtFechaInactivacion { get; set; }
        public bool? bActivo { get; set; }
    }
    public class MListaMacotas
    {
        public int? iIDMascota { get; set; }
        public string? tNombreMascota { get; set; }
        public string? tEspecie { get; set; }
        public string? tRaza { get; set; }
        public DateTime? dtFechaNacimiento { get; set; }
        public int? iIDDuenno { get; set; }
        public string? tNombreDuenno { get; set; }
        public string? tTelefonoDuenno { get; set; }
    }
    public class MListarMascotasId
    {
        public int? iIDMascota { get; set; }
    }
    public class MEliminarMascotasId
    {
        public int? iIDMascota { get; set; }
    }
}
