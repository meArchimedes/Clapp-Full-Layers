using App_Services.Services;
using Microsoft.Extensions.Hosting.WindowsServices;
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
    ApplicationName = typeof(Program).Assembly.FullName,
    ContentRootPath = Path.GetFullPath(Directory.GetCurrentDirectory()),
    WebRootPath = "wwwroot",
    Args = args
});
//var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://example.com",
                                              "http://www.contoso.com");
                      });
});
builder.Services.AddControllers();
//builder.Services.AddCors();
builder.Services.AddAppServices();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddControllersWithViews()
    .AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
   
    app.UseExceptionHandler("/Error");

}
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    //app.UseSwaggerUI();
}

app.UseCors(x => x
           .AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader());

app.UseHttpsRedirection();

app.MapControllers();

app.UseStaticFiles();

app.UseRouting();
//app.UseCors(MyAllowSpecificOrigins);
app.UseAuthorization();

//app.MapRazorPages();

app.Run();



//var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddControllers();
//builder.Services.AddCors();
//builder.Services.AddAppServices();
////builder.Services.AddAutoMapper();
//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


//var app = builder.Build();

////app.UseCors(options =>
////{
////    options.WithOrigins("http://localhost:4000").AllowAnyHeader().AllowAnyMethod();
////});
//app.UseCors((builder) =>
//{
//    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
//});
//app.MapControllers();
//app.Run();















