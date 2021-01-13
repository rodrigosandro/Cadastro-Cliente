using Demo_Avaliativa_Web.DAO.Entidades;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_Avaliativa_Web.DAO
{
    public class ClienteDao
    {
        ApplicationContext applicationContext;
        public ClienteDao()
        {
            applicationContext = new ApplicationContext();
        }

        public void Adicionar(Cliente cliente)
        {
            applicationContext.Clientes.Add(cliente);
            applicationContext.SaveChanges();
        }

        public void Remover(Cliente cliente)
        {
            applicationContext.Clientes.Remove(cliente);
            applicationContext.SaveChanges();
        }

        public Cliente Buscar(int id)
        {
            return applicationContext.Clientes.First(c => c.Id == id);
        }

        public IList<Cliente> GetCLientes()
        {
            return applicationContext.Clientes.Include(tipo => tipo.TipoTelefone).ToList();
        }

        public void Atualizar(Cliente cliente)
        {
            applicationContext.Clientes.Update(cliente);
            applicationContext.SaveChanges();
        }

    }
}