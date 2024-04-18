using cadastro_contatos_aspnet.Models;
using System.Collections.Generic;

namespace cadastro_contatos_aspnet.Repositorios
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
    }
}
