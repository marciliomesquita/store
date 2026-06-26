using Ambev.Store.API.Features.Vendas.CriarVenda;
using Ambev.Store.Application.CriarVenda;
using AutoMapper;

namespace Ambev.Store.API.Mappings
{
    public class CriarVendaProfile : Profile
    {
        public CriarVendaProfile()
        {
            CreateMap<CriarVendaRequest, CriarVendaCommand>();
        }
    }
}
