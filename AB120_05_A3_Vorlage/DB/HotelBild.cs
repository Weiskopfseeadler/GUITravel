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
    using System.Windows.Documents;

    public partial class HotelBild
    {
        public long BildID { get; set; }
        public long HotelID { get; set; }
        public int Reihenfolge { get; set; }
        public byte[] Bild { get; set; }
        public string Beschreibung { get; set; }
    
        public virtual Hotel Hotel { get; set; }

        public static implicit operator HotelBild(List v)
        {
            throw new NotImplementedException();
        }
    }
}