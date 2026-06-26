using Ambev.Store.API.Features.Vendas.CriarVenda;
using Ambev.Store.Application.CriarVenda;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ambev.Store.API.Features.Vendas
{
    [ApiController]
    [Route("[controller]")]
    public class VendasController : ControllerBase
    {
        private readonly ILogger<VendasController> _logger;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public VendasController(ILogger<VendasController> logger, IMediator mediator, IMapper mapper)
        {
            _logger = logger;
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CriarVenda([FromBody] CriarVendaCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}
