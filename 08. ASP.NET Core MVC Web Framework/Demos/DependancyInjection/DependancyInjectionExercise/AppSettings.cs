namespace DependancyInjectionExercise
{
    public class AppSettings : IAppSettings
    {
        public string ConnectionString { get; } = "My Cool Cat";
    }
}