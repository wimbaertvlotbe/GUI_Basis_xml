using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GUI_Basis_xml
{

    public class Persoon
    {
        private string id;
        private string voornaam;
        private string naam;
        private DateTime geboorteDatum;

        public Persoon(string id, string naam, string voornaam, DateTime geboorteDatum)
        {
            if (TestID(id)) this.id = id; 
            this.naam = naam;
            this.voornaam = voornaam;
            if (TestGeboorteDatum(geboorteDatum)) this.geboorteDatum = geboorteDatum;
        }

        public static bool TestID(string id)
        {
            string BEIDRegex = @"[0-9]{3}\-[0-9]{7}\-[0-9]{2}";
            Match regexMatch = Regex.Match(id, BEIDRegex);

            if (regexMatch.Success)
            {
                return true;
            }
            return false;
        }

        public static bool TestGeboorteDatum(DateTime geboortedatum)
        {
            return (geboortedatum <= DateTime.Now)? true : false;
        }

        public string ID
        {
            get { return id; }
            set 
            { 
                if (TestID(value)) id = value;
            }
        }

        public string Naam
        {
            get { return naam; }
            set { this.naam = value; }
        }

        public string Voornaam
        {
            get { return voornaam; }
            set { this.voornaam = value; }
        }

        public DateTime GeboorteDatum
        {
            get { return geboorteDatum; }
            set 
            { 
                if (TestGeboorteDatum(value)) geboorteDatum = value;        
            }
        }

        public static string MaakID()
        {
            string uid = string.Empty;

            for (int i = 0; i < 3; i++)
            {
                uid += new Random().Next(0, 10);
            }

            uid += "-";

            for (int i = 0; i < 7; i++)
            {
                uid += new Random().Next(0, 10);
            }

            uid += "-";

            for (int i = 0; i < 2; i++)
            {
                uid += new Random().Next(0, 10);
            }

            return uid;
        }

        public override string ToString()
        {
            string s = $"{id:20}\t{geboorteDatum.Date.ToString("dd/mm/yyyy"):20}\t{naam:50}\t{voornaam:50}";
            return s;
        }
    }
}
