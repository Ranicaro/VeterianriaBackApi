namespace VeterianriaBackApi.Models
{
    public class tblMascotas
    {
        public tblMascotas() 
        {
            tblHistoriaClinicaiIDMascotaNavigation = new HashSet<tblHistoriaClinica>();
        }
        public int iIDMascota { get; set; }
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
        

        public virtual tblUsuarios iIDUsuarioCreacionNavigation { get; set; }
        public virtual tblUsuarios iIDUsuarioModificacionNavigation { get; set; }
        public virtual tblUsuarios iIDUsuarioInactivacionNavigation { get; set; }

        public virtual tblUsuarios iIDDuennoNavigation { get; set; }

        public virtual ICollection<tblHistoriaClinica> tblHistoriaClinicaiIDMascotaNavigation { get; set; }
    }
}
