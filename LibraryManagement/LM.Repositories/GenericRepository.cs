using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Data;
using System.Data.Entity;

namespace LM.Repositories
{
    public partial class GenericRepository<T> where T : DbContext, IDisposable
    {
        private bool _disposed = false;

        public T Context { get; set; }

        public GenericRepository()
        {
            Context = Activator.CreateInstance<T>();
            Context.Configuration.AutoDetectChangesEnabled = false;
        }

        public GenericRepository(T context)
        {
            Context = context;
            Context.Configuration.ProxyCreationEnabled = false;
            Context.Configuration.LazyLoadingEnabled = false;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        public virtual TEntity GetById<TEntity>(object id) where TEntity : class
        {
            return Context.Set<TEntity>().Find(id);
        }

        public IQueryable<TEntity> All<TEntity>() where TEntity : class
        {
            return Context.Set<TEntity>().AsQueryable();
        }

        public IQueryable<TEntity> AllWithoutTracking<TEntity>() where TEntity : class
        {
            return Context.Set<TEntity>().AsQueryable().AsNoTracking();
        }

        public IQueryable<TEntity> GetManyWhere<TEntity>(Expression<Func<TEntity, bool>> expression) where TEntity : class
        {
            return Context.Set<TEntity>().Where(expression);
        }

        public IQueryable<TEntity> GetManyWhereWithoutTracking<TEntity>(Expression<Func<TEntity, bool>> expression) where TEntity : class
        {
            return Context.Set<TEntity>().Where(expression).AsNoTracking();
        }

        public void Add<TEntity>(TEntity entity) where TEntity : class
        {
            Context.Set<TEntity>().Add(entity);
        }

        public void Add<TEntity>(List<TEntity> entityList) where TEntity : class
        {
            foreach (TEntity entity in entityList)
            {
                Context.Set<TEntity>().Add(entity);
            }
        }

        public void Delete<TEntity>(TEntity entity) where TEntity : class
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public void Update<TEntity>(TEntity entity) where TEntity : class
        {
            Context.Entry<TEntity>(entity).State = EntityState.Modified;
        }

        public void Commit()
        {
            try
            {
                Context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }


            
        }

        public void IntiailizeDate<TEntity>(TEntity entity) where TEntity : class
        {
            if (entity != null)
            {
                Context.Entry<TEntity>(entity).Property("DateCreated").CurrentValue = DateTime.Now;
                Context.Entry<TEntity>(entity).Property("DateModified").CurrentValue = DateTime.Now;
            }
        }
    }
}
