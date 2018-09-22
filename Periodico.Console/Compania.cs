namespace Periodico.Console
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Compania")]
    public partial class Compania
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Compania()
        {
            Autor = new HashSet<Autor>();
        }

        [Key]
        public long Codigo { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        public int? EstadoCodigo { get; set; }

        public int? PaisesCosifo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Autor> Autor { get; set; }

        public virtual Estado Estado { get; set; }

        public virtual Paises Paises { get; set; }
    }
}
