using WebApplication1.Model;

namespace WebApplication1.Repository
{
    public interface IBaltika
    {
        public Baltika Add(Baltika baltika);
        public Baltika Get(int id);
        public Baltika Update(Baltika baltika);
        public List<Baltika> GetAll();
        public Baltika Delete(int id);
    }
}
