using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Application.Library.BaseRepository
{
    public interface IUnitOfWork<TContext> 
        where TContext : class
    {
        //The following Property is going to hold the context object
        TContext Context { get;}

        //Start the database Transaction
        void CreateTransaction();

        //Commit the database Transaction
        void Commit();

        //Rollback the database Transaction
        void Rollback();

        //DbContext Class SaveChanges method
        void Save();
    }
}
