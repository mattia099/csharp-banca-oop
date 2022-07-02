// See https://aka.ms/new-console-template for more information


using csharp_banca_oop;
Banca banca = new Banca("Intesa San Paolo");
Cliente clienteFake1 = new Cliente("Pippo", "Rossi", "PDAKFWEF486", 2000);
Cliente clienteFake2 = new Cliente("Ernesto", "Gialli", "EFEFRIJ5987", 1800);
Cliente clienteFake3 = new Cliente("Francesco","Verdi","FRNCVRD5884",2200);
Cliente clienteFake4 = new Cliente("Pino","Pini","PNPN58DW8W9",1500);
banca.NuovoCliente(clienteFake1);
banca.NuovoCliente(clienteFake2);
banca.NuovoCliente(clienteFake3);
banca.NuovoCliente(clienteFake4);
Menu.menu(banca);