namespace VeterianriaBackApi.Models
{
    public class tblUsuarios
    {
        public tblUsuarios() {

            tblRoliIDUsuarioCreacionNavigation = new HashSet<tblRol>();
            tblRoliIDUsuarioModificacionNavigation = new HashSet<tblRol>();
            tblRoliIDUsuarioInactivacionNavigation = new HashSet<tblRol>();

            tblMascotasiIDUsuarioCreacionNavigation = new HashSet<tblMascotas>();
            tblMascotasiIDUsuarioModificacionNavigation = new HashSet<tblMascotas>();
            tblMascotasiIDUsuarioInactivacionNavigation = new HashSet<tblMascotas>();
            tblMascotasiIDDuennoNavigation = new HashSet<tblMascotas>();

            tblIdentificacioniIDUsuarioCreacionNavigation = new HashSet<tblIdentificacion>();
            tblIdentificacioniIDUsuarioModificacionNavigation = new HashSet<tblIdentificacion>();
            tblIdentificacioniIDUsuarioInactivacionNavigation = new HashSet<tblIdentificacion>();

            tblHistoriaClinicaiIDUsuarioCreacionNavigation = new HashSet<tblHistoriaClinica>();
            tblHistoriaClinicaiIDUsuarioModificacionNavigation = new HashSet<tblHistoriaClinica>();
            tblHistoriaClinicaiIDUsuarioInactivacionNavigation = new HashSet<tblHistoriaClinica>();
            



        }
        public int iIDUsuario { get; set; }
        public int? iIDTipoIdentificacion { get; set; }
        public string? tNumeroIdentificacion { get; set; }
        public string?  tPrimerNombre { get; set; }
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



        public virtual tblIdentificacion iIDTipoIdentificacionNavigation { get; set; }
        public virtual tblRol iIDRolNavigation { get; set; }
        public virtual ICollection<tblRol> tblRoliIDUsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tblRol> tblRoliIDUsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tblRol> tblRoliIDUsuarioInactivacionNavigation { get; set; }

        public virtual ICollection<tblMascotas> tblMascotasiIDUsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tblMascotas> tblMascotasiIDUsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tblMascotas> tblMascotasiIDUsuarioInactivacionNavigation { get; set; }        
        public virtual ICollection<tblMascotas> tblMascotasiIDDuennoNavigation { get; set; }

        public virtual ICollection<tblIdentificacion> tblIdentificacioniIDUsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tblIdentificacion> tblIdentificacioniIDUsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tblIdentificacion> tblIdentificacioniIDUsuarioInactivacionNavigation { get; set; }

        public virtual ICollection<tblHistoriaClinica> tblHistoriaClinicaiIDUsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tblHistoriaClinica> tblHistoriaClinicaiIDUsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tblHistoriaClinica> tblHistoriaClinicaiIDUsuarioInactivacionNavigation { get; set; }
        
    }
}
