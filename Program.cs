// See https://aka.ms/new-console-template for more information


using csharp_banca_oop;

Banca banca = new Banca("Intesa San Paolo");

Cliente nuovoCliente = Banca.CreaCLiente();
banca.NuovoCliente(nuovoCliente);

Console.WriteLine();
Console.WriteLine($"----LISTA CLIENTI REGISTRATI {banca.Nome} ----");
banca.ListaClienti();
Console.WriteLine();

int indiceCliente = Banca.RichiediCliente();
Cliente cliente = banca.CercaCLiente(indiceCliente);
banca.ListaClienti();

Console.WriteLine();

//chiedo di inserire indice dell'elemento da modificare
int modifica = Banca.RichiediCliente();
banca.ModificaCliente(modifica);
banca.ListaClienti();
