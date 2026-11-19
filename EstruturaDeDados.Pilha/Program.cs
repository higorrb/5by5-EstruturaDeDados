var dinheiro = new Money();
var dinheiro2 = new Money(200);

var felicidade = new Pilha();

int x = 10;

do
{
    var m = new Money(Random.Shared.Next(1, 100));
    Console.WriteLine(m + " empilhado");
    felicidade.AddElement(m);
    Thread.Sleep(1000);
    Console.Clear();
    
    x--;
} while(x > 0);

Console.Write("Mostrando a pillha empilhada..\n");
felicidade.ShowStack();
Thread.Sleep(3000);
Console.Clear();

while (felicidade.ElementCount() > 0)
{
    felicidade.RemoveElement();
    if (felicidade.isEmpty())
        break;
    felicidade.ShowStack();
    Thread.Sleep(1000);
    Console.Clear();

}