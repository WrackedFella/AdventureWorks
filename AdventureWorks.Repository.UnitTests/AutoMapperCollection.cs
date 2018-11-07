using System;
using System.Collections.Generic;
using System.Text;
using UnitTests.Core;
using Xunit;

namespace AdventureWorks.Repository.UnitTests
{
	[CollectionDefinition("AutoMapper")]
	public class AutoMapperCollection : ICollectionFixture<AutoMapperFixture>
	{
		// Empty, used to attach new ICollectionFixture<> definitions to this collection. 
		//  i.e. you can have multiple Fixtures to a Collection. This class lets you do it.
	}
}
