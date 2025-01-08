
using CadastroUsuario.Shared.Notificacoes;
using CadastroUsuario.Shared.Validador;

namespace CadastroUsuario.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

       

            builder.Services.AddControllers();
 
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            builder.Services.AddScoped<INotificacaoDominio, NotificacaoDominio>();
            builder.Services.AddScoped<UsuarioValidador>();


            var app = builder.Build();


        
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
