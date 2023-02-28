using CadastroDeContatos.Models;
using System.Collections.Generic;

namespace CadastroDeContatos.Repositório
{
    public interface IContatoRepositorio
    {
        ContatoModel BuscarPorId(int id);
        List<ContatoModel> BuscarTodos(int usuarioId);
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel Atualizar(ContatoModel contato);
        bool Apagar(int id);
    }
}