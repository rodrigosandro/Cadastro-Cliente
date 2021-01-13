using Demo_Avaliativa_Web.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo_Avaliativa_Web.DAO.Entidades;

namespace Demo_Avaliativa_Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult FormularioCadastro(Cliente cli)
        {
            ViewBag.TipoLista = new TipoTelefoneDao().ListaTipoTelefone();
            ViewBag.listClients = new ClienteDao().GetCLientes();

            return View(cli);
        }

        [HttpPost]
        public ActionResult FormResponse(FormCollection cliente)
        {
            var dadosCliente = new Cliente
            {
                Nome = cliente["Nome"],
                Telefone = cliente["Telefone"]
            };

            dadosCliente.TipoTelefone = new TipoTelefone()
            {
                Id = Convert.ToInt32(cliente["Tipo"])
            };


            if (cliente["Id"] != "0")
            {
                dadosCliente.Id = Convert.ToInt32(cliente["Id"]);
                new ClienteDao().Atualizar(dadosCliente);
            }
            else
                new ClienteDao().Adicionar(dadosCliente);

            return RedirectToAction("FormularioCadastro");
        }

        public ActionResult Delete(int id)
        {
            var clienteDelete = new ClienteDao();
            clienteDelete.Remover(clienteDelete.Buscar(id));

            return RedirectToAction("FormularioCadastro");
        }

        public ActionResult Edit(int id)
        {
            var clienteDelete = new ClienteDao();
            ViewBag.edit = clienteDelete.Buscar(id);

            ViewBag.TipoLista = new TipoTelefoneDao().ListaTipoTelefone();
            ViewBag.listClients = new ClienteDao().GetCLientes();


            return View("FormularioCadastro", ViewBag.edit);
        }
    }
}