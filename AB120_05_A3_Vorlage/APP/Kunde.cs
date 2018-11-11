using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB120_05_A3_Vorlage.APP
{
 
    static class Kunde
    {
       
        public static List<DB.Kunde> ReadingAll()
        {
            using (var db = new DB.M120Datenbank())
            {
                return (from rec in db.Kunde select rec).ToList();
            }
        }
       
        public static DB.Kunde Lesen_KundeID(Int64 kundenID)
        {
            using (var db = new DB.M120Datenbank())
            {
                return (from rec in db.Kunde where rec.KundeID == kundenID select rec).FirstOrDefault();
            }
        }

        
        public static List<DB.Kunde> Lesen_Name(string kundeName)
        {
            using (var db = new DB.M120Datenbank())
            {
                return (from rec in db.Kunde where rec.Name == kundeName select rec).ToList();
            }
        }

        public static List<DB.Kunde> Lesen_NameWie(string kundeName)
        {
            using (var db = new DB.M120Datenbank())
            {
                return (from rec in db.Kunde where rec.Name.Contains(kundeName) select rec).ToList();
            }
        }

        public static List<DB.Kunde> Lesen_ReiseID(Int64 reiseID)
        {
            using (var db = new DB.M120Datenbank())
            {
                return (from rec in db.Kunde join rk in db.Kunde_Reise on rec.KundeID equals rk.Kunde where rk.Reise == reiseID select rec).ToList();
            }
        }

        public static long Erstellen(DB.Kunde Kunde)
        {
            if (Kunde.Anrede == null) Kunde.Anrede = "";
            if (Kunde.Email == null) Kunde.Email = "";
            if (Kunde.Geburtsdatum == null) Kunde.Geburtsdatum = DateTime.Today;
            if (Kunde.Mobile == null) Kunde.Mobile = "";
            if (Kunde.Name == null) Kunde.Name = "";
            if (Kunde.NameZusatz == null) Kunde.NameZusatz = "";
            if (Kunde.Ort == null) Kunde.Ort = "";
            if (Kunde.PassNr == null) Kunde.PassNr = "";
            if (Kunde.StrasseNr == null) Kunde.StrasseNr = "";
            if (Kunde.Telefon == null) Kunde.Telefon = "";
            if (Kunde.Vorname == null) Kunde.Vorname = "";
            if (Kunde.Web == null) Kunde.Web = "";
            if (Kunde.Nationalitaet == 0) Kunde.Nationalitaet = 192;
            using (var db = new DB.M120Datenbank())
            {
                db.Kunde.Add(Kunde);
                db.SaveChanges();
                db.Entry(Kunde).Reload();
                return Kunde.KundeID;
            }
        }
   
        public static void Aktualisieren(DB.Kunde Kunde)
        {
            using (var DB = new DB.M120Datenbank())
            {
                DB.Entry(Kunde).State = System.Data.Entity.EntityState.Modified;
                DB.SaveChanges();
            }
        }
      
        public static void Loeschen(DB.Kunde Kunde)
        {
            using (var DB = new DB.M120Datenbank())
            {
                DB.Entry(Kunde).State = System.Data.Entity.EntityState.Deleted;
                DB.SaveChanges();
            }
        }

        public static void Loeschen(DB.Reise Single)
        {
            throw new NotImplementedException();
        }
    }
}
