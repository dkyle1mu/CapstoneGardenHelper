using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace GardenHelper.Server
{
    public class Plant
    {
        public int ID { get; set; }
        [Display(Name = "Watering Interval (Hours):")]
        public int WaterInterval { get; set; }
        [Display(Name = "Hours to Next Watering:")]
        public int TimeTillWater { get; set; }
        [Display(Name = "Fertilizing Interval (Hours):")]
        public int? FertilizerInterval { get; set; }
        [Display(Name = "Hours to Next Fertilizing:")]
        public int? TimeTillFertilizer { get; set; }
        [Display(Name = "Type of Maintenance:")]
        public string? MaintenanceType { get; set; }
        [Display(Name = "Maintenance Interval (Hours):")]
        public int? MaintenanceInterval { get; set; }
        [Display(Name = "Hours to Next Maintenance:")]
        public int? TimeTillMaintenance { get; set; }
        public string? Name { get; set; }
        //photo
        [DataType(DataType.Date)]
        [Display(Name = "Date Planted:")]
        public DateTime? PlantedDate { get; set; }
        //type
        //Display needs to convert bool to Yes or No
        [Display(Name = "Currently Growing?")]
        public bool Growing { get; set; }
    }
}
