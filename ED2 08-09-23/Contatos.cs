using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED2_08_09_23
{
    public class Contatos
    {
        public List<Contato> Agenda { get; }

        public Contatos()
        {
            Agenda = new List<Contato>();
        }

        public bool adicionar(Contato c)
        {
            Agenda.Add(c);
            return true;
        }
        public Contato pesquisar(String email)
        {
            int Id= Agenda.FindIndex(contato => contato.Email == email);
            if (Id == - 1 ) return new Contato();
            return Agenda[Id];
        }
        public bool alterar(Contato contato)
        {
            int index = Agenda.IndexOf(contato);

            if (index >= 0)
            {
                Agenda[index] = contato;
                return true;
            }

            return false;
        }
        public bool remover(String email)
        {
            int Id = Agenda.FindIndex(contato => contato.Email == email);
            if (Id == -1) return false;
            Agenda.RemoveAt(Id);
            return true;
        }
    }
}
