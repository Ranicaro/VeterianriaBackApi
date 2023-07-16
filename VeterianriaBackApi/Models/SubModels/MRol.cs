namespace VeterianriaBackApi.Models.SubModels
{
    public class MRol
    {
        public int? iIDRol { get; set; }
        public string? tRol { get; set; }
        public string? tDescripcion { get; set; }
        public int? iIDUsuarioCreacion { get; set; }
        public DateTime? dtFechaCreacion { get; set; }
        public int? iIDUsuarioModificacion { get; set; }
        public DateTime? dtFechaModificacion { get; set; }
        public int? iIDUsuarioInactivacion { get; set; }
        public DateTime? dtFechaInactivacion { get; set; }
        public bool? bActivo { get; set; }
    }
    public class MListaRol
    {
        public int? iIDRol { get; set; }
        public string? tRol { get; set; }
        public string? tDescripcion { get; set; }
    }
}
