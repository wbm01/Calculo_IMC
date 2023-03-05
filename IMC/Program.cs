using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        float altura, peso, imc;
        char sexo;

        Console.WriteLine("Informe o sexo: ");
        sexo = char.Parse(Console.ReadLine());

        if ((sexo == 'm') || (sexo == 'f'))
        {
            Console.WriteLine("Informe o peso: ");
            peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura: ");
            altura = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.WriteLine("\nResultado: {0}", imc.ToString("f2"));

            if (sexo == 'm')
            {
                if (imc < 20.7)
                {
                    Console.WriteLine("Abaixo do peso.");
                }
                else if ((imc >= 20.7) && (imc <= 26.4))
                {
                    Console.WriteLine("Peso ideal.");
                }
                else if ((imc >= 26.5) && (imc <= 27.8))
                {
                    Console.WriteLine("Um pouco acima do peso.");
                }
                else if ((imc >= 27.9) && (imc <= 31.1))
                {
                    Console.WriteLine("Acima do peso.");
                }
                else
                {
                    Console.WriteLine("Obesidade.");
                }
            }
            if (sexo == 'f')
            {
                if (imc < 19.1)
                {
                    Console.WriteLine("Abaixo do peso.");
                }
                else if ((imc >= 19.1) && (imc <= 25.8))
                {
                    Console.WriteLine("Peso ideal.");
                }
                else if ((imc >= 25.9) && (imc <= 27.3))
                {
                    Console.WriteLine("Um pouco acima do peso.");
                }
                else if ((imc >= 27.4) && (imc <= 32.3))
                {
                    Console.WriteLine("Acima do peso.");
                }
                else
                {
                    Console.WriteLine("Obesidade.");
                }
            }
        }
        else
        {
            Console.WriteLine("O sexo informado é inválido!");
        }
    }
}