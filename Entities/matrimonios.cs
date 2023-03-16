using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
namespace G_P.Entities
{
    public class matrimonios
    {
        [Key]
        public int id { get; set; }
        public int id_matrimonio { get; set; }
        public DateTime fecha { get; set; }

       
    }
}
