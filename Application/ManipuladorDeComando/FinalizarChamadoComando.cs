using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Aplicacao.DTOs.Chamados;
using Aplicacao.ManipuladorDeComando.Resultados;
using MediatR;

namespace Aplicacao.ManipuladorDeComando
{
    public record FinalizarChamadoComando(int ChamadoId, int UsuarioId, string DescricaoServico) : IRequest<Resultado<ChamadosResponseDTO>>;

    public class FinalizarChamadoManipulador : IRequestHandler<FinalizarChamadoComando, Resultado<ChamadosResponseDTO>>
    {
        public async Task<Resultado<ChamadosResponseDTO>> Handle(FinalizarChamadoComando request, CancellationToken cancelarToken)
        {
            try
            {
                return Resultado<ChamadosResponseDTO>.Sucesso(new ChamadosResponseDTO());
            }
            catch (Exception ex)
            {
                return Resultado<ChamadosResponseDTO>.Erro(ex.Message);
            }
            
        }
    }
}
