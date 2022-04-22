using Events;

int postitotali;
int c;
string nome_evento;
DateTime data;

try
{




    Console.Write("inserisci il nome dell'evento: ");
    nome_evento = Console.ReadLine();
    Console.Write("inserisci la data dell'evento: ");
    data = DateTime.Parse(Console.ReadLine());
    Console.Write("inserisci il numero dei posti totali ");
    postitotali = int.Parse(Console.ReadLine());


    Console.Write("quanti posti desideri prenotare? ");

    c = int.Parse(Console.ReadLine());




GestoreEventi app = new GestoreEventi(nome_evento,data,postitotali);


app.Prenotaposti(c);






Console.WriteLine(app.ToString());

int t;


int flag2 = 1 ;
do
{
    
Console.WriteLine("vuoi disdire i posti?si/no");


    string s = Console.ReadLine();



    if (s == "si")
    {
        
        t = int.Parse(Console.ReadLine());
        app.Disdici(t);
        

        if (t == app.check)
        {


            flag2 = 1;

        }
        Console.WriteLine(app.ToString());

    }


    if (s == "no")
    {


        flag2 = 0;

    }




}

while (flag2 ==1);

}

                
catch(ArgumentException e)
{
    Console.WriteLine("errore di inserimento" + e.ParamName);



}
catch (InvalidCastException)
{

    Console.WriteLine("data errata");


}

