using EL.RusIgr.API.Model;

namespace EL.RusIgr.API.Repository
{
    public interface IKatalogRepositor
    {
        void UpdateKatalog(KatalogModel cmd);
        void CreateKatalog(KatalogModel cmd);
        void DeleteKatalog(int id);
        IEnumerable<KatalogModel> GetAllKatalog();
        KatalogModel GetKatalogById(int id);
        IEnumerable<KatalogModel> GetKatalogByTipId(int idTip);
        bool SaveChanges();
    }
}
