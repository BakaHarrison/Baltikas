using WebApplication1.Model;

namespace WebApplication1.Repository
{
    public class SqlUserRepository : IBaltika
    {
        private readonly AppDbContext _appDbContext;

        public SqlUserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Baltika? Add(Baltika baltika)
        {
            _appDbContext.Beer.Add(baltika);
            _appDbContext.SaveChanges();
            return baltika;
        }

        public Baltika Delete(int Id)
        {
            var baltikaDB = Get(Id);
            if (baltikaDB != null)
            {
                _appDbContext.Beer.Remove(baltikaDB);
            }
            return (baltikaDB);
        }

        public Baltika? Get(int Id)
        {
            return _appDbContext.Beer.Where(u=>u.Id == Id).ToList().FirstOrDefault();
        }

        public List<Baltika> Get() 
        { 
            return _appDbContext.Beer.ToList();
        }

        public List<Baltika> GetAll()
        {
            return _appDbContext.Beer.ToList();
        }

        public Baltika Update(Baltika upBeer)
        {
            if (upBeer.Id == 0)
            {
                _appDbContext.Beer.Add(upBeer);
            }
            else
            {
                _appDbContext.Beer.Update(upBeer);
            }
            _appDbContext.SaveChanges();
            return upBeer;
        }
    }
}
