class Calculadora
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine(
                "Escolha uma das opções 1 (Somar), 2 (Subtrair), 3 (Multiplicar), 4 (Dividir) e 0 (Sair):");
            int input = int.Parse(Console.ReadLine());

            if (input == 0)
            {
                return;
            }

            Console.Write("Digite o primeiro número:");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número:");
            double b = Double.Parse(Console.ReadLine());

            double result;

            switch (input)
            {
                case 1:
                    result = a + b;
                    Console.WriteLine($"O resultado da soma é: {result}");
                    break;
                case 2:
                    result = a - b;
                    Console.WriteLine($"O resultado da subtração é: {result}");
                    break;
                case 3:
                    result = a * b;
                    Console.WriteLine($"O resultado da multiplicação é: {result}");
                    break;
                case 4:
                    if (b != 0)
                    {
                        result = a / b;
                        Console.WriteLine($"O resultado da divisão é: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero.");
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
