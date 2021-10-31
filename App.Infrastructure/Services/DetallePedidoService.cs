using AutoMapper;
using SocialMedia.Core.DTOs;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialMedia.Infrastructure.Services
{
    public class DetallePedidoService : IDetallePedidoService
    {
        protected IDetallePedidoRepository _detallePedidoRepository;
        private readonly IMapper _mapper;

        public DetallePedidoService(IDetallePedidoRepository detallePedidoRepository, IMapper mapper)
        {
            _detallePedidoRepository = detallePedidoRepository;
            _mapper = mapper;

        }

        public List<DetallePedidoDTO> GetAllDetallePedidos()
        {
            List<DetallePedidoDTO> listDTO = new List<DetallePedidoDTO>();
            IQueryable<DetallePedidoEntity> listEntities = _detallePedidoRepository.GetAllDetallePedidos();
            listDTO = _mapper.Map<List<DetallePedidoDTO>>(listEntities);
            return listDTO;

        }
    }
}
