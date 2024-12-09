// Stack
// Guarda valores primitos e referências (ponteiro) dentro da memória
// bool, int, double, byte...

// Heap
// Guarda valores complexos dentro da memória
// Objetos são guardados na Heap

// LOH -> Large Object Heap
// Quando temos objetos maiores que 85 kb

// A stack armazena variáveis simples, como inteiros, booleanos e números de ponto flutuante.
// Imagine-a como uma pilha de pratos: o último prato colocado é o primeiro a ser retirado.
// Já o heap guarda objetos mais complexos, como nossas classes. Pense nele como um grande depósito onde cada objeto tem seu próprio espaço.
// Quando criamos um objeto, ele recebe um endereço no heap, e esse endereço é o que guardamos na stack como referência.

using GerenciamentoDeMemoria;
using System.Diagnostics;

Stopwatch sw = new Stopwatch();

sw.Start();

for (int i = 0; i < 1000000000; i++)
{
    FormularioDtoClass dto = new FormularioDtoClass("Daniel", "11111111111", "Programador", 100);
    dto.GetHashCode();
}

sw.Stop();

Console.WriteLine($"Tempo class: {sw.Elapsed.TotalMilliseconds}");


sw.Restart();

for (int i = 0; i < 1000000000; i++)
{
    FormularioDtoRecord dto = new FormularioDtoRecord("Daniel", "11111111111", "Programador", 100);
    dto.GetHashCode();
}

sw.Stop();

Console.WriteLine($"Tempo record: {sw.Elapsed.TotalMilliseconds}");

sw.Restart();

for (int i = 0; i < 1000000000; i++)
{
    FormularioDtoStruct dto = new FormularioDtoStruct("Daniel", "11111111111", "Programador", 100);
    dto.GetHashCode();
}

sw.Stop();

Console.WriteLine($"Tempo struct: {sw.Elapsed.TotalMilliseconds}");

sw.Restart();

for (int i = 0; i < 1000000000; i++)
{
    FormularioDtoRecordStruct dto = new FormularioDtoRecordStruct("Daniel", "11111111111", "Programador", 100);
    dto.GetHashCode();
}

sw.Stop();

Console.WriteLine($"Tempo record struct: {sw.Elapsed.TotalMilliseconds}");