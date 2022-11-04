using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Server
{
	internal class Program
	{
		public static void Main( string[] args )
		{
			WebApplicationBuilder? builder = WebApplication.CreateBuilder( args );
			builder.Services.AddRazorPages();
			WebApplication? app = builder.Build();

			app.UseAuthentication();
			app.UseAuthorization();
			app.UseStaticFiles();
			app.MapRazorPages();
			app.Run();

		}
	}
}