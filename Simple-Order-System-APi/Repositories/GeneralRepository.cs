using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Simple_Order_System_APi.Contexts;
using Simple_Order_System_APi.Repositories.Interface;

namespace Simple_Order_System_APi.Repositories
{
    public class GeneralRepository<Key, Entity> : IRepository<Key, Entity> where Entity : class
    {
        private readonly MyContext context;

        public GeneralRepository(MyContext context)
        {
            this.context = context;
        }

        public async Task<int> Delete(Key key)
        {
            var entity = await GetById(key);
            context.Set<Entity>().Remove(entity);
            return await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Entity>> GetAll()
        {
            return await context.Set<Entity>().ToListAsync();
        }

        public async Task<Entity?> GetById(Key? key)
        {
            if (key is null)
            {
                return null;
            }
            return await context.Set<Entity>().FindAsync(key);
        }

        public async Task<int> Insert(Entity entity)
        {
            await context.Set<Entity>().AddAsync(entity);
            return await context.SaveChangesAsync();
        }

        public async Task<int> Update(Entity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            return await context.SaveChangesAsync();
        }
    }
}
