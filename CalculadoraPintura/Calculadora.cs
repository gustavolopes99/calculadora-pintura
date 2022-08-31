namespace CalculadoraPintura
{
    public class Calculadora
    {
        private double areaParedes { get; set; }
        private double areaTeto { get; set; }

        public double CalcularAreaParede(double largura, double profundidade, double altura)
        {
            areaParedes = 2 * (largura + profundidade) * altura;
            return areaParedes;
        }
        public double CalcularAreaTeto(double largura, double profundidade)
        {
            areaTeto = largura * profundidade;
            return areaTeto;
        }
        public double CalcularLitragemNecessaria()
        {
            return (areaParedes + areaTeto) / 10;
        }
    }
}