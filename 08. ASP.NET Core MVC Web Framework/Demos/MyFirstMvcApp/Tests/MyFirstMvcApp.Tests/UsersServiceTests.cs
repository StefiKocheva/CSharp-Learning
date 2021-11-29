using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstMvcApp.Tests
{
    public class UsersServiceTests
    {
        private async Task<ApplicationDbContext> GetDbContext()
        {
            var users = new List<IdentityUser>
            {
                new IdentityUser {userName = "Pesho1", Email = "abv@abv.g" },
                new IdentityUser {userName = "Pesho2", Email = "zzzzz@abv.g" },
                new IdentityUser {userName = "Pesho3", Email = "ppppp@abv.g" },
            };

            var optionsBuilder = new DbContextoptionsBuilder<ApplicationDbContext>()
                                    .UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbContext = new ApplicationDbContext(optionsBuilder.Options);

            foreach (var user in users)
            {
                await dbContext.Users.AddAsync(user);
            }

            await dbContext.SaveChangesAsync();

            return dbContext;
        }

        [Fact]
        public async Task LatestUsernameShouldReturnCorrectValuseWhenSortedByEmail()
        {
            var dbContext = await this.GetDbContext();
            var service = new UsersService(dbContext);

            var actual = service.LatestUsername("email");

            Assert.Equals("Pesho2", actual);
        }
    }
}
