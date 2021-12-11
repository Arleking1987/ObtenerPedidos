using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Core.DTOs;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;
using SocialMedia.Infrastructure.Repositories;
using SocialMedia.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace App.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private readonly IPedidosService _pedidosService;
        
        public PedidosController(IPedidosService pedidosService)
        {
            _pedidosService = pedidosService;
            
        }

        [HttpGet]
        [Route("GetAllPedidos")]
        public List<PedidosDTO> GetAllPedidos() 
        {
 
            try
            {
                List<PedidosDTO> data = _pedidosService.GetAllPedidos();
                return data;

            }
            catch (Exception ex)
            {

                throw new Exception(ex + "Error de petición");
            }
        }

       

        [HttpPost]
        [Route("GetPedidoById")]
        public List<PedidosDTO> GetPedidoById(int id)
        {
            List<PedidosDTO> pedido = _pedidosService.GetPedidoById(id);
            return pedido;
        }

       
    }
}
