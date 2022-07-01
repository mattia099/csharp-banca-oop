// See https://aka.ms/new-console-template for more information


using csharp_banca_oop;
Banca banca = new Banca("Intesa San Paolo");
Cliente clienteFake1 = new Cliente("Pippo");
Cliente clienteFake2 = new Cliente("Ernesto");
Cliente clienteFake3 = new Cliente("Francesco");
Cliente clienteFake4 = new Cliente("Pino");
banca.NuovoCliente(clienteFake1);
banca.NuovoCliente(clienteFake2);
banca.NuovoCliente(clienteFake3);
banca.NuovoCliente(clienteFake4);
Menu.mainPage(banca);