using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicacao.DTOs.Chamados;
using Core.Entidades;

namespace Aplicacao.DTOs.MapeamentoDTO
{
    public static class ParaChamadoResponseDTOExtensao
    {
        public static ChamadosResponseDTO? ParaChamadosDTO(this Chamado chamado)
        {
            if (chamado == null)
            {
                return null;
            }

            return new ChamadosResponseDTO
            {
                Titulo = chamado.Titulo,
                Descricao = chamado.Descricao,
                AceitoEm = chamado.DataAberturaChamado
            };
        }
    }
}
