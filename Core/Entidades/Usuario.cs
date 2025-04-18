using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Core.Enums;

namespace Core.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public PerfilUsuario PerfilUsuario { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
