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
            const double altura = 2.9;
            double areaParedes = 2 * (largura + profundidade) * altura;
            Console.WriteLine(areaParedes);

            Console.Write("A área do teto é: ");
            double areaTeto = largura * profundidade;
            Console.WriteLine(areaTeto);

            Console.Write("A litragem de tinta necessária é : ");
            Console.WriteLine($"{areaParedes + areaTeto / 10} litros");
        }
    }
}