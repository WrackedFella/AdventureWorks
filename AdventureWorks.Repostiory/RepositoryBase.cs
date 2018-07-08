using AdventureWorks.Core;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AdventureWorks.Repository
{
	public class RepositoryBase<TEntity, TModel>
		where TEntity : EntityBase
		where TModel : ModelBase
	{
		public RepositoryBase(DbContext context)
		{
			this.Context = context;
		}

		protected readonly DbContext Context;

		public virtual async Task Delete(int id)
		{
			var entity = await this.Context.Set<TEntity>().FindAsync(id);
			this.Context.Set<TEntity>().Remove(entity);
			this.Context.Remove(entity);
			await this.Context.SaveChangesAsync();
		}

		public virtual async Task<TModel> FindAsync(int id)
		{
			var entity = await this.Context.Set<TEntity>().FindAsync(id);
			return Mapper.Map<TModel>(entity);
		}

		public virtual async Task<IEnumerable<TModel>> Insert(params TModel[] models)
		{
			if (models.Length == 0)
			{
				throw new NullReferenceException($"An attempt was made to insert null {typeof(TModel)} data.");
			}

			List<TEntity> entities = models.Select(Mapper.Map<TEntity>).ToList();
			await this.Context.AddRangeAsync(entities);
			await this.Context.SaveChangesAsync();
			return entities.Select(Mapper.Map<TModel>).AsEnumerable();
		}

		public virtual async Task<IEnumerable<TModel>> Search(Expression<Func<TModel, bool>> predicate)
		{
			List<TModel> results = await this.Context.Set<TEntity>()
				.ProjectTo<TModel>()
				.Where(predicate)
				.ToListAsync();

			return results;
		}

		public virtual async Task<IEnumerable<TModel>> Update(params TModel[] models)
		{
			if (models.Length == 0)
			{
				throw new NullReferenceException($"An attempt was made to update null {typeof(TModel)} data.");
			}

			IEnumerable<int> updateTargetIds = models.Select(x => x.GetId());
			List<TEntity> updateTargetList =
				await this.Context.Set<TEntity>()
					.Where(x => updateTargetIds.Contains(x.GetId()))
					.ToListAsync();
			updateTargetList.ForEach(entity =>
			{
				var model = models.Single(x => x.GetId() == entity.GetId());
				Mapper.Map(model, entity);
			});
			await this.Context.SaveChangesAsync();
			return updateTargetList.Select(Mapper.Map<TModel>).AsEnumerable();
		}
	}
}
