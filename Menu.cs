using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal class Menu
    {
        public static void menu(Banca banca)
        {
            


            Console.WriteLine("\n--- MENU BANCA ---");

            Console.WriteLine("1. Lista clienti");
            Console.WriteLine("2. Aggiungi cliente");
            Console.WriteLine("3. Modifica cliente");
            Console.WriteLine("4. Ricerca cliente");
            Console.WriteLine("5. Aggiunta prestito");
            Console.WriteLine("6. Lista prestiti");
            Console.WriteLine("7. Ammontare prestiti di un singolo cliente");
            Console.WriteLine("8. Clear Console");
            Console.WriteLine("9. Esci dal programma\n");

            uint input = Convert.ToUInt32(Console.ReadLine());
            

            switch (input)
            {
                case 1:
                    Console.WriteLine("---Lista Clienti---");
                    banca.ListaClienti();
                    menu(banca);
                    break;
                case 2:
                    Console.WriteLine("---Aggiunta Cliente---");
                    Cliente nuovoCliente = Banca.CreaCLiente();
                    banca.NuovoCliente(nuovoCliente);
                    menu(banca);
                    break;
                case 3:
                    Console.WriteLine("---Modifica Cliente---");
                    int modifica = Banca.RichiediCliente();
                    Cliente clienteMod = banca.CercaCLiente(modifica);
                    banca.ModificaCliente(clienteMod);
                    menu(banca);
                    break;
                case 4:
                    Console.WriteLine("---Ricerca Cliente---");
                    int selezionato = Banca.RichiediCliente();
                    Cliente clienteSelezionato = banca.CercaCLiente(selezionato);
                    menu(banca);
                    break;
                case 5:
                    Console.WriteLine("---Inserimento Prestito---");
                    banca.ListaClienti();
                    Console.WriteLine();
                    int numCliente = Banca.RichiediCliente();
                    Cliente cliente = banca.CercaCLiente(numCliente);
                    Console.WriteLine("Aggiungere ammontare del prestito");
                    float ammontare = float.Parse(Console.ReadLine());
                    banca.AggiungiPrestito(cliente, ammontare);
                    Console.WriteLine();
                    Console.WriteLine($"Lista prestiti di banca {banca.Nome}");
                    banca.ListaPrestiti();
                    menu(banca);
                    break;
                case 6:
                    banca.ListaPrestiti();
                    menu(banca);
                    break;
                case 7:
                    Console.WriteLine("Ammontare totale dei prestiti concessi");
                    Console.WriteLine("Inserisci Codice Fiscale del cliente");
                    string codiceFiscale = Console.ReadLine();
                    float sum = banca.TotalePrestiti(codiceFiscale);
                    Console.WriteLine($"Somma totale dei prestiti concessi = {sum}");
                    menu(banca);
                    break;
                case 8:
                    Console.Clear();
                    menu(banca);
                    break;
                case 9:
                    return;
                    break;
                    
            }
        }

    }
}

