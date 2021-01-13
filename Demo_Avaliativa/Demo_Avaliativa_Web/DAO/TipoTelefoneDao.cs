using Demo_Avaliativa_Web.DAO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_Avaliativa_Web.DAO
{
    public class TipoTelefoneDao
    {
        private ApplicationContext ApplicationContext;

        public TipoTelefoneDao()
        {
            ApplicationContext = new ApplicationContext();
        }

        public IList<TipoTelefone> ListaTipoTelefone()
        {
           return ApplicationContext.TipoTelefones.ToList();
        }
    }
}