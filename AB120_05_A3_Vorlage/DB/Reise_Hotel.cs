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
    
    public partial class Reise_Hotel
    {
        public long Reise_Hotel_ID { get; set; }
        public long Reise { get; set; }
        public long Hotel { get; set; }
    
        public virtual Hotel Hotel1 { get; set; }
        public virtual Reise Reise1 { get; set; }
    }
}