using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SegundoParcial.Models
{
    public class Llamadas
    {
        [Key]
        public int LlamadaId { get; set; }
        public string Descripcion { get; set; }

        [ForeignKey("DetalleId")]
        public List<LlamadasDetalle> Detalles { get; set; }

        public Llamadas()
        {
            LlamadaId = 0;
            Descripcion = string.Empty;
            Detalles = new List<LlamadasDetalle>();
        }
    }
}
