namespace Laba_1.Data
{
    public class Otdelenie
    {
        public int OtdelenieId { get; set; }
        public string? OtdelenieName { get; set; }
        public string? ZavOtdelenie { get; set; }
        public int? TotalPalat {  get; set; }
        public ICollection<Palata>? Palatas { get; set; }
    }
}
