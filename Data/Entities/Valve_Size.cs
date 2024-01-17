namespace ValveService.Data.Entities;
public class Valve_Size
{
 [Key]
        public int SizeId { get; set; }
        public int Size { get; set; }
        public int VTValveTypeId { get; set; }
        public float EOA { get; set; }
        public Valve_Code? VT { get; set; }
        public int ValveTypeId { get; set; }
}

