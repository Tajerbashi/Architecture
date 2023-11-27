using Application.Library.BaseRepository;
using Application.Library.ModelBase.BaseDTOModel;
using Application.Library.ModelBase.BaseViewModel;
using AutoMapper;
using Domain.Library.Bases;
using Infrastructure.Library.Database.EF;
using Infrastructure.Library.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.Library.BaseService
{
    public abstract class BaseRepository<TEntity, TDTO, TView> 
        : IBaseRepository<TDTO>, IDisposable
        where TEntity : BaseEntity,IBaseEntity
        where TDTO : BaseDTO
        where TView : BaseView
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork<ApplicationContext> _unitOfWork;
        public BaseRepository(IMapper mapper)
        {
            _mapper = mapper;
        }
        public ApplicationContext Context { get; set; }
       
        private DbSet<TEntity> _entities;
       
        private string _errorMessage = string.Empty;
       
        private bool _isDisposed;
       
       
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
       
        public void Dispose()
        {
            this.Dispose();
        }

        public object Create(TDTO model)
        {
            throw new NotImplementedException();
        }

        public void CreateList(IEnumerable<TDTO> models)
        {
            throw new NotImplementedException();
        }

        public object Update(TDTO model, object ID)
        {
            throw new NotImplementedException();
        }

        public object Update(TDTO model, Guid guid)
        {
            throw new NotImplementedException();
        }

        public object Update(IEnumerable<TDTO> models)
        {
            throw new NotImplementedException();
        }

        public TDTO Read(object Id)
        {
            throw new NotImplementedException();
        }

        public TDTO Read(Guid guid)
        {
            throw new NotImplementedException();
        }

        public List<TDTO> ReadAll()
        {
            throw new NotImplementedException();
        }

        public object Remove(Guid guid)
        {
            throw new NotImplementedException();
        }

        public bool ChangeActive(Guid guid)
        {
            throw new NotImplementedException();
        }

        public bool ChangeActive(object ID)
        {
            throw new NotImplementedException();
        }

        public object Remove(TDTO model)
        {
            throw new NotImplementedException();
        }

        public object Remove(object ID)
        {
            throw new NotImplementedException();
        }
    }
}
