﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SegundoParcial.Models
{
    public class LlamadasDetalle
    {
        [Key]
        public int DetalleId { get; set; }
        public int LlamadaId { get; set; }

        public string Problema { get; set; }
        public string Solucion { get; set; }
        


        public LlamadasDetalle()
        {
            DetalleId = 0;
            Problema = string.Empty;
            Solucion = string.Empty;
        }
    }
}
