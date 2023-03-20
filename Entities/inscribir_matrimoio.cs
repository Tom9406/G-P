using System.ComponentModel.DataAnnotations;

namespace G_P.Entities
{
    public class inscribir_matrimoio
    {
        [Key]
        public int id { get; set; }

        public string contrayente_1_nombre { get; set; }

        public string contrayente_1_apellido_1 { get; set; }

        public string contrayente_1_apellido_2 { get; set; }

        public string madre_contrayente_1_nombre { get; set; }

        public string madre_contrayente_1_apellido_1 { get; set; }

        public string madre_contrayente_1_apellido_2 { get; set; }

        public string padre_contrayente_1_nombre { get; set; }

        public string padre_contrayente_1_apellido_1 { get; set; }

        public string padre_contrayente_1_apellido_2 { get; set; }

        public DateTime fecha_nacimiento_contrayente_1 { get; set; }

        public string municipio_nacimiento_contrayente_1 { get; set; }

        public string provincia_nacimiento_contrayente_1 { get; set; }

        public string observaciones_contrayente_1 { get; set; }

        public string contrayente_2_nombre { get; set; }

        public string contrayente_2_apellido_1 { get; set; }

        public string contrayente_2_apellido_2 { get; set; }

        public string madre_contrayente_2_nombre { get; set; }

        public string madre_contrayente_2_apellido_1 { get; set; }

        public string madre_contrayente_2_apellido_2 { get; set; }

        public string padre_contrayente_2_nombre { get; set; }

        public string padre_contrayente_2_apellido_1 { get; set; }

        public string padre_contrayente_2_apellido_2 { get; set; }

        public DateTime fecha_nacimiento_contrayente_2 { get; set; }

        public string municipio_nacimiento_contrayente_2 { get; set; }

        public string provincia_nacimiento_contrayente_2 { get; set; }

        public string observaciones_contrayente_2 { get; set; }

        public DateTime fecha_inscripcion_matrimonio { get; set; }

        public string codigo_referencia { get; set; }

        public int tomo { get; set; }

        public int folio { get; set; }

        public string municipio { get; set; }

        public string provincia { get; set; }

    }
}
