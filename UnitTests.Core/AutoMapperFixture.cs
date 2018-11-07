using System;
using AutoMapper;

namespace UnitTests.Core
{
	public class AutoMapperFixture : IDisposable
	{
		public void Dispose()
		{
			Mapper.Reset();
		}
	}
}
