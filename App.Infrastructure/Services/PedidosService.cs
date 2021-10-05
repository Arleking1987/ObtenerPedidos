using AutoMapper;
using SocialMedia.Core.DTOs;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Infrastructure.Services
{
    public class PedidosService : IPedidosService
    {
        protected IPedidosRepository _pedidosRepository;
        protected IMapper _mapper;

        public PedidosService(IPedidosRepository pedidosRepository, IMapper mapper)
        {
            _pedidosRepository = pedidosRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<PedidosDTO>> GetAllPedidos()
        {
            List<PedidosDTO> pedidosDTO = new List<PedidosDTO>();
            IEnumerable<PedidosEntity> entities = await _pedidosRepository.GetAllPedidos();
            pedidosDTO = _mapper.Map<List<PedidosDTO>>(entities);

            return pedidosDTO;

        }
    }
}
