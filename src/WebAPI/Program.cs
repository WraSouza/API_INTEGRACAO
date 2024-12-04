using System.Reflection;
using Application.Queries.QueriesSAP.GetAllItems;
using Domain.Entities.SAPEntities;
using Domain.Repositories.MagentoRepositories;
using Domain.Repositories.SAPRepositories;
using Infrastructure.Helpers;
using Infrastructure.Repositories.RepositoriesMagento;
using Infrastructure.Repositories.RepositoriesSAP;
using WebAPI.Controllers.ControllersMagento;
using WebAPI.Controllers.ControllersSAP;
using Scalar.AspNetCore;
using Microsoft.OpenApi;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseSentry(o => {
    o.Dsn = "https://0d5ba6a121cd5f197096e60bf3e6256c@o4508410133479424.ingest.us.sentry.io/4508410276478976";
              // When configuring for the first time, to see what the SDK is doing:
              o.Debug = true;
              // Set TracesSampleRate to 1.0 to capture 100%
              // of transactions for tracing.
              // We recommend adjusting this value in production
              o.TracesSampleRate = 1.0;
});

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<LoginRequest>(builder.Configuration.GetSection("SAPLogin"));

builder.Services.AddSingleton<LoginHelper>();

builder.Services.AddSingleton<IItemRepository, ItemSAPRepository>();
builder.Services.AddSingleton<IOrdersRepository, OrdersRepository>();


builder.Services.AddMemoryCache();
builder.Services.AddOutputCache();

builder.Services.AddMediatR(cfg => { cfg.RegisterServicesFromAssemblies(typeof(GetAllItemsQuery).Assembly); });

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(options =>
    {
        options.RouteTemplate = "/openapi/{documentName}.json";
    });
    app.MapScalarApiReference();
    //app.UseSwagger();
    //app.UseSwaggerUI();
}



app.MapGroup("")
.ItemsEndpoint()
.WithTags("SAP - Items");

app.MapGroup("")
.SalesEndpoint()
.WithTags("Magento - Sales");

app.UseHttpsRedirection();

app.UseOutputCache();

app.Run();

