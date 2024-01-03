namespace automation_dph.src.Api
{
    public class LoginResponseField
    {
        public static bool? Success { get; set; }
        public static string? ApiKey { get; set; }
        public static string? ClientId { get; set; }
        public static string? SessionToken { get; set; }
        public static string? ErrorResults { get; set; }
        public static string? ResponseResults { get; set; }
    }
}