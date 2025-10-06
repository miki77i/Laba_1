namespace Laba_1.Data
{
    public class Pacient
    {
        public int PacientId {  get; set; }
        public string? LastName { get; set; }
        public string? Name { get; set; }
        public string? Patronymic { get; set; }
        public DateTime? Date { get; set; }
        public string? Sex { get; set; }
        public string? diagnoz {  get; set; }
        public int PalataId { get; set; }
        public virtual Palata? Palata { get; set; }
    }
}
