using ApiMokymai.Services;
using System.Reflection;

namespace ApiMokymai
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                               .AllowAnyMethod()
                               .AllowAnyHeader();
                    });
            });
            // Add services to the container.
            builder.Services.AddTransient<IMyOperationTransient, GuidService>();
            builder.Services.AddScoped<IMyOperationScoped, GuidService>();
            builder.Services.AddSingleton<IMyOperationSingleton, GuidService>();
            builder.Services.AddTransient<IBadService, BadService>();
            builder.Services.AddHttpClient("FakeApi", client => {
                client.BaseAddress = new Uri(builder.Configuration["ExternalServices:FakeApiUri"]);
                client.Timeout = TimeSpan.FromSeconds(10);
                client.DefaultRequestHeaders.Clear();
            });
            builder.Services.AddTransient<IFakeApiProxyService, FakeApiProxyService>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(option =>
            {
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                option.IncludeXmlComments(xmlPath, includeControllerXmlComments: true);
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
            app.UseCors();

            app.Run();
        }
    }
}