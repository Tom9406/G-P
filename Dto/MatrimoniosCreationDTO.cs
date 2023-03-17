using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.VisualBasic;

namespace G_P.Dto
{
    public class MatrimoniosCreationDTO
    {
        public int id_matrimonio { get; set; }
        public DateTime fecha { get; set; }
        public int id_inscripion { get; set; }

        public int id_tramite { get; set; }

        public int id_anulacion { get; set; }

        public string id_referencia { get; set; }
    }
}
