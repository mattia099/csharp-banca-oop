using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal class Menu
    {
        public static void mainPage(Banca banca)
        {
            


            Console.WriteLine("\n*** MENU BANCA ***");

            Console.WriteLine("1. Lista clienti");
            Console.WriteLine("2. Aggiungi cliente");
            Console.WriteLine("3. Modifica cliente");
            Console.WriteLine("4. Ricerca cliente");
            Console.WriteLine("5. Aggiunta prestito");
            Console.WriteLine("6. Esci dal programma\n");

            uint input = Convert.ToUInt32(Console.ReadLine());
            

            switch (input)
            {
                case 1:
                    Console.WriteLine("---Lista Clienti---");
                    banca.ListaClienti();
                    mainPage(banca);
                    break;
                case 2:
                    Console.WriteLine("---Aggiunta Cliente---");
                    Cliente nuovoCliente = Banca.CreaCLiente();
                    banca.NuovoCliente(nuovoCliente);
                    mainPage(banca);
                    break;
                case 3:
                    Console.WriteLine("---Modifica Cliente---");
                    int modifica = Banca.RichiediCliente();
                    Cliente clienteMod = banca.CercaCLiente(modifica);
                    banca.ModificaCliente(clienteMod);
                    mainPage(banca);
                    break;
                case 4:
                    Console.WriteLine("---Ricerca Cliente---");
                    int selezionato = Banca.RichiediCliente();
                    Cliente clienteSelezionato = banca.CercaCLiente(selezionato);
                    mainPage(banca);
                    break;
                case 5:
                    Console.WriteLine("---Inserimento Prestito---");
                    banca.ListaClienti();
                    int numCliente = Banca.RichiediCliente();
                    Cliente cliente = banca.CercaCLiente(numCliente);
                    Console.WriteLine("Aggiungere ammontare del prestito");
                    float ammontare = float.Parse(Console.ReadLine());
                    Prestito prestito = banca.AggiungiPrestito(cliente, ammontare);
                    Console.WriteLine($"Lista prestiti di banca {banca.Nome}");
                    banca.ListaPrestiti();
                    mainPage(banca);
                    break;
                case 6:
                    return;
                    break;
                    
            }
        }

    }
}

