using Interfaces.Interfaces;
using Modelos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Services
{
    public class PublicidadService : IPublicidad
    {
        public void DeletePublicidad(int id)
        {
            throw new NotImplementedException();
        }

        public List<tbl_publicidadModel> EditPublicidad(IDbConnection connection, int id_publicidad)
        {
            throw new NotImplementedException();
        }

        public tbl_publicidadModel GetPublicidad()
        {
            throw new NotImplementedException();
        }

        public List<tbl_publicidadModel> GetPublicidades(IDbConnection connection)
        {
            throw new NotImplementedException();
        }

        public void SetPublicidad(tbl_publicidadModel publicidad)
        {
            throw new NotImplementedException();
        }
    }
}
