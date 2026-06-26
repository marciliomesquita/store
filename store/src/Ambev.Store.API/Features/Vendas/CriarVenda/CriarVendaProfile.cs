using Ambev.Store.Application.CriarVenda;
using AutoMapper;

namespace Ambev.Store.API.Features.Vendas.CriarVenda
{
    public class CriarVendaProfile : Profile
    {
        public CriarVendaProfile()
        {
            CreateMap<CriarVendaRequest, CriarVendaCommand>();
            CreateMap<CriarVendaResult, CriarVendaResponse>();
        }
    }
}
