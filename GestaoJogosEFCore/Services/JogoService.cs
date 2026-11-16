using GestaoJogosEFCore.Models;
using GestaoJogosEFCore.Repositories;

namespace GestaoJogosEFCore.Services
{
    public class JogoService
    {
        private readonly JogoRepository _repository;
        public JogoService(JogoRepository repository)
        {
            _repository = repository;
        }
        public List<Jogo> Listar()
        {
            return _repository.Listar();
        }

        public Jogo? BuscarPorId(int id) => _repository.BuscarPorId(id);
        public void Cadastrar(Jogo jogo) => _repository.Adicionar(jogo);
        public bool Atualizar(Jogo JogoAtualizado) => _repository.Atualizar(JogoAtualizado);
        public bool Excluir(int id) => _repository.Excluir(id);
        public List<Desenvolvedora> ListarDesenvolvedora() => _repository.ListarDesenvolvedora();

        public void CadastrarDesenvolvedora(Desenvolvedora novaDesenvolvedora) => _repository.AdicionarDesenvolvedora(novaDesenvolvedora);
        
    }
}