namespace Periodico.Console
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Noticia")]
    public partial class Noticia
    {
        [Key]
        public int Codigo { get; set; }

        [StringLength(50)]
        public string TituloNoticia { get; set; }

        public string ContenidoNoticia { get; set; }

        public DateTime? Fecha { get; set; }

        public long? AutorCodigo { get; set; }

        public int? EstadoCodigo { get; set; }

        public virtual Autor Autor { get; set; }

        public virtual Estado Estado { get; set; }
    }
}
