using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Garden_Helper_Site.Models
{
    public class Plant
    {
        public int ID { get; set; }
        [Display(Name = "Watering Interval (Hours):")]
        public int water_interval { get; set; }
        [Display(Name = "Hours to Next Watering:")]
        public int time_till_water { get; set; }
        [Display(Name = "Fertilizing Interval (Hours):")]
        public int? fertilizer_interval { get; set; }
        [Display(Name = "Hours to Next Fertilizing:")]
        public int? time_till_fertilizer { get; set; }
        [Display(Name = "Type of Maintenance:")]
        public string? maintenance_type { get; set; }
        [Display(Name = "Maintenance Interval (Hours):")]
        public int? maintenance_interval { get; set; }
        [Display(Name = "Hours to Next Maintenance:")]
        public int? time_till_maintenance { get; set; }
        public string? Name { get; set; }
        //photo
        [DataType(DataType.Date)]
        [Display(Name = "Date Planted:")]
        public DateTime plant_date { get; set; }
        //type
        [Display(Name = "Currently Growing?")]
        //Display needs to convert bool to Yes or No
        public bool growing { get; set; }
    }
}
