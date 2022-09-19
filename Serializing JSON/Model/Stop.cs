using System.ComponentModel.DataAnnotations;
using static Serializing_JSON.Model.Enum;

namespace Serializing_JSON.Model
{
    public class Stop
    {
        [Key]
        public int Number { get; set; }
        public string Street { get; set; }
        public string Name { get; set; }
        public Direction Direction { get; set; }
        public virtual List<ScheduledStop> StopSchedules { get; set; }
    }
}
