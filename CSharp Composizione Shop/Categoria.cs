using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Composizione_Shop
{
    internal class Categoria
    {
        //ATTRIBUTI

        private string nome;

        private int codice;
        //PROPERTIES

        public string Nome 
        {
            get { return nome; } set {  nome = value; }
        }

        public int Codice { get{ return codice; }
                }

        //COSTRUTTORE

        public Categoria(string nome )
        
        {
            this.nome = nome;
            codice = RandomGen();
            

        }



        //METODI

        private int RandomGen() //questo metodo dovrebbe generare un random int e poi restituirlo
        {
            Random rnd = new Random();
            int numeroCifre = rnd.Next(1, 9);

            int codeInt = 0;

            switch (numeroCifre)
            {
                case 1:
                    codeInt = rnd.Next(1, 10);
                    break;
                case 2:
                    codeInt = rnd.Next(10, 100);
                    break;
                case 3:
                    codeInt = rnd.Next(100, 1000);
                    break;
                case 4:
                    codeInt = rnd.Next(1000, 10000);
                    break;
                case 5:
                    codeInt = rnd.Next(10000, 1000000);
                    break;
                case 6:
                    codeInt = rnd.Next(100000, 1000000);
                    break;
                case 7:
                    codeInt = rnd.Next(1000000, 10000000);
                    break;
                case 8:
                    codeInt = rnd.Next(10000000, 100000000);
                    break;

            }

            return codeInt;

        }

        public string StampaInfoCodice()
        {
            string codice = "Nome Categoria : " + Nome + "\nCodice categoria : " + this.Codice;

            return codice;
        }
    }
}
