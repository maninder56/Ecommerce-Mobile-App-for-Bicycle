using Microsoft.Extensions.Logging;
using Shop_Bike.Services;
using Shop_Bike.ViewModels;
using Shop_Bike.Views;

namespace Shop_Bike;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);
        builder.Services.AddSingleton<IGeolocation>(Geolocation.Default);
        builder.Services.AddSingleton<IMap>(Map.Default);

        builder.Services.AddSingleton<BikeService>();

		builder.Services.AddSingleton<HomePageViewModel>();
		builder.Services.AddTransient<BikeDetailViewModel>();
		builder.Services.AddTransient<MapViewModel>();

		builder.Services.AddSingleton<HomePage>();
		builder.Services.AddTransient<BikeDetailPage>();
		builder.Services.AddSingleton<AboutPage>();
		builder.Services.AddTransient<MapPage>();
		builder.Services.AddSingleton<AccountPage>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
