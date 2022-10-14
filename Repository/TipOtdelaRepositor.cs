using EL.RusIgr.API.DataSql;
using EL.RusIgr.API.Model;
using Microsoft.EntityFrameworkCore;

namespace EL.RusIgr.API.Repository
{
    public class TipOtdelaRepositor : ITipOtdelaRepositor
    {
        private readonly BaseContext _context;
        public TipOtdelaRepositor(BaseContext context) => _context = context;
        public void CreateTipOtdela(TipOtdelaModel cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteTipOtdela(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TipOtdelaModel> GetAllTipOtdela()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Возвращаем выбранный тип отдела оп индентификатору
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>TipOtdelaModel</returns>
        public TipOtdelaModel GetTipOtdelaById(int id)
        {
            if (id > 0)
            {
                return _context.TipOtdel.FirstOrDefault(i => i.ID == id);
            }
            return null;
        }
        /// <summary>
        /// Возвращаем список по выбранному отделу
        /// </summary>
        /// <param name="idOtdel">int</param>
        /// <returns>IEnumerable<TipOtdelaModel></returns>
        public IEnumerable<TipOtdelaModel> GetTipOtdelaByOtdelId(int idOtdel)
        {
            if(idOtdel > 0)
            {
                return _context.TipOtdel.Where(p => p.OtdelID == idOtdel).ToList();
            }
            return Enumerable.Empty<TipOtdelaModel>();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateTipOtdela(TipOtdelaModel cmd)
        {
            throw new NotImplementedException();
        }
    }
}
