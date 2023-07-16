using VeterianriaBackApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("http://localhost:4200", "*").AllowAnyMethod().AllowAnyHeader();
}));

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder => builder.WithOrigins("http://localhost:4200") // Aquí debes colocar la URL de tu frontend
                          .AllowAnyMethod()
                          .AllowAnyHeader()
                          .AllowCredentials());
});

var connectionString = builder.Configuration.GetConnectionString("SQLConnection");
builder.Services.AddDbContext<DBVeterinariaV1Context>(options =>
 options.UseSqlServer(connectionString)
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseCors("corsapp");
app.UseCors("CorsPolicy");
app.Run();
