//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AB120_05_A3_Vorlage.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reise
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reise()
        {
            this.Kunde_Reise = new HashSet<Kunde_Reise>();
            this.Reise_Hotel = new HashSet<Reise_Hotel>();
        }
    
        public long            ReiseID      { get; set; }
        public long            Land         { get; set; }
        public System.DateTime Start        { get; set; }
        public System.DateTime Ende         { get; set; }
        public decimal         Preis        { get; set; }
        public bool            Leitung      { get; set; }
        public string          NameLeitung  { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kunde_Reise> Kunde_Reise { get; set; }
        public virtual Land Land1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reise_Hotel> Reise_Hotel { get; set; }
    }
}
