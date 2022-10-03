using BlackJackServer.Interfaces;
using BlackJackServer.Models;
using BlackJackServer.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(o => o.AddPolicy("CORSPolicy", builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
}));

builder.Services.AddMvc(options => options.EnableEndpointRouting = false)
                .AddControllersAsServices(); // this adds the controllers as services to all for DI to resolve them 

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "BlackJackServer", Version = "v1" });
}); ;

// add custom services 
builder.Services.AddTransient<IAppVersionService, AppVersionService>();
builder.Services.AddSingleton<IBlackJack, BlackJackService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseDeveloperExceptionPage();
app.UseHttpsRedirection();
app.UseCors("CORSPolicy");
app.UseSwagger();
app.UseSwaggerUI(c => {

    c.SwaggerEndpoint("/swagger/v1/swagger.json", "BlackJackServer v1");

});

app.UseStaticFiles();
app.UseMvc();

app.Run();
