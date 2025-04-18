using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Enums;

namespace Core.Entidades
{
    public class Chamado
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public Prioridade Prioridade { get; set; }
        public DateTime DataAbertura { get; set; }
        public StatusChamado Status { get; set; }
        public int? AceitaChamadoId { get; set; }
        public Usuario AceitaChamado { get; set; }
        public DateTime? DataConclusao { get; set; }
    }
}
