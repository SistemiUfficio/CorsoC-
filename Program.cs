// See https://aka.ms/new-console-template for more information
// creare un programma che mi vada attraverso l'uso di una funzione, a calcolare la rata di scadenza del mago, dato le rate in input della condizione di pagamento 


//funzione calcola rata 
//convertire data in stringa  = DateTime.Parse(dataStringa)
//DateTime nuovaData = dataIniziale.AddDays(giorniDaAggiungere);
using System.Globalization;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

static string CalcolaRate(DateTime datarata, int giorni, int rate )
{

    int calcologiorni = giorni * rate;

        DateTime nuovaData = datarata.AddDays(calcologiorni - 1);

        return nuovaData.ToString("dd/MM/yyyy");
    


}


//funzione per rilevamento errore 
static string Errore(bool esito, int blocco)
{
    string errore = $"Hai inserito un valore non valido nel blocco {blocco}. Rilancia il programma";
    return errore;

}


//input condizione di pagamento 
try
{
    Console.WriteLine("inserisci data della fattura per calcolare la rata del pagamento:");
    Console.Write("Giorno: ");
    int giorno = int.Parse(Console.ReadLine());
    Console.Write("Mese: ");
    int mese = int.Parse(Console.ReadLine());
    Console.Write("Anno : ");
    int anno = int.Parse(Console.ReadLine());

    

    Console.WriteLine($"{Environment.NewLine}");

    DateTime datainiziale = new DateTime(anno, mese, giorno);
    Console.Write("Numero di rate: ");
    int nrate = int.Parse(Console.ReadLine());

    Console.Write("Giorni di distanza tra le rate: ");
    int giorniagg = int.Parse(Console.ReadLine());



    //scrivo il risultato 
    for (int i = 1; i < nrate + 1; i++)
        Console.WriteLine($"Rata {i}: {CalcolaRate(datainiziale, giorniagg, i)}");
}
catch
{
    int blocco = 0;
    bool esitocatch = true;
    Console.WriteLine($"{Errore(esitocatch,blocco)}");

}



Console.WriteLine($"{Environment.NewLine}");

//creare una matrice con le fatture , data inserimento delle fatture , giorni da calcolare 
//blocco1
Console.Write("Numero delle fatture:");
int nrfatture1 = int.Parse(Console.ReadLine());

int[] Fatture = new int[nrfatture1];  //NRDELLE FATTURE 



Console.Write("Numero di rate: ");
int nrate1 = int.Parse(Console.ReadLine());  //NUMERO DELLE RATE 
int[] Nrrate1 = new int[nrate1];

string[,] rate = new string[nrfatture1, nrate1];  //MATRICE 

Console.WriteLine($"{Environment.NewLine}");
Console.Write("Giorni di distanza tra le rate: "); //DISTANZA TRA LE RATE 
int giorniagg1 = int.Parse(Console.ReadLine());




//STAMPO LE FATTURE CON LA MATRICE 
//Console.WriteLine("inserisci data della fattura per calcolare la rata del pagamento:");
//Console.Write("Giorno: ");
//int giorno1 = int.Parse(Console.ReadLine());
//Console.Write("Mese: ");
//int mese1 = int.Parse(Console.ReadLine());
//Console.Write("Anno : ");
//int anno1 = int.Parse(Console.ReadLine());



Console.WriteLine($"inserisci data fattura nr {i}");
string dataInput = Console.ReadLine();


//DateTime datainiziale1 = new DateTime(anno1, mese1, giorno1);  // DATA DI PARTENZA 

//STAMPO LE RATE 
Console.WriteLine($"{Environment.NewLine}");
for (int i = 1; i < Nrrate1.Length + 1; i++) Console.Write($"\t\t\tRata:{i}");



for (int i = 1;i < rate .GetLength (0) +1; i++) //stampo matrice





// Tentativo di parsing della data
DateTime dataIniziale;
bool isDataValida = DateTime.TryParseExact(dataInput, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataIniziale);

Console.WriteLine($"{dataIniziale}");


{
    Console.WriteLine();
    Console.Write($"Fattura nr:{i.ToString().PadRight (5,' ')}");
  for (int j = 1; j < rate.GetLength (1)+1; j++)
  {

        Console.Write($"\t\t{CalcolaRate(datainiziale1,giorniagg1 ,j)}");


    }


}


Console.WriteLine($"{Environment.NewLine}");

