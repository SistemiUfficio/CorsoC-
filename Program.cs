// memorizzazione di 50 numeri casuali in un array 


int max_numeri = 10;



Random r = new Random();
int[] casuali = new int[max_numeri];

for (int i = 0; i < max_numeri; i++) casuali[i] = r.Next(50);

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