using cadastro_contatos_aspnet.Data;
using cadastro_contatos_aspnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace cadastro_contatos_aspnet.Repositorios
{
    public class ContatoRepositorio : IContatoRepositorio
    {

        private readonly BancoContext _bancoContext;

        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }


        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

        public ContatoModel ListarPorId(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(busca => busca.Id == id);
        }

        public ContatoModel Editar(ContatoModel contato)
        {
            ContatoModel contatoDB = ListarPorId(contato.Id);

            if (contatoDB == null) {
                throw new System.Exception("não foi possivel enviar as informações");
            }

            Console.WriteLine(contato);

            contatoDB.Nome = contato.Nome;
            contatoDB.Email = contato.Email;
            contatoDB.Telefone = contato.Telefone;

            _bancoContext.Contatos.Update(contatoDB);
            _bancoContext.SaveChanges();
            return contatoDB;
        }

        public bool Apagar(int id)
        {
            ContatoModel contatoDB = ListarPorId(id);

            if (contatoDB == null)
            {
                throw new System.Exception("não foi possivel apagar as informações");
            }


            _bancoContext.Contatos.Remove(contatoDB);
            _bancoContext.SaveChanges(); 
            return true;
        }
    }
}
