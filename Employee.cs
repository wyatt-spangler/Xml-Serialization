using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System;

namespace Employee
{
    [Serializable]
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double SSNumber { get; set; }
        public DateTime EntryDate { get; set; }
    }

}
