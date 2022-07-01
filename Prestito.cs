using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal class Prestito
    {
        private Cliente intestatario;
        private int ammontare;

        public Cliente Intestatario
        {
            get
            {
                return this.intestatario;
            }
            set
            {
                this.intestatario = value;
            }
        }
        public int Ammontare {
            get
            {
                return this.ammontare;
            }
            set
            {
                this.ammontare = value;
            }
        }
        int Rata { get; set; }
        DateTime dataInizio { get; set; }
        DateTime dataFine { get; set; }

        public Prestito(Cliente intestatario,int ammontare)
        {
            this.Intestatario = intestatario;
            this.Ammontare = ammontare;
        }

        public void Stampa()
        {
            Console.WriteLine($"Stampa del prestito: Intestario: Intestatario: {this.Intestatario.Nome}  Ammontare del prestito: {this.Ammontare} ");
        }
    }
}