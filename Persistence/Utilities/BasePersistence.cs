using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Database;

namespace Persistence.Utilities
{
    public class BasePersistence
    {
        protected async Task<List<T>> GetRecordsToDB<T>(DatabaseContext context) where T : class
        {
            return await context.Set<T>().ToListAsync();
        }
        protected async Task<T> GetRecordToDB<T>(DatabaseContext context, int id) where T : class
        {
            return await context.Set<T>().FindAsync(id);
        }
        protected async Task<int> InsertToDB<T>(DatabaseContext context, T entity) where T : class
        {
            var newEntity = context.Set<T>().AddAsync(entity);
            int result = await context.SaveChangesAsync();
            return result;
        }
        protected async Task<int> UpdateToDB<T>(DatabaseContext context, int id, T updatedEntity) where T : class
        {
            var existingEntity = await context.Set<T>().FindAsync(id);
            context.Entry(existingEntity).CurrentValues.SetValues(updatedEntity);
            int result = await context.SaveChangesAsync();
            return result;
        }
        protected async Task<int> DeleteToDB<T>(DatabaseContext context, int id) where T : class
        {
            var newEntity = await context.Set<T>().FindAsync(id);
            context.Set<T>().Remove(newEntity);
            int result = await context.SaveChangesAsync();
            return result;
        }
    }
}
