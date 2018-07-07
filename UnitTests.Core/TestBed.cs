using AdventureWorks.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace UnitTests.Core
{
	public abstract class TestBed
	{
		protected virtual AdventureWorksContext GenerateContext()
		{
			var serviceProvider = new ServiceCollection()
				.AddEntityFrameworkInMemoryDatabase()
				.AddEntityFrameworkProxies()
				.BuildServiceProvider();

			DbContextOptions<AdventureWorksContext> options = new DbContextOptionsBuilder<AdventureWorksContext>()
				.UseInMemoryDatabase("MockDb")
				.UseLazyLoadingProxies()
				//Without this line, data will persist between tests.
				// May be desirable, under certain conditions.
				.UseInternalServiceProvider(serviceProvider)
				.EnableSensitiveDataLogging()
				.Options;

			return new AdventureWorksContext(options);
		}
	}
}
