using Infra;
using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Controller
{
    public class FornecedorController
    {
        string _mensagem = "";
        public string Salvar(Fornecedor entity)
        {
            DatabaseContext _db = new DatabaseContext();
            using (DbContextTransaction transacao = DatabaseTransaction.CreateDbContextTransaction(_db))
            {
                if (entity.Id == 0)
                    _mensagem = new FornecedorRepository(_db).Incluir(entity);
                else
                    _mensagem = new FornecedorRepository(_db).Alterar(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

        public Fornecedor Selecionar(int id)
        {
            return new FornecedorRepository().Selecionar(id);
        }

        public List<Fornecedor> SelecionarTodos()
        {
            return new FornecedorRepository().SelecionarTodos().ToList();
        }

        public Fornecedor SelecionarPorTipo(string sigla)
        {
            return new FornecedorRepository().SelecionarPorSigla(sigla);
        }
    }
}
