﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DAL.DO.Objects
{
    public partial class Autores
    {
        public Autores()
        {
            Libros = new HashSet<Libros>();
        }

        public string Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Creacion { get; set; }
        public bool Activo { get; set; }
        public DateTime? Desactivacion { get; set; }
        public string DesactivadoPor { get; set; }
        public string CreadoPor { get; set; }
        //public string? PaisId { get; set; }

        // public virtual Pais Pais { get; set; }
        public virtual ICollection<Libros> Libros { get; set; }
    }
}
