using Stripe;
using Stripe_demo.Helper;
using Stripe_demo.Service;

var builder = WebApplication.CreateBuilder(args);
StripeConfiguration.ApiKey = "sk_test_51NpsJWHYvvcpRTWUfcph694bxQ2b22rDlTMQI4rURqpA83mnlRIlTmyaday6odnbCNZyhmTofJMjyMeBA4v6cVga00xCzhxnSb";


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IStripeService , StripeService>();
builder.Services.Configure<StripeSetting>(builder.Configuration.GetSection("StripeSettings"));
var app = builder.Build();
app.UseCors(builder => builder
            .AllowAnyHeader()
            .AllowAnyMethod()
            .SetIsOriginAllowed((host) => true)
            .AllowCredentials());
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
