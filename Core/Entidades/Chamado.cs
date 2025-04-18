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
        public DateTime DataAberturaChamado { get; set; }
        public StatusChamado Status { get; set; }
        public int? AceitaChamadoOperadorId { get; set; }
        public Usuario AceitaChamadoOperador { get; set; }
        public DateTime? DataConclusaoChamado { get; set; }
        public string Feedback { get; set; }


        public void Aceitar(int userId)
        {
            Status = StatusChamado.EmAndamento;
            AceitaChamadoOperadorId = userId;
            DataAberturaChamado = DateTime.Now;
        }

        public void FinalizarPelaManutencao(string descricaoServico)
        {
            if (Status != StatusChamado.EmAndamento)
            {
                throw new InvalidOperationException("O chamado não está em andamento.");
            }

            Status = StatusChamado.AguardandoValidacao;
            Descricao = descricaoServico;
            DataConclusaoChamado = DateTime.Now;
        }

        public void Validar(bool aprovado, string feedback = null)
        {
            if (Status != StatusChamado.AguardandoValidacao)
            {
                throw new InvalidOperationException("O chamado não está aguardando validação.");
            }

            Status = aprovado ? StatusChamado.Concluido : StatusChamado.Reaberto;
            Feedback = feedback;
        }

    }
}


