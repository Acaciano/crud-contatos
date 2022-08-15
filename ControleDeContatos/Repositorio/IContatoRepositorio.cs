using ControleDeContatos.Models;
using System.Collections.Generic;

namespace ControleDeContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> BuscarTodos(int usuarioId);
        ContatoModel BuscarPorID(int id);
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel Atualizar(ContatoModel contato);
        bool Apagar (int id);
    }
}
