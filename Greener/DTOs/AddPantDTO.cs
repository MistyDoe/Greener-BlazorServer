namespace Greener.DTOs
{
    public class AddPantDTO
    {
        public string Name { get; set; }
        public string LatinName { get; set; }
        public List<DateTime> Watered { get; set; }
        public List<DateTime> Feritilized { get; set; }
        public List<DateTime> Cutting { get; set; }
        public string SoilType { get; set; }
        public DateTime Obtained { get; set; }
    }
}
