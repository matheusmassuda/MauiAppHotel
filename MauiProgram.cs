using Microsoft.Extensions.Logging;

namespace MauiAppHotel
{
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
                    fonts.AddFont("Karla-Bold.ttf", "KarlaBold");
                    fonts.AddFont("Karla-ExtraBold.ttf", "KarlaExtraBold");
                    fonts.AddFont("Karla-Light.ttf", "KarlaLight");
                    fonts.AddFont("Karla-Medium.ttf", "KarlaMedium");
                    fonts.AddFont("Karla-Regular.ttf", "Karla");

                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
