using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System;

namespace Serialization
{
    [XmlRoot("New Employees", Namespace = "www.nerdinc.ninja")]
    public class Employee
    {
        [XmlAttribute("Employee ID")]
        public int ID { get; set; }
        [XmlAttribute("Full Name")]
        public string Name { get; set; }
        [XmlAttribute("Social Security Number")]
        public double SSNumber { get; set; }
        [XmlAttribute("Today's Date")]
        public DateTime EntryDate { get; set; }
        [XmlIgnore]
        public string JobRole { get; set; }
    }

}
