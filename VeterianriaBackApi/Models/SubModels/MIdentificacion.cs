namespace VeterianriaBackApi.Models.SubModels
{
    public class MIdentificacion
    {
        public int? iIDIdentificacion { get; set; }
        public string? tSiglasIdentificacion { get; set; }
        public string? tIdentificacion { get; set; }
        public int? iIDUsuarioCreacion { get; set; }
        public DateTime? dtFechaCreacion { get; set; }
        public int? iIDUsuarioModificacion { get; set; }
        public DateTime? dtFechaModificacion { get; set; }
        public int? iIDUsuarioInactivacion { get; set; }
        public DateTime? dtFechaInactivacion { get; set; }
        public bool? bActivo { get; set; }
    }
    public class MListaIdentificacion
    {
        public int? iIDIdentificacion { get; set; }
        public string? tSiglasIdentificacion { get; set; }
        public string? tIdentificacion { get; set; }
    }
}
