using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_lab_06._02._2023
{
    public class Plane
    {
        private string model;
        private string manufacturer;
        private string year_of_issue;
        private string type;

        public Plane()
        {
            model= string.Empty;
            manufacturer= string.Empty; 
            year_of_issue= string.Empty;
            type= string.Empty;
        }
        
        public Plane(string model, string manufacturer, string year_of_issue, string type)
        {
            this.model= model;
            this.manufacturer= manufacturer;
            this.year_of_issue = year_of_issue;
            this.type= type;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public string YearOfIssue
        { 
            get { return year_of_issue;}
            set { year_of_issue = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public override string ToString()
        {
            return  $"Model: {model}\nManufacturer: {manufacturer}\nYear of issue: {year_of_issue}\nType: {type}";
        }
    }

}
