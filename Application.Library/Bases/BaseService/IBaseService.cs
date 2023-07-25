using Application.Library.DatabaseContext;
using Domain.Library.Bases;
using Domain.Library.Entities;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Library.Bases.BaseService
{
    public interface IBaseService
    {
    }
    public abstract class BaseService<TEntity> : IBaseService where TEntity : class
    {
        private readonly IDatabaseContext _context;
        protected BaseService(IDatabaseContext context)
        {
            _context = context;
        }
        public void Create(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }
        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }
        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }
        
    }

    public abstract class GenericService<TEntity, TDTO, TView> : BaseService<TEntity>
        where TEntity : BaseEntity
        where TDTO : BaseDTO
        where TView : BaseView
    {
        private readonly IDatabaseContext _context;
        protected GenericService(IDatabaseContext context) : base(context)
        {
            _context = context;
        }
        public IEnumerable<TView> GetAll()
        {
            return (IEnumerable<TView>)_context.Set<TEntity>().ToList();
        }
        public TView GetEntity(long id)
        {
            return (TView)(IEntity)_context.Set<TEntity>().Find(id);
        }
    }

    

}
