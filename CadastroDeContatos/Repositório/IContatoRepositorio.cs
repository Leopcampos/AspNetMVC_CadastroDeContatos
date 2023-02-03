using CadastroDeContatos.Models;
using System.Collections.Generic;

namespace CadastroDeContatos.Repositório
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
    }
}