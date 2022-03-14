namespace ForExperiments
{
    public partial class User
    {
        public long Id { get; set; }
        public string Login { get; set; } = null!;
        public string Pass { get; set; } = null!;
        public string Mail { get; set; } = null!;
        public string Telegramm { get; set; } = null!;
        public string Mobile { get; set; } = null!;
    }
}