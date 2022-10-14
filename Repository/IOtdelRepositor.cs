using EL.RusIgr.API.Model;

namespace EL.RusIgr.API.Repository
{
    public interface IOtdelRepositor
    {
        void UpdateOtdel(OtdelModel cmd);
        void CreateOtdel(OtdelModel cmd);
        void DeleteOtdel(int id);
        IEnumerable<OtdelModel> GetAllOtdel();
        OtdelModel GetOtdelById(int id);
        bool SaveChanges();
        
    }
}
