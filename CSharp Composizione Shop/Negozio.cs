using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Composizione_Shop
{
    internal class Negozio
    {
        //ATTRIBUTI

        private string nome;
        private string citta;
        private string addressN;
        private int numeroCivico;
        
        //PROPERTY

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                this.nome = value;
            }
        }
        public string Citta
        {
            get
            {
                return citta;
            }
        }
        public string Indirizzo { get 
            {
                return addressN;
            }
        }

        public int NumeroCivico { get 
            {
                return numeroCivico;
            }
        }

        List<Prodotto> listaProdotti;

        //COSTRUTTORE

        public Negozio(string nome, string citta, string indirizzo , int numeroCivico) 
        {
            this.nome = nome;
            this.citta = citta;
            this.numeroCivico = numeroCivico;
            this.addressN = indirizzo;

            this.listaProdotti = new List<Prodotto>();

        }



        //METHODS

        public void SetList(List<Prodotto>ListaProdottiDaAggiungere)
        {
            foreach(Prodotto ProdottodaAggiungere in ListaProdottiDaAggiungere)
            {
                this.listaProdotti.Add(ProdottodaAggiungere);
            }
        }

        public void AggiungereProdotto(Prodotto prodotto) 
        {
            this.listaProdotti.Add(prodotto);
        }

        public string ListaProdotti()
        {
            string prodotti = "";
            foreach (Prodotto item in this.listaProdotti)
            {
                
                prodotti += item.getStringProdotto() + "\n\n";

            }
            return prodotti;
        }
        
        public string getStringNegozio()
        {
            string rappresentazioneInStringa = "\nNome negozio : " + this.Nome + "\n";
            rappresentazioneInStringa += "Città del Negozio: " + this.Citta + "\n";
            rappresentazioneInStringa += "Indirizzo del negozio : " + this.Indirizzo + "\n";
            rappresentazioneInStringa += "Civico del negozio: " + this.NumeroCivico + "\n\n";
            


            return rappresentazioneInStringa;
        }

       
        public int NumberOfItems()
        {
            return listaProdotti.Count;
        }
    }
}
