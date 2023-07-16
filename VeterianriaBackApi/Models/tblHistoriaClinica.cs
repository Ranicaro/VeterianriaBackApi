namespace VeterianriaBackApi.Models
{
    public class tblHistoriaClinica
    {
        public int iIDHistoriaClinica { get; set; }
        public string? tTemperatura { get; set; }
        public string? tPeso { get; set; }
        public string? tEstadoAnimo { get; set; }
        public string? tDiagnostico { get; set; }
        public int? iIDMascota { get; set; }
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

        public virtual tblMascotas iIDMascotaNavigation { get; set; }
    }
}
