using SistemaWebDenuncia_cl3_Maribel.Models;

namespace SistemaWebDenuncia_cl3_Maribel.Negocio
{
    public interface IDenuncia
    {
        Task<List<DenunciaModel>> GetDenuncias();
        Task<string> Add(DenunciaModel denuncia);
        Task<string> Update(DenunciaModel denuncia);
        Task<string> Delete(int id);
    }
}
