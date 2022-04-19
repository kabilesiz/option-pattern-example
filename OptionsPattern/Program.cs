using OptionsPattern;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOptions<JwtInfo>().Bind(builder.Configuration.GetSection("Settings:JwtInfo"));
builder.Services.AddSingleton<IJwtInfoService, JwtInfoService>();

var app = builder.Build();

app.MapGet("/", (IJwtInfoService jwtInfoService) =>
{
    return jwtInfoService.GetJwtInfo();
});

app.Run();