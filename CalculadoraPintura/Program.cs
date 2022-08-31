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

            Console.WriteLine(calc.CalcularAreaParede(largura, profundidade, altura));

            Console.Write("A área do teto é: ");

            Console.WriteLine(calc.CalcularAreaTeto(largura, profundidade));



            Console.Write("A litragem de tinta necessária é : ");
            Console.WriteLine($"{calc.CalcularLitragemNecessaria()} litros");
        }
    }
}