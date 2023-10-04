using System.Diagnostics;
using System.Runtime.CompilerServices;

int player1strength=0;
int player1defense=0 ;
int player1statsum=0;

int player2strength=0;
int player2defense=0 ;
int player2statsum=0;

string playerresponse = "";
string fighter1namn = "";
string fighter2namn = "";
int player1health = 100;
int roundcount =0;
int player2health = 100;
Random generator = new Random();
int skadagjord = generator.Next(15, 30);



Console.WriteLine("Du typ ska slås mot någon");
Console.WriteLine("Vad heter du");
fighter1namn = Console.ReadLine();
Console.WriteLine("Vad heter din motståndare");
fighter2namn = Console.ReadLine();

P1Stats();

P2Stats();

Console.WriteLine($"Detta är en fight mellan {fighter1namn} och {fighter2namn}");

Console.WriteLine("skriv aa om du förstår");
playerresponse = Console.ReadLine();
playerresponse = playerresponse.ToLower();

if (playerresponse == "aa"&& player1statsum<=20 && player2statsum<=20)
{
    while (player1health > 0 || player2health > 0)
    {
        roundcount++;

        if (player2health <= 0 ){
        Console.WriteLine($"{fighter1namn} du vann typ");
        Console.ReadLine();
        break;
        }  

        Console.WriteLine($"------------------ Round {roundcount} ({fighter1namn}s turn) --------------------");

        skadagjord = generator.Next(15, 30);
        player2health -= ((skadagjord  + 1*player1strength) -(-1/10)*player2defense);
        Console.WriteLine($"Du slår och gör {((skadagjord  + 1*player1strength) -(-1/10)*player2defense)} skada till {fighter2namn} ({player2health}/100 hp)");
        Console.ReadLine();
        
        if (player2health <= 0 ){
        Console.WriteLine($"{fighter1namn} du vann typ");
        Console.ReadLine();
        break;
        }

        Console.WriteLine($"------------------ Round {roundcount} ({fighter2namn}s turn) --------------------");

        skadagjord = generator.Next(15, 30);
        player1health -= ((skadagjord  + 1*player2strength) -(-1/10)*player1defense);
        Console.WriteLine($"Du blir slagen och tar {((skadagjord  + 1*player2strength) -(-1/10)*player1defense)} skada från {fighter2namn} ({player1health}/100 hp)");
        Console.ReadLine();
    };
}
if (player1statsum>=20 && player2statsum>=20)
{
Console.WriteLine("Du satte för mycke stats now die");
Console.ReadLine();
}





void P1Stats()
{
Console.WriteLine("Vad ska din strength vara (1/15), Max 20 totalt)");
player1strength = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vad ska din defense vara (1/15), Max 20 totalt)");
player1defense = Convert.ToInt32(Console.ReadLine());
player1statsum = player1strength + player1defense;
}

void P2Stats()
{
Console.WriteLine("Vad ska motståndarens strength vara (1/15), Max 20 totalt)");
player2strength = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vad ska motståndarens defense vara (1/15), Max 20 totalt)");
player2defense = Convert.ToInt32(Console.ReadLine());
player2statsum = player2strength + player2defense;
}
