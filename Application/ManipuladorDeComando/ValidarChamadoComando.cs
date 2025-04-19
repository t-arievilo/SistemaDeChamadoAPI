using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicacao.DTOs.Chamados;
using MediatR;

namespace Core.ManipuladorDeComando
{
    public record ValidarChamadoComando(int ChamadoId, int UsuarioId, bool Aprovado, string? Feedback) : IRequest<ChamadosResponseDTO>
    {
    }
}
