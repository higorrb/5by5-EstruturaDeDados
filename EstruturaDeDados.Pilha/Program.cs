var dinheiro = new Money();
var dinheiro2 = new Money(200);

var felicidade = new Pilha();

int x = 10;

do
{
    var m = new Money(Random.Shared.Next(1, 100));
    Console.WriteLine("empilhado " + m);
    felicidade.AddElement(m);
    Thread.Sleep(1000);
    Console.Clear();
    
    x--;
} while(x > 0);

Console.WriteLine("Mostrando a pillha empilhada..\n");
felicidade.ShowStack();