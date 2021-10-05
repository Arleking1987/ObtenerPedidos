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
        public async  Task<IActionResult> GetAllPedidos()
        {
            var pedidos = await  _pedidosService.GetAllPedidos();
            return Ok(pedidos);
        }

        //[HttpGet]
        //[Route("GetPedido")]
        //public async Task<IActionResult> GetPedido(int id)
        //{
        //    var pedidos = await _pedidosRepository.GetPedido(id);
        //    return Ok(pedidos);
        //}

        //[HttpPost]
        //[Route("PostPedido")]
        //public async Task<IActionResult> PostPedido(PedidosEntity pedido)
        //{
        //    await _pedidosRepository.PostPedido(pedido);
        //    return Ok(pedido);
        //}

        //[HttpPost]
        //[Route("ConsultaPedido")]
        //public async Task<IActionResult> ConsultaPedido(PedidosDTO pedido)
        //{
        //    await _pedidosRepository.PostPedido(pedido);
        //    return Ok(pedido);
        //}
    }
}
