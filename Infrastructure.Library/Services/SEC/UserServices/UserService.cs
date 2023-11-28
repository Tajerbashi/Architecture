using Application.Library.Repositories.SEC;
using Application.Library.Repositories.SEC.DTO;
using AutoMapper;
using Domain.Library.Entities.SEC;
using Infrastructure.Library.Database.EF;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Infrastructure.Library.Services.SEC.UserServices
{
    public class UserService : UserManager<User>
    {
        private readonly UserManager<User> _userManager;
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;
        public UserService(
            IUserStore<User> store,
            IOptions<IdentityOptions> optionsAccessor,
            IPasswordHasher<User> passwordHasher,
            IEnumerable<IUserValidator<User>> userValidators,
            IEnumerable<IPasswordValidator<User>> passwordValidators,
            ILookupNormalizer keyNormalizer,
            IdentityErrorDescriber errors,
            IServiceProvider services,
            ILogger<UserManager<User>> logger,
            UserManager<User> userManager,
            ApplicationContext context,
            IMapper mapper
            )
            :
            base(
                store,
                optionsAccessor,
                passwordHasher,
                userValidators,
                passwordValidators,
                keyNormalizer,
                errors,
                services,
                logger
                )
        {
            _userManager = userManager;
            _context = context;
            _mapper = mapper;
        }

        public bool ChangeActive(Guid guid)
        {
            try
            {
                var model = _context.Users.Where(x => x.Guid == guid).Single();
                model.IsActive = model.IsActive ? false : true;
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool ChangeActive(object ID)
        {
            try
            {
                var model = _context.Users.Find(ID);
                model.IsActive = model.IsActive ? false : true;
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public object Create(UserDTO model)
        {
            try
            {
                return _userManager.CreateAsync(_mapper.Map<User>(model));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CreateList(IEnumerable<UserDTO> models)
        {
            try
            {
                _context.Users.AddRange(_mapper.Map<IEnumerable<User>>(models));
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public UserDTO Read(object Id)
        {
            try
            {
                return _mapper.Map<UserDTO>(_context.Users.Find(Id));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public UserDTO Read(Guid guid)
        {
            try
            {
                return _mapper.Map<UserDTO>(_context.Users.First(x => x.Guid == guid));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<UserDTO> ReadAll()
        {
            try
            {
                return _mapper.Map<List<UserDTO>>(_context.Users.Where(x => !x.IsDeleted).ToList());
            }
            catch (Exception)
            {

                throw;
            }
        }

        public object Remove(Guid guid)
        {
            try
            {
                var model = _context.Users.Remove(_context.Users.FirstOrDefault(x => x.Guid.Equals(guid)));
                Remove(model);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public object Remove(UserDTO model)
        {
            return _context.Remove<User>(_mapper.Map<User>(model));
        }

        public object Remove(object ID)
        {
            var model = _context.Users.Remove(_context.Users.FirstOrDefault(x => x.Id == (long)ID));
            return Remove(model);
        }

        public object Update(UserDTO model, object ID)
        {
            var entity = _context.Users.Remove(_context.Users.FirstOrDefault(x => x.Id == (long)ID));
            _context.Users.Update(_mapper.Map<User>(entity));
            _context.SaveChanges();
            return entity;
        }

        public object Update(UserDTO model, Guid guid)
        {
            var entity = _context.Users.Remove(_context.Users.FirstOrDefault(x => x.Guid.Equals(guid)));
            _context.Users.Update(_mapper.Map<User>(entity));
            _context.SaveChanges();
            return entity;
        }

        public object Update(IEnumerable<UserDTO> models)
        {
            var entities = _mapper.Map<IEnumerable<User>>(models);
            _context.Users.UpdateRange(entities);
            return _context.SaveChanges();
        }
    }
}
