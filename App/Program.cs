using DataAccess;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddProjectContextSqlServer();    // DBContext SqlServer
//builder.Services.AddProjectContextSQLite();       // DBContext Sqlite
builder.Services.AddProjectContextOracle();         // DBContext Oracle
builder.Services.AddRepositories();                 // Repositories
builder.Services.AddServices();                     // Services
builder.Services.AddConfigureSecurityServices();    // Security

// agregamos el secrets.env
builder.Configuration.AddEnvironmentVariables();
string secretKey = builder.Configuration["SECRET_TOKEN_JWT"];



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
// iniciamos la base de datos con EnsureCreated
using (var serviceScope = app.Services.CreateScope())
{
    var context = serviceScope.ServiceProvider.GetRequiredService<ProjectContext>();
    context.Database.Migrate();
}
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.MapControllers();

app.Run();
