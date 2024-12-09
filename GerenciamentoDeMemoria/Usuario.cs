using System.Diagnostics;

namespace GerenciamentoDeMemoria;

internal class Usuario
{
    public Usuario(string nome, string email, List<string> telefones)
    {
        Nome = nome;
        Email = email;
        Telefones = telefones;
        ChavesDeAcesso = new List<Guid>(new Guid[10]);
        //Stopwatch stopwatch = new Stopwatch();
        //stopwatch.Start();
        
        //for (int i = 0; i < 1000000; i++)
        //{
        //    ChavesDeAcesso.Add(Guid.NewGuid());
        //}

        //stopwatch.Stop();
        //Console.WriteLine($"Tempo total em list ms: {stopwatch.Elapsed.TotalMilliseconds}");

        ChavesDeAcessoLinkedList = new LinkedList<Guid>();
        Stopwatch stopwatch2 = new Stopwatch();
        stopwatch2.Start();
        ChavesDeAcessoLinkedList.AddLast(new Guid());
        for (int i = 0; i < 1000000; i++)
        {
            ChavesDeAcessoLinkedList.AddAfter(ChavesDeAcessoLinkedList.First, Guid.NewGuid());
        }
        stopwatch2.Stop();
        Console.WriteLine($"Tempo total em linkedlist ms: {stopwatch2.Elapsed.TotalMilliseconds}");
    }

    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public List<string> Telefones { get; set; }
    // Quando a inserção é sempre no final da lista, o ideal é usar uma lista normal
    public List<Guid> ChavesDeAcesso { get; set; }
    // Quando a inserção é ordenada é melhor utilizar uma linked list
    public LinkedList<Guid> ChavesDeAcessoLinkedList { get; set; }

    public void PadronizaTelefones()
    {
        Telefones = Telefones.Select(telefone =>
        {
            if (telefone.Length == 8)
            {
                telefone = 9 + telefone;
            }
            return telefone;
        }).ToList();
    }

    public void ExibeTelefones()
    {
        Telefones.ForEach(telefone => Console.WriteLine(telefone));
    }
}
