using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Core.Entidades
{
    public class HistoricoChamado
    {
        public int Id { get; set; }
        public int ChamadoId { get; set; }
        public Chamado Chamado { get; set; }
        public string Descricao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string UsuarioAlteracao { get; set; }
    }
}
