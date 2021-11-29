namespace DependancyInjectionExercise
{
    using System.Collections.Generic;

    public interface IDbContext
    {
        List<Cat> GetCats();
    }
}
