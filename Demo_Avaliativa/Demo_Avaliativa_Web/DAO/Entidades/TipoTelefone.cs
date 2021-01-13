using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Demo_Avaliativa_Web.DAO.Entidades
{
    public class TipoTelefone
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }

    }
}