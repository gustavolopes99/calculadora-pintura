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

            Calculadora calc = new Calculadora();

            calc.areaParedes = 2 * (largura + profundidade) * altura;
            Console.WriteLine(calc.areaParedes);

            Console.Write("A área do teto é: ");
            calc.areaTeto = largura * profundidade;
            Console.WriteLine(calc.areaTeto);

            Console.Write("A litragem de tinta necessária é : ");
            Console.WriteLine($"{calc.areaParedes + calc.areaTeto / 10} litros");
        }
    }
}