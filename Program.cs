
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Example using dependency injection.");

// 2.- This is the container of dependencies.
var services = new ServiceCollection();

services.AddSingleton<ITranslation, GoogleTranslation>()
    .AddSingleton<MainPage>()
    .BuildServiceProvider()
    .GetService<MainPage>()
    ?.Button_Clicked();