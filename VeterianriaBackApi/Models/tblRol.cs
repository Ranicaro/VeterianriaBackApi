namespace VeterianriaBackApi.Models
{
    public class tblRol
    {
        public tblRol() {
            tblUsuariosNavigation = new HashSet<tblUsuarios>();
        }
        public int iIDRol { get; set; }
        public string? tRol { get; set; }
        public string? tDescripcion { get; set; }
        public int? iIDUsuarioCreacion { get; set; }
        public DateTime? dtFechaCreacion { get; set; }
        public int? iIDUsuarioModificacion { get; set; }
        public DateTime? dtFechaModificacion { get; set; }
        public int? iIDUsuarioInactivacion { get; set; }
        public DateTime? dtFechaInactivacion { get; set; }
        public bool? bActivo { get; set; }




        public virtual tblUsuarios iIDUsuarioCreacionNavigation { get; set; }
        public virtual tblUsuarios iIDUsuarioModificacionNavigation { get; set; }
        public virtual tblUsuarios iIDUsuarioInactivacionNavigation { get; set; }
        public virtual ICollection<tblUsuarios> tblUsuariosNavigation { get; set; }
    }
}
