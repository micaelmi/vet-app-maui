using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetApp.Model
{
    public class Vet
    {
        private string nome;
        private string especialidade;
        private List<Agenda> agenda;

        public string Nome { get => nome; set => nome = value; }
        public string Especialidade { get => especialidade; set => especialidade = value; }
        public List<Agenda> Agenda { get => agenda; set => agenda = value; }
    }
}
