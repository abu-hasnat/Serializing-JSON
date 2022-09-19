using System.ComponentModel.DataAnnotations;

namespace Serializing_JSON.Model
{
    public class ScheduledStop
    {
        [Key]
        public int Id { get; set; }
        public virtual Stop Stop { get; set; }
        public virtual Model.Route Route { get; set; }
        public DateTime ScheduledArrival { get; set; }
    }
}
