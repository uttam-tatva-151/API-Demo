using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Web_API.Extensions;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDatabase(builder.Configuration);
builder.Services.AddRepositories();
builder.Services.AddServices();

builder.Services.AddApiVersioning(options =>
{
    // Default version if none specified
    options.DefaultApiVersion = new ApiVersion(1, 0);

    // Assume default version when not specified in the URL
    options.AssumeDefaultVersionWhenUnspecified = true;

    // Report supported API versions in response headers
    options.ReportApiVersions = true;

    // Versioning via URL segment
    options.ApiVersionReader = new UrlSegmentApiVersionReader();
});

// Add Versioned API Explorer (for Swagger if needed)
builder.Services.AddVersionedApiExplorer(options =>
{
    options.GroupNameFormat = "'v'VVV"; // Formats like v1.7, v2.4
    options.SubstituteApiVersionInUrl = true;
});

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
