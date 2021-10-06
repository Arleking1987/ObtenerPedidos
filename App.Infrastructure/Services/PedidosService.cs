using AutoMapper;
using SocialMedia.Core.DTOs;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Infrastructure.Services
{
    public class PedidosService : IPedidosService
    {
        protected IPedidosRepository _pedidosRepository;
        private readonly IMapper _mapper;

        public PedidosService(IPedidosRepository pedidosRepository, IMapper mapper)
        {
            _pedidosRepository = pedidosRepository;
            _mapper = mapper;

        }

        public List<PedidosDTO> GetAllPedidos()
        {
            var listDTO = new List<PedidosDTO>();
            var listEntities = _pedidosRepository.GetAllPedidos();
            listDTO = _mapper.Map<List<PedidosDTO>>(listEntities);
            return listDTO;

        }
        //public async Task<IEnumerable<PedidosDTO>> GetAllPedidos()
        //{
        //    //List<PedidosDTO> pedidosDTO = new List<PedidosDTO>();
        //    PedidosEntity entity = new PedidosEntity();
        //    IEnumerable<PedidosEntity> entities = await _pedidosRepository.GetAllPedidos();

        //   var pedidosDTO = entities.Select(x=> new PedidosDTO)
        //    {
        //        IdPedido = entity.IdPedido,
        //        FechaPedido = entity.FechaPedido,
        //        FechaEntrega = entity.FechaEntrega,
        //        NombreCliente = entity.NombreCliente,
        //        Estado = entity.Estado
        //    };

        //    return pedidosDTO;

        //}
    }
}
