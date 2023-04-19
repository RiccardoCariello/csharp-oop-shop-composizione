



using CSharp_Composizione_Shop;

//Negozio myNegozio = new Negozio("Trony" , "Roma" , "Via Rio Dei Combattenti" , 65);
//Prodotto myProdotto = new Prodotto("acqua", "bottiglia", 0.80f);
//Console.WriteLine(myNegozio.Citta);

//Console.WriteLine(myProdotto.categoria.Codice);
//Console.WriteLine(myProdotto.getStringProdotto());

Console.WriteLine("Inserisci tutte le info del tuo Negozio : \n Nome:");
string nomeShop = Console.ReadLine();
Console.Write("Città : ");
string citta = Console.ReadLine();
Console.WriteLine("Indirizzo : ");
string indirizzo = Console.ReadLine();
Console.WriteLine("Numero Civico : ");
int numeroCivico = int.Parse(Console.ReadLine());

List<Prodotto> listaProdotti = new List<Prodotto>();

Negozio myNegozio = new Negozio(nomeShop, citta, indirizzo, numeroCivico);


Console.WriteLine("Perfetto! Quanti prodotti vuoi inserire? ");
int numeroProdotti = int.Parse(Console.ReadLine());

Console.WriteLine("Ottimo, vai inseriscili uno per uno! ");

for(int i = 0; i < numeroProdotti; i++)
{
    
    listaProdotti.Add(ProductCreator());
}

myNegozio.SetList(listaProdotti);


Console.WriteLine("\n\n\n Ecco le info del tuo negozio : ");

Console.WriteLine(myNegozio.getStringNegozio());

Console.WriteLine(myNegozio.ListaProdotti());

//metodo

Console.WriteLine("Il numero di prodotti presenti in negozio è : " + myNegozio.NumberOfItems());


Prodotto ProductCreator()
{
    Console.WriteLine("Nome Prodotto : ");
    string name = Console.ReadLine();
    Console.WriteLine("Descrizione");
    string description = Console.ReadLine();
    Console.WriteLine("Prezzo");
    float price = float.Parse(Console.ReadLine());
    Console.WriteLine("Iva");
    int iva = int.Parse(Console.ReadLine());
    Console.WriteLine("Nome della categoria?");
    string nomecategoria = Console.ReadLine();

    Prodotto prodotto = new Prodotto(name, description, price, iva, nomecategoria);
    return prodotto;

}