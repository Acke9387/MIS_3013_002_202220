using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Classes_Pharmaceutical_Drugs
{
    public class Drug
    {
        public String Name { get; set; }
        public String Company { get; set; }
        public String Brand { get; set; }
        public int Code { get; set; }
        public String StreetName { get; set; }

        public Drug()
        {
            Name = string.Empty;
            Company = string.Empty;
            Brand = string.Empty;
            Code = 0;
            StreetName = string.Empty;

        }

        /// <summary>
        /// -----------------------------
        /// |+ | Drug (company : string)   |
        /// |  |                        |
        /// -----------------------------
        /// </summary>
        public Drug(string comp)
        {
            Name = string.Empty;
            Company = comp;
            Brand = string.Empty;
            Code = 0;
            StreetName = string.Empty;
        }


        public override string ToString()
        {
            return $"{StreetName} - {Company} : {Code.ToString("G0")}";
        }

    }
}
