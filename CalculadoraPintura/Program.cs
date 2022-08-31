namespace CalculadoraPintura
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite a largura do cômodo: ");
            double largura = double.Parse(Console.ReadLine());
            Console.Write("Digite a profundidade do cômodo: ");
            double profundidade = double.Parse(Console.ReadLine());

            Console.Write("A área das paredes é: ");
            Console.WriteLine(2 * (largura + profundidade) * 2.9);

            Console.Write("A área do teto é: ");
            Console.WriteLine(largura * profundidade);
        }
    }
}