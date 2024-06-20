using WebApplication1.Model;
using WebApplication1.Repository;

namespace WebApplication1.Repository
{
    public class MokBaltika : IBaltika
    {
        private List<Baltika> baltikas;
        public MokBaltika()
        {
            baltikas ??= new List<Baltika>();
            baltikas.Add(new() { Id = 1, Color = "Красный", Structure = "0%", Volume = "0,5л"});
            baltikas.Add(new() { Id = 2, Color = "Синий", Structure = "4,2%", Volume = "1л"});
            baltikas.Add(new() { Id = 3, Color = "Серебрянный", Structure = "5,5%", Volume = "1,5л" });
        }
        public Baltika Add(Baltika baltika)
        {
            baltikas.Add(baltika);
            return baltika;
        }

        public Baltika Delete(int id)
        {
            var baltikaDB = baltikas.Where(n => n.Id == id).ToList().First();
            if (baltikaDB != null)
            {
                baltikas.Remove(baltikaDB);
            }
            baltikas.Remove(baltikaDB);
            return baltikaDB;

        }

        public Baltika Get(int id)
        {
            return baltikas.Where(n => n.Id == id).ToList().First();
        }

        List<Baltika> IBaltika.GetAll()
        {
            return baltikas;
        }

         public Baltika Update(Baltika baltika)
        {
            var baltikaDB = baltikas.Where(n => n.Id == baltika.Id).ToList().First();
            if (baltikaDB != null)
            {
                baltikas.Remove(baltikaDB);
            }
           baltikas.Remove(baltika);
            return baltika;
        }
    }
}
