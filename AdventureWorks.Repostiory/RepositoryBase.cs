using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AdventureWorks.Core;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository
{
	public class RepositoryBase<TEntity, TModel>
		where TEntity : EntityBase
		where TModel : ModelBase
	{
		protected readonly DbContext Context;

		public RepositoryBase(DbContext context)
		{
			this.Context = context;
		}

		public virtual async Task<TModel> Get(int id)
		{
			var entity = await this.Context.Set<TEntity>().FindAsync(id);
			return Mapper.Map<TModel>(entity);
		}

		public virtual async Task<IEnumerable<TModel>> Search(Expression<Func<TModel, bool>> predicate)
		{
			var results = await this.Context.Set<TEntity>()
				.ProjectTo<TModel>()
				.Where(predicate)
				.ToListAsync();

			return results;
		}

		public virtual async Task<TModel> Update(TModel model)
		{
			var id = model.GetId();
			var entity = await this.Context.Set<TEntity>().FindAsync(id);
			Mapper.Map(model, entity);
			await this.Context.SaveChangesAsync();
			return await Get(id);
		}

		public virtual async Task<TModel> Insert(TModel model)
		{
			var entity = Mapper.Map<TEntity>(model);
			await this.Context.AddAsync(entity);
			await this.Context.SaveChangesAsync();
			return await Get(entity.GetId());
		}

		public virtual async Task Delete(int id)
		{
			var entity = await this.Context.Set<TEntity>().FindAsync(id);
			this.Context.Set<TEntity>().Remove(entity);
			this.Context.Remove(entity);
			await this.Context.SaveChangesAsync();
		}
	}
}
