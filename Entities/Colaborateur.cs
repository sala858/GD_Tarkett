namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Colaborateur")]
    public partial class Colaborateur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Colaborateur()
        {
            DemandeVisa = new HashSet<DemandeVisa>();
            Deplacement = new HashSet<Deplacement>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Nom { get; set; }

        [StringLength(50)]
        public string Prenom { get; set; }

        [StringLength(50)]
        public string Cin { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Poste { get; set; }

        [StringLength(50)]
        public string Equipe { get; set; }

        public int? NombreDeplacement { get; set; }

        public int? Anciennete { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateValiditeVisa { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateFinVisa { get; set; }

        [StringLength(50)]
        public string Sexe { get; set; }

        [StringLength(50)]
        public string Login { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DemandeVisa> DemandeVisa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Deplacement> Deplacement { get; set; }
    }
}
