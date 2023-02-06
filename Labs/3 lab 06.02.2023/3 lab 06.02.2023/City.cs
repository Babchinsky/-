using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _3_lab_06._02._2023
{
    public class City
    {
        private string name_city;
        private string name_country;
        private int residents;
        private string phone_code;
        private string[] areas;

        public City()
        {
            name_city = null;
            name_country = null;
            residents = 0;
            phone_code= null;
            areas = null;
        }

        public City(string name_city, string name_country, int residents, string phone_code, string[] areas)
        {
            this.name_city = name_city;
            this.name_country = name_country;
            this.residents = residents;
            this.phone_code = phone_code;
            this.areas = areas;
        }

        internal string Name_City 
        {
            get { return name_city; } 
            set { name_city = value; } 
        }
        internal string Name_Country
        {
            get { return name_country; }
            set { name_country = value; }
        }
        internal int Residents
        {
            get { return residents; }
            set { residents = value; }
        }
        internal string Phone_Code
        {
            get { return phone_code; }
            set { phone_code = value; }
        }
        internal string[] Areas
        {
            get { return areas; }
            set { areas = value;}
        }

        public override string ToString()
        {
            string areas_buf = string.Empty;
            for (int i = 0; i < areas.Length; i++)
            {
                areas_buf += areas[i] + ' ';
            }

            return $"City: {name_city}\nCountry: {name_country}\nResidents: {residents}\nPhone code: {phone_code}\nAreas: {areas_buf}";
        }
    }
}
