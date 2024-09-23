
using Repository.Entities;

namespace Repository.Interfaces
{
    public interface UsuariosRepository
    {
        Task<List<Usuarios>> List();
        Task<string> Maxage();
        Task<int> AmountGender(string genero);
        Task<double> AverageAge();

        Task<string> Create(Usuarios objeto);
    }
}

