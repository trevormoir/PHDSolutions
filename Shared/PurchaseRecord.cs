using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace PHDSolutions.Shared
{
    public class PurchaseRecord
    {
        [Key]
        public int uid { get; set; }
        public string PONumber { get; set; }
        [XmlElement("partNumber")]
        public string partNumber { get; set; }
        [XmlElement("quantity")]
        public double quantity { get; set; }
        [XmlElement("costPer")]
        public double costPer { get; set; }
        [XmlElement("purchaser")]
        public string purchaser { get; set; }
        [XmlElement("project")]
        public string projet { get; set; }
    }
}
