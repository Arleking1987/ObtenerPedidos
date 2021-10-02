using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;
using SocialMedia.Infrastructure.Repositories;
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
        private readonly IPedidosRepository _pedidosRepository;
        public PedidosController(IPedidosRepository pedidosRepository)
        {
            _pedidosRepository = pedidosRepository;
        }

        [HttpGet]
        [Route("GetAllPedidos")]
        public async  Task<IActionResult> GetAllPedidos()
        {
            var pedidos = await  _pedidosRepository.GetAllPedidos();
            return Ok(pedidos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPedido(int id)
        {
            var pedidos = await _pedidosRepository.GetPedido(id);
            return Ok(pedidos);
        }

        [HttpPost]
        [Route("PostPedido")]

        public async Task<IActionResult> PostPedido(Pedidos pedido)
        {
            await _pedidosRepository.PostPedido(pedido);
            return Ok(pedido);
        }
    }
}
