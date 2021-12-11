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
        protected IDetallePedidoService _detallePedidoService;
        private readonly IMapper _mapper;

        public PedidosService(IPedidosRepository pedidosRepository, IDetallePedidoService detallePedidoService,IMapper mapper)
        {
            _pedidosRepository = pedidosRepository;
            _detallePedidoService = detallePedidoService;
            _mapper = mapper;

        }

        public List<PedidosDTO> GetAllPedidos()
        {
            
            List<PedidosDTO> listDTO = new List<PedidosDTO>();
            IQueryable<PedidosEntity> listEntities = _pedidosRepository.GetAllPedidos();
            listDTO = _mapper.Map<List<PedidosDTO>>(listEntities);
           
            return listDTO;

        }


        public List<PedidosDTO> GetPedidoById(int id)
        {
            List<DetallePedidoContract> pedidoDetalle = new List<DetallePedidoContract>();
            IQueryable<PedidosEntity> listEntities = _pedidosRepository.GetAllPedidos();
            IQueryable<PedidosEntity> pedidoEntity = listEntities.Where(x => x.IdPedido == id);
            List<PedidosDTO> pedidosDTO = _mapper.Map<List<PedidosDTO>>(pedidoEntity);
            List<DetallePedidoDTO> detallePedido = _detallePedidoService.GetAllDetallePedidos();

            foreach (var pedidoDto in pedidosDTO)
            {
                pedidoDto.Detalles = (from detalle in detallePedido
                                 join pedido in pedidosDTO
                                 on detalle.IdPedido equals pedido.IdPedido
                                 select new DetallePedidoDTO
                                 {
                                     IdPedido = detalle.IdPedido,
                                     Medidas = detalle.Medidas,
                                     Detalle = detalle.Detalle,
                                     Tipo = detalle.Tipo,
                                    

                                 }).ToList();
            }
            

            return pedidosDTO;

        }
    }
}
