﻿using Servicios.Clases;
using Servicios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml.Linq;

namespace Servicios.Controllers
{
    public class EmpleadosController : ApiController
    {
        // GET sin parámetros -- Invoca el consultar todos
        public List<Empleado> Get()
        {
            clsEmpleado _empleado = new clsEmpleado();
            return _empleado.ConsultarTodos();
        }

        // GET -- Invoca el consultar con un parámetro: Documento
        public Empleado Get(string Documento)
        {
            clsEmpleado _empleado = new clsEmpleado();
            return _empleado.Consultar(Documento);
        }

        // POST -- Invoca el método insertar 
        public string Post([FromBody] Empleado empleado)
        {
            clsEmpleado _empleado = new clsEmpleado();
            _empleado.empleado = empleado;
            return _empleado.Insertar();
        }

        // PUT -- Invoca el método actualizar
        public string Put([FromBody] Empleado empleado)
        {
            clsEmpleado _empleado = new clsEmpleado();
            _empleado.empleado = empleado;
            return _empleado.Actualizar();
        }

        // DELETE -- Invoca el método Eliminar
        public string Delete([FromBody]Empleado empleado)
        {
            clsEmpleado _empleado = new clsEmpleado();
            _empleado.empleado = empleado;
            return _empleado.Eliminar();
        }
    }
}