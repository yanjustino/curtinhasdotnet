using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAsNoTrack
{
    class Program
    {
        private static Context db = new Context();

        static void Main(string[] args)
        {
            Contato contato = new Contato("Sharpeiro", "8888-9999");
            
            Criar(contato);
            Atualizar(contato.Id);
            Excluir(contato.Id);

            Console.Read();
        }

        private static void Criar(Contato contato)
        {
            db.Contatos.Add(contato);
            db.SaveChanges();

            Console.WriteLine(string.Format("contato {0} criado com id {1} e numero {2}",
                contato.Nome, contato.Id, contato.Numero));

            Console.WriteLine();
        }

        private static void Atualizar(int id)
        {
            var contato = db.Contatos.Find(id);
            contato.Numero = "8888-7777";

            db.Entry(contato).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(string.Format("contato {0} atualizado com id {1} e numero {2}",
                contato.Nome, contato.Id, contato.Numero));

            Console.WriteLine();
        }
       
        private static void Excluir(int id)
        {
            var contato = db.Contatos.Find(id);
            db.Contatos.Remove(contato);
            db.SaveChanges();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Format("contato {0} removido com id {1} e numero {2}",
                contato.Nome, contato.Id, contato.Numero));
        }

    }
}
