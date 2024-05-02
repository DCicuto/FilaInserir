using FilaInserção;
namespace FilaInserção;



internal class Progam
{
    private static void Main(string[] args)
    {
        Console.WriteLine("HELLO, FILA");

        //Fila pessoa está com o ponteiro criado
        FilaPessoa filaPessoa = new(); // é sempre palavra reserva p metodos construtores

        filaPessoa.Push(new("Dai"));
        Console.WriteLine();
        filaPessoa.Push(new("Ana"));
        filaPessoa.Push(new("Alexa"));
        filaPessoa.Push(new("Odair"));
        filaPessoa.RunOver();

        Console.WriteLine("Primera pessoa da fila foi retirada");
        filaPessoa.Pop();
        filaPessoa.RunOver();
       
    }
}