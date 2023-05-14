namespace UniversityApiBackend.Models.DataModels
{
    public class JwtSettings
    {
        public bool ValidateIssuerSigningKey { get; set; }
        public string IssuerSigningKey { get; set; } = string.Empty;

        public bool ValidateIssuer { get; set; } = true;
        public string? ValidIssuer { get; set; }

        public bool validateAudience { get; set; } = true;
        public string? ValidAudience { get; set;}

        public bool RequireExpirationTime { get; set; }
        public bool Validatelifetime { get; set; } = true;


    }
}
