using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.Repository;
using National_Museum_2.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var conString = builder.Configuration.GetConnectionString("Connection");
builder.Services.AddDbContext<MuseumDbContext>(options => options.UseSqlServer(conString));

builder.Services.AddControllers();

//Register repositorys and services Tibaquicha
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<IUserTypeRepository, UserTypeRepository>();
builder.Services.AddScoped<IUserTypeService, UserTypeService>();

builder.Services.AddScoped<IPermissionXUserTypeRepository, PermissionXUserTypeRepository>();
builder.Services.AddScoped<IPermissionXUserTypeService, PermissionXUserTypeService>();

builder.Services.AddScoped<IPermissionsRepository, PermissionsRepository>();
builder.Services.AddScoped<IPermissionsService, PermissionsService>();

builder.Services.AddScoped<IIdentificationTypeRepository, IdentificationTypeRepository>();
builder.Services.AddScoped<IIdentificationTypeService, IdentificationTypeService>();

builder.Services.AddScoped<IGenderRepository, GenderRepository>();
builder.Services.AddScoped<IGenderService, GenderService>();

builder.Services.AddScoped<IContactRepository, ContactRepository>();
builder.Services.AddScoped<IContactService, ContactService>();


//Register repositorys and services Kevin Ramirez
builder.Services.AddScoped<IArtObjectRepository, ArtObjectRepository>();
builder.Services.AddScoped<IArtObjectService, ArtObjectService>();

builder.Services.AddScoped<IArtRoomRepository, ArtRoomRepository>();
builder.Services.AddScoped<IArtRoomService, ArtRoomService>();

builder.Services.AddScoped<IStateRepository, StateRepository>();
builder.Services.AddScoped<IStateService, StateService>();

builder.Services.AddScoped<ILocationRepository, LocationRepository>();
builder.Services.AddScoped<ILocationService, LocationService>();

builder.Services.AddScoped<IExhibitionRepository, ExhibitionRepository>();
builder.Services.AddScoped<IExhibitionService, ExhibitionService>();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

builder.Services.AddScoped<IScenaryRepository, ScenaryRepository>();
builder.Services.AddScoped<IScenaryService, ScenaryService>();


//Register repositorys and services Lucia
builder.Services.AddScoped<ITicketsRepository, TicketsRepository>();
builder.Services.AddScoped<ITicketsService, TicketsService>();

builder.Services.AddScoped<ITicketTypeRepository, TicketTypeRepository>();
builder.Services.AddScoped<ITicketTypeService, TicketTypeService>();

builder.Services.AddScoped<ITicketXCollectionRepository, TicketXCollectionRepository>();
builder.Services.AddScoped<ITicketXCollectionService, TicketXCollectionService>();

builder.Services.AddScoped<IPaymentMethodRepository, PaymentMethodRepository>();
builder.Services.AddScoped<IPaymentMethodService, PaymentMethodService>();


//Register repositorys and services Oscar
builder.Services.AddScoped<ICollectionRepository, CollectionRepository>();
builder.Services.AddScoped<ICollectionService, CollectionService>();

builder.Services.AddScoped<IEmployeesXArtRoomRepository, EmployeesXArtRoomRepository>();
builder.Services.AddScoped<IEmployeesXArtRoomService, EmployeesXArtRoomService>();

builder.Services.AddScoped<IMaintenanceRepository, MaintenanceRepository>();
builder.Services.AddScoped<IMaintenanceService, MaintenanceService>();

builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeesService, EmployeesService>();

builder.Services.AddScoped<ITypeEmployeeRepository, TypeEmployeeRepository>();
builder.Services.AddScoped<ITypeEmployeeService, TypeEmployeeService>();

builder.Services.AddScoped<IWorkSheduleRepository, WorkSheduleRepository>();
builder.Services.AddScoped<IWorkSheduleService, WorkSheduleService>();

builder.Services.AddScoped<IGamesRepository, GamesRepository>();
builder.Services.AddScoped<IGamesService, GamesService>();

builder.Services.AddScoped<IHistoricTicketsRepository, HistoricTicketsRepository>();
builder.Services.AddScoped<IHistoricTicketsService, HistoricTicketsService>();

builder.Services.AddScoped<IHistoricUserRepository, HistoricUserRepository>();
builder.Services.AddScoped<IHistoricUserService, HistoricUserService>();

builder.Services.AddScoped<IHistoricMaintenanceRepository, HistoricMaintenanceRepository>();
builder.Services.AddScoped<IHistoricMaintenanceService, HistoricMaintenanceService>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

app.UseAuthorization();

app.MapControllers();

app.Run();
