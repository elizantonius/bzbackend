using Microsoft.EntityFrameworkCore;
using bzbackend.Data;
using bzbackend.Interfaces;
using bzbackend.Repository;
using Microsoft.AspNetCore.Identity;
//using bzbackend.Migrations;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ??
    throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");


builder.Services.AddDbContext<AppDataContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});



builder.Services.AddControllers();
builder.Services.AddScoped<IBeritaRepository, BeritaRepository>();
builder.Services.AddScoped<IJIbadahRepository, JIbadahRepository>();
builder.Services.AddScoped<IJemaatRepository, JemaatRepository>();
builder.Services.AddScoped<IRenunganRepository, RenunganRepository>();
builder.Services.AddScoped<IRole, RoleRepository>();
builder.Services.AddScoped<ISektor, SektorRepository>();
builder.Services.AddScoped<IUsers, UserRepository>();
builder.Services.AddScoped<IKeluarga, KepalaKeluargaRepository>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthorization();
builder.Services.AddIdentityApiEndpoints<IdentityUser>().AddEntityFrameworkStores<AppDataContext>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapIdentityApi<IdentityUser>();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
