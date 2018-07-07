using AdventureWorks.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace UnitTests.Core
{
	public abstract class MockDbContext
	{
		protected virtual AdventureWorksContext GenerateContext()
		{
			var serviceProvider = new ServiceCollection()
				.AddEntityFrameworkInMemoryDatabase()
				.BuildServiceProvider();

			DbContextOptions<AdventureWorksContext> options = new DbContextOptionsBuilder<AdventureWorksContext>()
				.UseInMemoryDatabase("MockSmartDb")
				//Without this line, data will persist between tests.
				// May be desirable, under certain conditions.
				.UseInternalServiceProvider(serviceProvider)
				.EnableSensitiveDataLogging()
				.Options;

			return new AdventureWorksContext(options);
		}
	}
}
