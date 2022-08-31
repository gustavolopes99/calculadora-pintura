namespace CalculadoraPintura
{
    public class Calculadora
    {
        public double areaParedes { get; set; }
        public double areaTeto { get; set; }

        public double CalcularAreaParede(double areaParedes, double areaTeto)
        {
            return areaParedes + areaTeto / 10;
        }
    }
}