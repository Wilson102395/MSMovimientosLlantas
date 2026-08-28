using Infrastructure.MovimientosLlantas.Extensiones;

var builder = WebApplication.CreateBuilder(args);

// 1. Agregamos soporte para los Controladores
builder.Services.AddControllers();

// 2. ¡AQUÍ CONECTAMOS NUESTRO CABLEADO! (Cumpliendo la regla ML2007)
builder.Services.InyeccionDependencias();

// 3. Configuración de Swagger (Nuestra página para probar la API)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 4. Activamos Swagger para poder probar sin Postman
app.UseSwagger();
app.UseSwaggerUI();

// 5. Encendemos los controladores
app.MapControllers();

// 6. ¡Arrancamos el motor!
app.Run();