using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entidades;

namespace Aplicacao.DTOs.Chamados
{
    public class ChamadosResponseDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public string Prioridade { get; set; }
        public Usuario AceitaChamadoOperador { get; set; }
        public DateTime? AceitoEm { get; set; }
        public DateTime FinalizadoEm { get; set; }
        public string DescricaoServico { get; set; }
    }
}
