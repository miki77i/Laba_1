namespace Laba_1.Data
{
    public class Palata
    {
        public int PalataId { get; set; }
        public int? NumPalata { get; set; }
        public int? TotalBed { get; set; }
        public int OtdelenieId { get; set; }
        public ICollection<Pacient>? Pacients { get; set; }
        public virtual Otdelenie? Otdelenie { get; set; }
    }
}
