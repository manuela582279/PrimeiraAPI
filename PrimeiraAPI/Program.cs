using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// AAdd os serviços basicos para a aplicação, como controladores e OpenAPI

builder.Services.AddControllers();
// Add OpenAPI necessario para gerar a documentção da API 
builder.Services.AddOpenApi();
//bulider.Build()=> É onde a aplicação é construida
var app = builder.Build();

//PipeLine de processamento de requisições HTTP
if (app.Environment.IsDevelopment())
{
    //Endpoint OpenAPI 
    app.MapOpenApi();
    //Interface do Scala para testar a API
    app.MapScalarApiReference(Options =>
    {
        Options.Title = "Primeira API com Scalar";
        Options.Theme = ScalarTheme.Default;
        Options.ShowSidebar = true;

    });
    /** https://dontpad.com/senai-jau-backend **/

    // Redireciona a pagina raiz "/" para "/scalar"
    app.MapGet("/", () => Results.Redirect("/scalar"));
}

//Redireciona todas as requisições HTTP para HTTPS
app.UseHttpsRedirection();
//Middleware de autenticação, necessário para proteger os endpoints da API
app.UseAuthorization();
//Mapeia os controladores para as rotas da API, permitindo que as requisições sejam processadas pelos métodos dos controladores
app.MapControllers();
//Inicia a aplicação, permitindo que ela comece a ouvir as requisições HTTP e processe-as de acordo com as rotas e controladores definidos
app.Run();
