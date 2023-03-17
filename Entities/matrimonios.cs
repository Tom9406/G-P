
using System.ComponentModel.DataAnnotations;
namespace G_P.Entities
{
    public class matrimonios
    {
        [Key]
        public int id { get; set; }
        public int id_matrimonio { get; set; }
        public DateTime fecha { get; set; }

        public int id_inscripion { get; set; }

        public int id_tramite { get; set; }

        public int id_anulacion { get; set; }

        public string id_referencia { get; set; }


    }
}
