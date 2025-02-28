using PetStockBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Adiciona os servi�os de controllers e Swagger (para testes)
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registra o FakeDataService como singleton
builder.Services.AddSingleton<FakeDataService>();

// Configura��o de CORS para permitir acesso da BlazorApp
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors("AllowAll");

app.UseAuthorization();
app.MapControllers();

app.Run();
