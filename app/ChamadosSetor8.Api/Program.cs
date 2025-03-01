using ChamadosSetor8.Infra.Data.Context;
using ChamadosSetor8.Api.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using ChamadosSetor8.Business.UseCases.Users.GetAll;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//C:\Projects\study\projects\chamados-ccb\chamados-setor8-back\ChamadosSetor8\app\ChamadosSetor8.Api>dotnet ef migrations add MIGRACAO_INICIAL  --project ../ChamadosSetor8.Infra/ChamadosSetor8.Infra.csproj --output-dir Data\Migrations

builder.Services.AddDbContext<Sector8CallsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SQL_SERVER")), ServiceLifetime.Scoped);


builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining(typeof(GetAllQuery)));

builder.Services.AddCors();



//Add dependency injection in the class DependencyInjection
builder.Services.AddDependencyInjection();

var app = builder.Build();

app.UseCors(c =>
{
    c.AllowAnyHeader();
    c.AllowAnyMethod();
    c.AllowAnyOrigin();
});


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.MapGet("/", () =>
{
    string connectionString = "Server=172.18.135.87,1433;Database=ChamadosSetor8;User ID=sa;Password=@#$qweASD;Trusted_Connection=False; TrustServerCertificate=True;";

    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        try
        {
            connection.Open();
            return new("Conexão bem-sucedida!");
            // Execute consultas ou operações no banco de dados aqui, se necessário.
        }
        catch (Exception ex)
        {
            return ($"Erro de conexão: {ex.Message}");
        }
    }
});
app.Run();
