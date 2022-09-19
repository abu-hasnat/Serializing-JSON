using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using static Serializing_JSON.Model.Enum;

namespace Serializing_JSON.Model
{
    public class Route
    {
        [Key]
        public int Number { get; set; }
        public string Name { get; set; }
        public Direction Direction { get; set; }
        public bool RampAccessible { get; set; }
        public bool BicycleAccessible { get; set; }
        public virtual Queue<ScheduledStop> StopSchedule { get; set; }
    }
}
