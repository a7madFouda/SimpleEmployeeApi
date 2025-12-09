using EmployeeManagementFileApi;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

const string filePath = "employees.json";

app.MapPost("/api/employees", async (Employee employee) =>
{
    List<Employee> employees = new List<Employee>();

    if (File.Exists(filePath))
    {
        var json = await File.ReadAllTextAsync(filePath);
        if (!string.IsNullOrWhiteSpace(json))
        {
            employees = JsonSerializer.Deserialize<List<Employee>>(json) ?? new List<Employee>();
        }
    }

    employees.Add(employee);

    var updatedJson = JsonSerializer.Serialize(employees, new JsonSerializerOptions { WriteIndented = true });
    await File.WriteAllTextAsync(filePath, updatedJson);

    return Results.Created($"/api/employees", employee);
});

app.MapGet("/api/employees", async () =>
{
    if (!File.Exists(filePath))
    {
        return Results.Ok(new List<Employee>());
    }

    var json = await File.ReadAllTextAsync(filePath);
    if (string.IsNullOrWhiteSpace(json))
    {
        return Results.Ok(new List<Employee>());
    }

    var employees = JsonSerializer.Deserialize<List<Employee>>(json) ?? new List<Employee>();
    return Results.Ok(employees);
});

app.Run();