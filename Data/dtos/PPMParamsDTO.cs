namespace ValveService.Data.dtos;

    public class PPMParamsDTO
    {
        public int ValveTypeId { get; set; }
        public int Size { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }

        public PPMParamsDTO()
        {
            ValveTypeId = 0;
            Size = 0;
            Weight = 0;
            Height = 0;
        }

    }
    