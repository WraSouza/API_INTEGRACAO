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

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<LoginRequest>(builder.Configuration.GetSection("SAPLogin"));

builder.Services.AddSingleton<LoginHelper>();

builder.Services.AddSingleton<IItemRepository, ItemSAPRepository>();
builder.Services.AddSingleton<IOrdersRepository, OrdersRepository>();

builder.Services.AddMemoryCache();

builder.Services.AddMediatR(cfg => { cfg.RegisterServicesFromAssemblies(typeof(GetAllItemsQuery).Assembly); });

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGroup("")
.ItemsEndpoint()
.WithTags("SAP - Items");

app.MapGroup("")
.SalesEndpoint()
.WithTags("Magento - Sales");



app.UseHttpsRedirection();



app.Run();

