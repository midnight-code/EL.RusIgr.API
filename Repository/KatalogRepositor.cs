using EL.RusIgr.API.DataSql;
using EL.RusIgr.API.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EL.RusIgr.API.Repository
{
    public class KatalogRepositor : IKatalogRepositor
    {
        private readonly BaseContext _context;
        public KatalogRepositor(BaseContext context) => _context = context;
        public void CreateKatalog(KatalogModel cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteKatalog(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<KatalogModel> GetAllKatalog()
        {
            throw new NotImplementedException();
        }

        public KatalogModel GetKatalogById(int id)
        {
            if (id > 0)
            {
                return _context.Katalog.FirstOrDefault(d => d.ID == id);
            }
            return null;
        }

        public IEnumerable<KatalogModel> GetKatalogByTipId(int idTip)
        {
            if (idTip > 0)
            {
                return _context.Katalog.Where(t => t.TipOtdelID == idTip).ToList();
            }
            return Enumerable.Empty<KatalogModel>();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateKatalog(KatalogModel cmd)
        {
            throw new NotImplementedException();
        }
    }
}
