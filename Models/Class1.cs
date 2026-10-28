using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro_De_Notas.Models
{
    public class RegistroNota
    {
        public string Estudante { get; set; } = "";
        public string Disciplina { get; set; } = "";
        public decimal Nota { get; set; }
    }
}
