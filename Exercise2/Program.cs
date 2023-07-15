namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, adicao, subtracao, multiplicacao;
            float divisao;

            num1 = 10;
            num2 = 5;
            adicao = num1 + num2;
            subtracao = num1 - num2;
            multiplicacao = num1 * num2;
            divisao = (float)num1 / (float)num2;

            Console.WriteLine("A soma é " + adicao);
            Console.WriteLine("A subtracao é " + subtracao);
            Console.WriteLine("A multiplicacao é " + multiplicacao);
            Console.WriteLine("A divisao é " + divisao);
            Console.ReadLine();
        }
    }
}