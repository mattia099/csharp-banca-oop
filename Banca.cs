using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal class Banca
    {
        private string nome;
        public string Nome 
        {
            get {
                return nome;
            }
            set {
                this.nome = value;
            }
        }

        

        static List<Cliente> clienti = new List<Cliente>();

        static List<Prestito> prestiti  = new List<Prestito>();

        public Banca(string nome)
        {
            Nome = nome;
        }
    
        public void NuovoCliente(Cliente cliente) 
        {
            clienti.Add(cliente);
        }

        public static Cliente CreaCLiente()
        {
            Console.WriteLine("Inserisci il nome:");
            string nome = Console.ReadLine();
            Cliente newCliente = new Cliente(nome);
            return newCliente;
        }

        public void ListaClienti()
        {
            int pos = 1;
            foreach(Cliente cliente in clienti)
            {
                Console.WriteLine(pos + ". ");
                cliente.Stampa();
                pos++;
            }
        }
       
        internal static int RichiediCliente()
        {
            Console.WriteLine("Inserisci numero del cliente: ");
            int numCliente = int.Parse(Console.ReadLine());
            return numCliente;
        }
        internal Cliente CercaCLiente(int indice)
        {
            indice--;
            if (indice < 0 || indice >= clienti.Count())
            {
                Console.WriteLine("Errore: il cliente selezionato non esiste!");
                return null;
            }
            return clienti[indice];
        }
        public void ModificaCliente(Cliente cliente)
        {
            Console.WriteLine("---Modifica cliente---");
            Cliente clienteModificato = Banca.CreaCLiente();
            cliente.Nome = clienteModificato.Nome;
            
        }

        public Prestito AggiungiPrestito(Cliente cliente, float ammontare)
        {
            Prestito prestito = new Prestito(cliente, ammontare);
            prestiti.Add(prestito);
            return prestito;
        }
        public void ListaPrestiti()
        {
            int pos = 1;
            foreach(Prestito prestito in prestiti)
            {
                Console.WriteLine(pos + ". ");
                prestito.Stampa();
                pos++;
            }
        }
    }
}
