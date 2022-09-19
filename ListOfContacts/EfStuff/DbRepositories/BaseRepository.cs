using ListOfContacts.EfStuff.DbModel;
using ListOfContacts.EfStuff;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListOfContacts.EfStuff.DbRepositories
{
    public abstract class BaseRepository<T> where T : BaseModel
    {
        protected WebDbContext _webContext;
        protected DbSet<T> _dbSet;

        public BaseRepository(WebDbContext context)
        {
            _webContext = context;
            _dbSet = _webContext.Set<T>();
        }

        public T Get(int id) => _dbSet.FirstOrDefault(x => x.Id == id);

        public List<T> GetAll() => _dbSet.ToList();

        public void Save(T model)
        {
            if (model.Id > 0)
            {
                _dbSet.Update(model);
            }
            else
            {
                _dbSet.Add(model);
            }

           _webContext.SaveChanges();
        }

        public async Task Remove(T model)
        {
            _dbSet.Remove(model);
            await _webContext.SaveChangesAsync();
        }

        public async Task Remove(int id)
        {
            await Remove(Get(id));
        }

        public bool Any()=>_dbSet.Any();
        

    }
}
