using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Garden_Helper_Site.Models
{
    public class Plant
    {
        public int ID { get; set; }
        public int water_interval { get; set; }
        public int time_till_water { get; set; }
        public int? fertilizer_interval { get; set; }
        public int? time_till_fertilizer { get; set; }
        public string? maintenance_type { get; set; }
        public int? maintenance_interval { get; set; }
        public int? time_till_maintenance { get; set; }
        public string? Name { get; set; }
        //photo
        [DataType(DataType.Date)]
        public DateTime plant_date { get; set; }
        //type
        public bool growing { get; set; }
    }
}
