//il cliente assegna delle attività allo svilppatore (dal suo file al file dello sviluppatore).

//questa attività avviene casualmente in un intervallo di 5-10 secondi; ( Thread.Sleep(1000) );

//qualce volta perà il cliente viene distratto (il programma si chiude casualmente? - oppure c'è un'eccezione)

//quindi il cliente deve ricominciare possibilmente senza riassegnare task già assegnati allo sviluppatore ( che controlli ?? )

//sviluppi


//1.    creare i reader e i writer per leggere dal file
//      C:\\Users\\Utente\\source\\repos\\csharp-developer-simulator\\client_activity.txt
//      al file C:\Users\mistre\source\repos\C:\\Users\\Utente\\source\\repos\\csharp-developer-simulator\\developer_activity.txt
//      dovremmo fare una apertura in lettura di un file e in scrittura di un altro file

//2. leggere la linea = attività e salvarala da qualche parte --> read su client_activity.txt
//3. scrivere l'attivà che abbiamo recuperato nell'atro file --> write su developer_activity.txt

//4. Tread.Sleep(...tot secondi casuali...)

//5. si ricomincia da punto 2 fino alla fine del file client_activity.txt


using System;
using Libreria;
using System.IO;
using System.Threading;

//reader
StreamReader clientActivity = File.OpenText("C:\\Users\\Utente\\source\\repos\\csharp-developer-simulator\\client_activity.txt");
List<string> liste = new List<string>();
while (!clientActivity.EndOfStream)
{
    string attività = clientActivity.ReadLine();
    string lista = attività;
    liste.Add(lista);
}
clientActivity.Close();


//writer
try
{
    string path = "C:\\Users\\Utente\\source\\repos\\csharp-developer-simulator\\developer_activity.txt";

    if (File.Exists(path))
    {
        
        foreach (string lista in liste)
            
        {
            StreamWriter file = new StreamWriter(path);
            file.WriteLine(lista);
            Console.WriteLine(lista);
            Thread.Sleep(800);
            file.Close();
            //StreamWriter attivitaDev = File.AppendText(path);
            //attivitaDev.Close();

        }
        
    }
}
catch (Exception e)
{
Console.WriteLine(e.Message);

}

//foreach (string list in lists)
//{
//    if (lists.Contains(list))
//    {
//        Console.WriteLine("ok", list);
//    }
//    else
//    {
//        Console.WriteLine("dev", list);
//        StreamWriter attivitaDev = File.AppendText(path);
//       attivitaDev.WriteLine(list);
//        attivitaDev.Close();
//    }
//
//    Thread.Sleep(1000);
//}





//******** metodo per scrivere su un foglio
//try
//{
//string pathd = "miopath\\miofileditesto.txt";
//if (!File.Exists(pathd))
//{
// Creo un file
/// StreamWriter file = File.CreateText(pathd);
//scivo le mie linee di testo
//file.WriteLine("Hello");
//file.WriteLine("And");
//file.WriteLine("Welcome");
//file.Close();
//}
//}
//catch (Exception e)
//{

// Console.WriteLine(e.Message);

//}
//********




