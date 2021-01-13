using Microsoft.Data.Entity.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Demo_Avaliativa_Web.DAO.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public virtual TipoTelefone TipoTelefone { get; set; }
  
    }
}