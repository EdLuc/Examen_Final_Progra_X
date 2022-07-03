using Interfaces.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Modelos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Examen_Final_Progra_X__1804002020.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicidadController : ControllerBase
    {
        private readonly IPublicidad service;
        private readonly IDbConnection connection;
        public PublicidadController(IPublicidad publicidad, IDbConnection _connection)
        {
            this.service = publicidad;
            this.connection = _connection;
        }

        // GET: api/<GastosController>
        [HttpGet]
        public List<tbl_publicidadModel> Get()
        {
            return service.GetPublicidades(connection);
        }

        // PUT api/<GastosController>/5
        [HttpPut("{id}")]
        public List<tbl_publicidadModel> Put(int id)
        {
            return service.EditPublicidad(connection, id);
        }
    }
}
