using EL.RusIgr.API.DataSql;
using EL.RusIgr.API.Model;
using Microsoft.AspNetCore.Authentication;

namespace EL.RusIgr.API.Repository
{
    public class OtdelRepositor : IOtdelRepositor
    {
        private readonly BaseContext _context;

        public OtdelRepositor(BaseContext context) => _context = context;

        public void CreateOtdel(OtdelModel cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Otdel.Add(cmd);
            SaveChanges();
        }

        public void DeleteOtdel(int id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Возвращаем весь перечень отделов товара
        /// </summary>
        /// <returns>IEnumerable<OtdelModel></returns>
        public IEnumerable<OtdelModel> GetAllOtdel()
        {
            return _context.Otdel.ToList();
        }
        /// <summary>
        /// Возвращаем выбраный отдел по индентификатору
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>OtdelModel</returns>
        public OtdelModel GetOtdelById(int id)
        {
            if (id > 0)
            {
                return _context.Otdel.FirstOrDefault(p=>p.ID==id);
            }
            return null;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateOtdel(OtdelModel cmd)
        {
            throw new NotImplementedException();
        }
    }
}
