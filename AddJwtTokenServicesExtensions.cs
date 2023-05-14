using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend
{
    public static class AddJwtTokenServicesExtensions
    {
        public static void AddJwtTokenServices(this IServiceCollection services, IConfiguration configuration) 
        {
            //Add JWT Settings
            var bindJwtSettings = new JwtSettings();

            configuration.Bind("JsonWebTokenKeys",bindJwtSettings);
        }    
    }
}
