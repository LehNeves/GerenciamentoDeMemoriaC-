namespace GerenciamentoDeMemoria
{
    // As Records Structs trazem ótimos benefícios,
    // quando precisamos de imutabilidade e performance
    public readonly record struct FormularioDtoRecordStruct
        (string Nome, string Cpf, string Cargo, int Idade);

    // As records são guardadas na Heap assim como as classes,
    // o uso das records é ideal quando queremos comparação por valores, e também imutabilidade,
    // os campos passados dentro da declaração da Record são imutaves,
    public record FormularioDtoRecord
        (string Nome, string Cpf, string Cargo, int Idade);

    // é possivel criar váriaveis mútaveis, usando records
    //public record FormularioDtoRecord(string Nome, string Cpf, string Cargo)
    //{
    //    public int Idade { get; set; }
    //    // Em caso de propriedades ou atributos de referência,
    //    // a comparação das records podem falhar,
    //    // quando há essa necessidade, precisaria implementar o método Equals,
    //    // para manter o comportamento de comparação de valores.
    //    public List<string> Telefones { get; set; }
    //}

    // A Struct é guardada na Stack, é a mais performática estrutura,
    // porém, na utilização de struct deve se evitar o boxing e unboxing
    // se a manipulação dos dados será complexa, prefira por uma class,
    // se caso pretende utilizar interfaces, também é preferível uma class.
    public struct FormularioDtoStruct
    {
        public FormularioDtoStruct(string nome, string cpf, string cargo, int idade)
        {
            Nome = nome;
            Cpf = cpf;
            Cargo = cargo;
            Idade = idade;
        }

        public string Nome;
        public string Cpf;
        public string Cargo;
        public int Idade;
    }

    // Está estrutura de dados é mais flexivel dentre todas,
    // é ideal para manipulação complexa de dados, não é a mais rápida,
    // mas permite Polimorfismo com velocidade, e Herança
    public class FormularioDtoClass
    {
        public FormularioDtoClass(string nome, string cpf, string cargo, int idade)
        {
            Nome = nome;
            Cpf = cpf;
            Cargo = cargo;
            Idade = idade;

        }

        public string Nome;
        public string Cpf;
        public string Cargo;
        public int Idade;
    }
}
