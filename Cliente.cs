namespace csharp_banca_oop
{
    internal class Cliente
    {
        private string nome;
        private string cognome;
        private string codiceFiscale;
        private float stipendio;
        public Cliente(string nome, string cognome, string codiceFiscale, float stipendio)
        {
            Nome = nome;
            Cognome = cognome;
            CodiceFiscale = codiceFiscale;
            Stipendio = stipendio;
        }

        public string Nome { 
            get {
                return this.nome;
            } 
            set { 
                this.nome = value;
            } 
        }
        public string Cognome {
            get {
                return this.cognome;
            }
            set {
                this.cognome = value;
            }
        }
        public string CodiceFiscale {
            get
            {
                return this.codiceFiscale;
            } 
            set
            {
                this.codiceFiscale = value;
            }
        }  
        public float Stipendio {
            get
            {
                return this.stipendio;
            }
            set
            {
                this.stipendio = value;
            }
        }

        public void Stampa()
        {
            Console.WriteLine($"Nome: {this.Nome} Cognome: {this.Cognome} Codice Fiscale: {this.codiceFiscale} Stipendio: {this.Stipendio}");
        }
    }
}