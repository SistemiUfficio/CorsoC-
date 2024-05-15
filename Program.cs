// memorizzazione di 50 numeri casuali in un array 


using System;

int max_numeri = 20;



Random r = new Random();
int[] casuali = new int[max_numeri];
for (int i = 0; i < max_numeri; i++)
{
    casuali[i] = r.Next(10);
}
int minimo = casuali[0];
int massimo = casuali[0];



foreach (int num in casuali)
{
    Console.WriteLine(num);


    //TROVO IL MASSIMO E IL MINIMO 
    if (minimo >= num)
    {
        minimo = num;
    }
    else if (massimo <= num) {

        massimo = num;
    }
    
}

Console.WriteLine($"valore minimo {minimo} e valore massimo {massimo}");



//sommatoria

long somma = 0;

foreach (int n in casuali)
{
    somma += n;

}
Console.WriteLine($"La somma è: {somma}");

//posizione di un elemento cercato 
Console.WriteLine("inserisci valore da ricercare");

string valore = Console.ReadLine();
int contatore = 0;

if (int.TryParse(valore, out int valoreintero))

{

    for (int i = 0; i < max_numeri; i++)
    {

        if (casuali[i].ToString() == valore)
        {
            Console.WriteLine($"Il valore che cercavi si trova alla posizione: {i + 1}");
            contatore++;

        }
    }
}
 else
{ Console.WriteLine("Trovato dei caratteri diversi da numeri"); }


Console.WriteLine($"Il valore è comparso: {contatore} volte");


// Inserire o eliminare elementi dalla lista
// Per esempio, aggiungiamo un nuovo numero alla fine della lista
//casuali.Add(42);

// O eliminiamo il primo elemento della lista
//casuali.RemoveAt(0);

// E così via...


Console.WriteLine("aggiungere un record? scrivi si se vuoi continuare");
string risposta= Console.ReadLine();

if (risposta=="si")
{
    Array.Resize(ref casuali, max_numeri + 1);

    Console.WriteLine($"Ora il numero toale di valori nell'array è di: {max_numeri} ");
    Console.WriteLine("inserisci un valore intero:");
    int numeroins = int.Parse (Console.ReadLine());

    casuali[max_numeri] = numeroins;
}

Console.WriteLine($"Ora il numero toale di valori nell'array è di: {max_numeri} ");

Console.WriteLine("eliminare un record? scrivi si se vuoi continuare");
string risposta2 = Console.ReadLine();

if (risposta2 == "si")
{
    Array.Resize(ref casuali, max_numeri - 1);


    Console.WriteLine($"Ora il numero toale di valori nell'array è di: {max_numeri} " );
}



//inserimento o eliminazione di un array 






