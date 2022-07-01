namespace csharp_banca_oop
{
    internal class Cliente
    {
        private string nome;
        public Cliente(string nome)
        {
            Nome = nome;
        }

        public string Nome { 
            get {
                return nome;
            } 
            set { 
                this.nome = value;
            } 
        }
        string Cognome { get; set; }  
        string CodiceFiscale { get; set; }  
        int Stipendio { get; set; }

        internal void Stampa()
        {
            Console.WriteLine($"Nome: {this.Nome}");
        }
    }
}