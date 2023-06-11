using Microsoft.EntityFrameworkCore;
using bzbackend.Data;
using bzbackend.Interfaces;
using bzbackend.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IBeritaRepository, BeritaRepository>();
builder.Services.AddScoped<IJemaatRepository, JemaatRepository>();
builder.Services.AddScoped<IJIbadahRepository, JIbadahRepository>();
builder.Services.AddScoped<IRenunganRepository, RenunganRepository>();
builder.Services.AddScoped<IRole, RoleRepository>();
builder.Services.AddScoped<ISektor, SektorRepository>();
builder.Services.AddScoped<IUsers, UserRepository>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

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

app.Run();
