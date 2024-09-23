
using Repository.Entities;
using Repository.Interfaces;
using Service.Interfaces;

namespace Service.Implementation
{
    public class ImUsuarios : IUsuarios
    {
        private readonly UsuariosRepository _repository;
        public ImUsuarios(UsuariosRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> AmountGender(string genero)
        {
            return await _repository.AmountGender(genero);
        }

        public async Task<double> AverageAge()
        {
            return await _repository.AverageAge();
        }

        public async Task<string> Create(Usuarios objeto)
        {
            return await _repository.Create(objeto);
        }

        public async Task<List<Usuarios>> List()
        {
            return await _repository.List();
        }

        public async Task<string> Maxage()
        {
            return await _repository.Maxage();
        }
    }
}
