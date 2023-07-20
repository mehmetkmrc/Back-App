namespace UdemyJwtApp.Back.Infrastructure.Tools
{
    public class JwtTokenDefaults
    {
        /*
            ValidAudience = "http://localhost",
                    ValidIssuer = "http://localhost",
                    ClockSkew = TimeSpan.Zero,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes
                     ("mehmetmehmetmehmet1.")),
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime=true,         
         */
        public const string ValidAudience = "http://localhost";
        public const string ValidIssuer = "http://localhost";
        public const string Key = "mehmetmehmetmehmet1.";
        public const int Expire = 5;
    }
}
