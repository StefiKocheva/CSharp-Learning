namespace WithoutDependancyInjection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CatService
    {
        private readonly IDbContext database;
        private readonly IRandomProvider randomProvider;
        private readonly ICurrentTimeProvider currentTimeProvider;

        public CatService(
            IDbContext database,
            IRandomProvider randomProvider,
            ICurrentTimeProvider currentTimeProvider)
        {
            this.database = database;
            this.randomProvider = randomProvider;
            this.currentTimeProvider = currentTimeProvider;
        }

        public IEnumerable<CatResult> RandomCatFromToday()
        {
            var today = this.currentTimeProvider.Now();
            var startOfToday = new DateTime(today.Year, today.Month, today.Day, 0, 0, 0);

            var random = this.randomProvider;
            var totoalCats = random.Number(10, 5);

            var allCats = this.database
                .GetCats()
                .Where(c => c.AddedOn > startOfToday)
                .Take(totoalCats)
                .Select(c => new CatResult
                {
                    Name = c.Name
                })
                .ToList();

            return allCats;
        }
    }
}
