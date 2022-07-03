using Modelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    public interface IPublicidad
    {
        tbl_publicidadModel GetPublicidad();
        List<tbl_publicidadModel> GetPublicidades(System.Data.IDbConnection connection);
        void SetPublicidad(tbl_publicidadModel publicidad);
        void DeletePublicidad(int id);
        List<tbl_publicidadModel> EditPublicidad(System.Data.IDbConnection connection, int id_publicidad);
    }
}
