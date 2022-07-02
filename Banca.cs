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
            Console.WriteLine("Inserisci il cognome:");
            string cognome = Console.ReadLine();
            Console.WriteLine("Inserisci codice fiscale");
            string codiceFiscale = Console.ReadLine();
            Console.WriteLine("Inserisci stipemdio");
            float stipendio = float.Parse(Console.ReadLine());
            Cliente newCliente = new Cliente(nome,cognome,codiceFiscale,stipendio);
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
            cliente.Cognome = clienteModificato.Cognome;
            cliente.CodiceFiscale = clienteModificato.CodiceFiscale;
            cliente.Stipendio = clienteModificato.Stipendio;
            
        }

        public void AggiungiPrestito(Cliente cliente, float ammontare)
        {
            Prestito prestito = new Prestito(cliente, ammontare);
            prestiti.Add(prestito);
        }
        public void ListaPrestiti()
        {
            if (prestiti != null)
            {
                int pos = 1;
                foreach (Prestito prestito in prestiti)
                {
                    Console.WriteLine(pos + ". ");
                    prestito.Stampa();
                    pos++;
                }
            }
            else
            {
                Console.WriteLine("La banca al momento non ha prestiti");
            }
        }

        public Cliente RicercaClienteCF(string codiceFiscale)
        {
            foreach (Cliente cliente in clienti)
            {
                if (codiceFiscale == cliente.CodiceFiscale)
                {
                    return cliente;
                }
            }
            return null;
        }

        public float TotalePrestiti(string codiceFiscale)
        {
            float sum = 0;
            foreach(Prestito prestito in prestiti)
            {
                if(prestito.Intestatario.CodiceFiscale == codiceFiscale)
                {
                    sum = sum + prestito.Ammontare;
                }
            }
            return sum;
        }
    }
}
