using Newtonsoft.Json;


using SistemaWebDenuncia_cl3_Maribel.Models;
using SistemaWebDenuncia_cl3_Maribel.Negocio;

namespace SistemaWebDenuncia_cl3_Maribel.Dao
{
    public class DenunciaDao : IDenuncia
    {

        public Task<List<DenunciaModel>> GetDenuncias()
        {
            return get();
        }

        public Task<string> Add(DenunciaModel denuncia)
        {
            //throw new NotImplementedException();
            return add(denuncia);
        }

        public Task<string> Delete(int id)
        {
            return delete(id);
        }

        

        public Task<string> Update(DenunciaModel denuncia)
        {
            return update(denuncia);
        }
    }
}
