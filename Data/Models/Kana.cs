namespace KanaTrainer.Data.Models
{
    public class Kana
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string KanaOriginal { get; set; }
        public string KanaRomaji { get; set; }
        public string KanaType { get; set; }
    }
}
