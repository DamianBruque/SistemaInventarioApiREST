using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

public static class SecurityConfiguration
{
    public static IServiceCollection AddConfigureSecurityServices(this IServiceCollection services)
    {
        // configuramos el JWT
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options => 
            {
                // acá se configura el token y el secretKey que se usa para encriptar el token
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    // ValidateIssuerSigningKey es para validar el secretKey que se usa para encriptar el token
                    ValidateIssuerSigningKey = true,
                    // IssuerSigningKey es el secretKey que se usa para encriptar el token
                    // lo obtenemos de la variable de entorno SECRET_TOKEN_JWT que esta en el archivo secrets.env
                    IssuerSigningKey = options.TokenValidationParameters.IssuerSigningKey,
                    // ValidateLifetime es para validar el tiempo de vida del token
                    ValidateLifetime = true,
                    // ClockSkew es el tiempo de vida del token en minutos (10 minutos)
                    ClockSkew = TimeSpan.FromMinutes(10)

                };
            });

        services.AddAuthorization(options =>
        {
            // acá se configuran los roles que se van a usar en la aplicación
            options.AddPolicy("Admin", policy => policy.RequireRole("ADMIN"));
            options.AddPolicy("User", policy => policy.RequireRole("USER"));
        });


        return services;
    }

}

