namespace VeterianriaBackApi.Models
{
    public class tblIdentificacion
    {
        public tblIdentificacion()
        {
            tblUsuariosNavigation = new HashSet<tblUsuarios>();
        }
        public int iIDIdentificacion { get; set; }
        public string? tSiglasIdentificacion { get; set; }
        public string? tIdentificacion { get; set; }
        public int? iIDUsuarioCreacion { get; set; }
        public DateTime? dtFechaCreacion { get; set; }
        public int? iIDUsuarioModificacion { get; set; }
        public DateTime? dtFechaModificacion { get; set; }
        public int? iIDUsuarioInactivacion { get; set; }
        public DateTime? dtFechaInactivacion { get; set; }
        public bool? bActivo { get; set; }


        public virtual ICollection<tblUsuarios> tblUsuariosNavigation { get; set; }

        public virtual tblUsuarios iIDUsuarioCreacionNavigation { get; set; }
        public virtual tblUsuarios iIDUsuarioModificacionNavigation { get; set; }
        public virtual tblUsuarios iIDUsuarioInactivacionNavigation { get; set; }



    }

}
