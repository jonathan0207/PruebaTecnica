
using Repository.Entities;
namespace Service.Interfaces
{
    public interface IUsuarios
    {
        Task<List<Usuarios>> List();
        Task<double> AverageAge();
        Task<string> Maxage();
        Task<int> AmountGender(string genero);

        Task<string> Create(Usuarios objeto);
    }
}
