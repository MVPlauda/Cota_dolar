// Construa um algoritmo que leia a cotação do dólar, 
// leia um valor em dólares, 
// converta esse valor para Real e mostre o resultado.



internal class program
{
    private static void Main()
    {
        float dolar, real, cotação;

        Console.Write("Insira a cotação atual: ");
        cotação = float.Parse(Console.ReadLine());
        Console.Write("Insira um valor para ser transformado: ");
        dolar = float.Parse(Console.ReadLine());

        real = dolar * cotação;

        Console.WriteLine($"O valor transformado em real é: {real}");
    }
}

