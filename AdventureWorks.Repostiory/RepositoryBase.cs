using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.Core;
using System.Linq;
using AutoMapper.QueryableExtensions;

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

		public virtual async Task<ModelBase> Get(int id)
		{
			var entity = await this.Context.Set<TEntity>().FindAsync(id);
			return Mapper.Map<TModel>(entity);
		}

		public virtual async Task<IEnumerable<ModelBase>> Search(Expression<Func<ModelBase, bool>> predicate)
		{
			var results = await this.Context.Set<TEntity>()
				.ProjectTo<TModel>()
				.Where(predicate)
				.ToListAsync();

			return results;
		}

		public virtual async Task<ModelBase> Update(ModelBase model)
		{
			var id = model.GetId();
			var entity = await this.Context.Set<TEntity>().FindAsync(id);
			Mapper.Map(model, entity);
			await this.Context.SaveChangesAsync();
			return await Get(id);
		}

		public virtual async Task<ModelBase> Insert(ModelBase model)
		{
			var entity = Mapper.Map<TEntity>(model);
			await this.Context.AddAsync(entity);
			await this.Context.SaveChangesAsync();
			return await Get(entity.Id);
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
