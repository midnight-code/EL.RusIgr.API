using EL.RusIgr.API.Model;

namespace EL.RusIgr.API.Repository
{
    public interface ITipOtdelaRepositor
    {
        void UpdateTipOtdela(TipOtdelaModel cmd);
        void CreateTipOtdela(TipOtdelaModel cmd);
        void DeleteTipOtdela(int id);
        IEnumerable<TipOtdelaModel> GetAllTipOtdela();
        TipOtdelaModel GetTipOtdelaById(int id);
        IEnumerable<TipOtdelaModel> GetTipOtdelaByOtdelId(int idOtdel);
        bool SaveChanges();
    }
}
