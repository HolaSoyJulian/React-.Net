using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crud_API.Models
{
    [Table("objeto")]
    public class Objeto
    {
        [Key]
        public long id { get; set; }

        public string nombre { get; set; }

        public string descripcion { get; set; }

        public double precio { get; set; }

        public DateTime fecha_creacion { get; set; }
    }
}
