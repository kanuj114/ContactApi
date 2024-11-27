using ContactsAPI.Database;
using ContactsAPI.Functionality;
using ContactsAPI.Implementation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

// Add services to the container.[Add ContactOperations,ContactDbContext]
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// Now, Dont need to create object of ContactDbContext Class explicitly using new() operator
// .NetCore provides unity Container to create an object of ContactDbContext class(Object created per session)
builder.Services.AddDbContext<ContactsDbContext>(t=>t.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); 
// Mapping of automapper class
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());// Applied Reflection to find,where automapper defined
// Need to apply per call architecture
builder.Services.AddTransient<IContactsOperation,ContactOperation>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
