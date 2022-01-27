using Infra;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class FornecedorRepository : IBaseRepository<Fornecedor>
    {
        private DatabaseContext _db = new DatabaseContext();
        private DefaultRepository<Fornecedor> _repository;
        private string _usuario = "";

        public FornecedorRepository(DatabaseContext context = null, string usuario = "")
        {
            _repository = new DefaultRepository<Fornecedor>(context == null ? new DatabaseContext() : context);
            _usuario = usuario;
        }

        public string Incluir(Fornecedor entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(Fornecedor entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(Fornecedor entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Delete(entity.Id);
            }
            return mensagem;
        }

        public Fornecedor Selecionar(int id)
        {
            return _repository.GetById(id);
        }

        public IQueryable<Fornecedor> SelecionarTodos()
        {
            return _repository.GetAll();
        }

        public string ValidarDados(Fornecedor entity)
        {
            return "";
        }

        public string ValidarExclusao(Fornecedor entity)
        {
            return "";
        }

        public Fornecedor SelecionarPorSigla(string sigla)
        {
            return this.SelecionarTodos().Where(p => p.Sigla == sigla).FirstOrDefault();
        }
    }
}
