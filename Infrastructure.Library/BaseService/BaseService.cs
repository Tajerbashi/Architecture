using Application.Library.BaseRepository;
using Application.Library.ModelBase.BaseDTOModel;
using Application.Library.ModelBase.BaseViewModel;
using Domain.Library.Bases;
using Infrastructure.Library.Database.EF;
using Infrastructure.Library.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.Library.BaseService
{
    public abstract class BaseRepository<TEntity, TDTO, TView> 
        : IBaseRepository<TEntity>, IDisposable
        where TEntity : BaseEntity
        where TDTO : BaseDTO
        where TView : BaseView
    {
       
        private readonly IUnitOfWork<ApplicationContext> _unitOfWork;
       
        public ApplicationContext Context { get; set; }
       
        private DbSet<TEntity> _entities;
       
        private string _errorMessage = string.Empty;
       
        private bool _isDisposed;
       
        protected long UserID { get; set; }
       
        protected long UserRoleID { get; set; }
       
        protected long UserName { get; set; }
       
        protected long Display { get; set; }
       
        protected virtual DbSet<TEntity> Entities
        {
            get { return _entities ?? (_entities = Context.Set<TEntity>()); }
        }
        //If you don't want to use Unit of Work, then use the following Constructor 
        //which takes the context Object as a parameter
        public BaseRepository(ApplicationContext context)
        {
            //Initialize _isDisposed to false and then set the Context Object
            _isDisposed = false;
            Context = context;
        }
        //While Creating an Instance of GenericRepository, we need to pass the UnitOfWork instance
        //That UnitOfWork instance contains the Context Object that our GenericRepository is going to use
        
        public BaseRepository(IUnitOfWork<ApplicationContext> unitOfWork)
            : this(unitOfWork.Context)
        {
            _unitOfWork = unitOfWork;
        }
        
        private void HandleUnitOfWorkException(DbEntityValidationException dbEx)
        {
            foreach (var validationErrors in dbEx.EntityValidationErrors)
            {
                foreach (var validationError in validationErrors.ValidationErrors)
                {
                    _errorMessage = _errorMessage + $"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage} {Environment.NewLine}";
                }
            }
        }
        
        private void Delete(TEntity entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("Entity");
                }
                if (Context == null || _isDisposed)
                {
                    Context = new ApplicationContext(new DbContextOptions<ApplicationContext>());
                }

                Entities.Remove(entity);
                //commented out call to SaveChanges as Context save changes will be called with Unit of work
                //Context.SaveChanges(); 
            }
            catch (DbEntityValidationException dbEx)
            {
                HandleUnitOfWorkException(dbEx);
                throw new Exception(_errorMessage, dbEx);
            }
        }
        
        private void Update(TEntity entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("Entity");
                }

                if (Context == null || _isDisposed)
                {
                    Context = new ApplicationContext(new DbContextOptions<ApplicationContext>());
                }
                Context.Entry(entity).State = EntityState.Modified;
                //commented out call to SaveChanges as Context save changes will be called with Unit of work
                //Context.SaveChanges(); 
            }
            catch (DbEntityValidationException dbEx)
            {
                HandleUnitOfWorkException(dbEx);
                throw new Exception(_errorMessage, dbEx);
            }
        }
        
        private void Insert(TEntity entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("Entity");
                }

                if (Context == null || _isDisposed)
                {
                    Context = new ApplicationContext(new DbContextOptions<ApplicationContext>());
                }
                Entities.Add(entity);
                //commented out call to SaveChanges as Context save changes will be
                //called with Unit of work
                //Context.SaveChanges(); 
            }
            catch (DbEntityValidationException dbEx)
            {
                HandleUnitOfWorkException(dbEx);
                throw new Exception(_errorMessage, dbEx);
            }
        }
        
        public object Create(TEntity model)
        {
            Insert(model);
            return model;
        }
        
        public void CreateList(IEnumerable<TEntity> models)
        {
            Context.Set<TEntity>().AddRange(models);
            Context.SaveChanges();
        }
        
        public void Dispose()
        {
            this.Dispose();
        }
        
        public TEntity Read(object Id)
        {
            return Entities.Find(Id);
        }
        
        public TEntity Read(Guid guid)
        {
            return Entities.Single(x => x.Guid.Equals(guid) && !x.IsDeleted && x.IsActive);
        }

        public List<TEntity> ReadAll()
        {
            return Entities.ToList();
        }

        public object Remove(Guid guid)
        {
            var model = Read(guid);
            model.IsDeleted = true;
            model.IsActive = false;
            Context.Set<TEntity>().Remove(model);
            return Context.SaveChanges();
        }
       
        public object Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
            return Context.SaveChanges();
        }

        public object Remove(object ID)
        {
            var model = Read(ID);
            Context.Set<TEntity>().Remove(model);
            return Context.SaveChanges();
        }

        public object Update(TEntity model, object ID)
        {
            var record = Read(ID); 
            Update(record);
            return record;
        }

        public object Update(TEntity model, Guid guid)
        {
            var record = Read(guid);
            Update(record);
            return record;
        }

        public object Update(IEnumerable<TEntity> models)
        {
            Context.UpdateRange(models);
            return Context.SaveChanges();
        }   

        public bool ChangeActive(Guid guid)
        {
            var model = Read(guid);
            model.IsDeleted = true;
            model.IsActive = false;
            Context.Entry<TEntity>(model).State = EntityState.Modified;
            Context.SaveChanges();
            return true;
        }

        public bool ChangeActive(object ID)
        {
            var model = Read(ID);
            model.IsDeleted = true;
            model.IsActive = false;
            Context.Entry<TEntity>(model).State = EntityState.Modified;
            Context.SaveChanges();
            return true;
        }
    }
}
