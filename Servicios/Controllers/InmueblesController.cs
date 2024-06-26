﻿using Servicios.Clases;
using Servicios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Servicios.Controllers
{
    [EnableCors(origins: "https://localhost:44320", headers: "*", methods: "*")]
    [Authorize]

    public class InmueblesController : ApiController
    {
        [HttpGet]
        [Route("api/Inmuebles/LlenarCombo")]
        public IQueryable LlenarCombo(int idTipoInmueble)
        {
            clsInmueble _inmueble = new clsInmueble();
            return _inmueble.LlenarCombo(idTipoInmueble);
        }

        // GET api/<controller>
        public List<Inmueble> Get()
        {
            clsInmueble _inmueble = new clsInmueble();
            return _inmueble.ConsultarTodos();
        }

        // GET -- Invoca el Consultar con un parametro: IdInmueble
        public Inmueble Get(int IdInmueble)
        {
            clsInmueble _inmueble = new clsInmueble();
            return _inmueble.Consultar(IdInmueble);
        }

        [HttpGet]
        [Route("api/Inmuebles/ConsultarConTodo")]
        public IQueryable ConsultarConTodo()
        {
            clsInmueble _inmueble = new clsInmueble();
            return _inmueble.ConsultarConTodo();
        }

        // POST -- Invoca el método insertar 
        public string Post([FromBody] Inmueble inmueble)
        {
            clsInmueble _inmueble = new clsInmueble();
            _inmueble.inmueble = inmueble;
            return _inmueble.Insertar();
        }

        // PUT -- Invoca el metodo Actualizar
        public string Put([FromBody] Inmueble inmueble)
        {
            clsInmueble _inmueble = new clsInmueble();
            _inmueble.inmueble = inmueble;
            return _inmueble.Actualizar();

        }

        // DELETE -- Invoca el metodo Eliminar
        public string Delete([FromBody] Inmueble inmueble)
        {
            clsInmueble _inmueble = new clsInmueble();
            _inmueble.inmueble = inmueble;
            return _inmueble.Eliminar();
        }
    }
}